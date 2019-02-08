from sklearn.neighbors import KNeighborsClassifier
from sklearn.model_selection import train_test_split
from sklearn import metrics
import matplotlib.pyplot as plt
import numpy as np
import collections
import pandas as pd
import socket
import json
import sys

''' KNN '''
data = pd.read_csv('HJdataSet/dataset/dataSet02.csv')
X = data[['gx', 'gy', 'gz', 'ax', 'ay', 'az']]
y = data['target']
# X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.4, random_state=6)
# print(X_train.shape)
# print(X_test.shape)

# 'gx':str(gyroX), 'gy':str(gyroY), 'gz':str(gyroZ)

# score = []
# for k in k_range:
#     knn = KNeighborsClassifier(n_neighbors=k)
#     knn.fit(X_train, y_train)
#     y_pred = knn.predict(X_test)
#     score.append(metrics.accuracy_score(y_test, y_pred))
# plt.plot(score)
# plt.show()

knn = KNeighborsClassifier(n_neighbors=40)
knn.fit(X, y)
# knn.fit(X_train, y_train)
# y_pred = knn.predict(X_test)
# print("KNN : {}".format(metrics.accuracy_score(y_test, y_pred)))

''' Network Socket '''
host = ''
port = sys.argv[1]
HOST = (host, int(port))

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock.bind(HOST)
sock.listen(2)
print('[Listen] waiting for connection')
rb_conn, addr = sock.accept()
print('[Accept] Raspberry Pi connected')
ma_conn, addr = sock.accept()
print('[Accept] C# Monitoring App connected')

scoreDeque = collections.deque()
for _ in range(0, 5):
    scoreDeque.append("0")
print("1")
while True:
    strData = rb_conn.recv(1024).decode('utf-8')
    jsonData = json.loads(strData)
    data = [jsonData['gx'], jsonData['gy'], jsonData['gz'], jsonData['ax'], jsonData['ay'], jsonData['az']]

    target = knn.predict([data])
    score = knn.predict_proba([data])

    target = ', '.join(str(x) for x in np.array(target).tolist())
    score = ', '.join(str(x) for x in np.array(score).tolist())
    score = score.split(',')

    scoreDeque.popleft()
    scoreDeque.append(target)
    mostCount = collections.Counter(scoreDeque).most_common(1)
    print(mostCount)

    jsonData = {'gx': jsonData['gx'], 'gy': jsonData['gy'], 'gz': jsonData['gz'], 'ax': jsonData['ax'],
                'ay': jsonData['ay'], 'az': jsonData['az'], 'target': mostCount[0][0], 'score': score[int(target)]}
    jsonDumps = json.dumps(jsonData)
    print(jsonData)

    ma_conn.send(jsonDumps.encode('utf-8'))
    rb_conn.send(strData.encode('utf-8'))
    ma_conn.recv(1024).decode('utf-8')

ma_conn.close()
rb_conn.close()