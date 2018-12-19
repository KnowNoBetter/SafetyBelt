from sklearn.neighbors import KNeighborsClassifier
from sklearn.model_selection import train_test_split
from sklearn import metrics
import matplotlib.pyplot as plt
import pandas as pd

''' KNN '''
data = pd.read_csv('HJH_Dataset/dataSet.csv')
X = data[['AngleX', 'AccX', 'AccY', 'AccZ']]
y = data['Target']
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.3, random_state=7)
print(X_train.shape)
print(X_test.shape)

# k_range = range(1, 40)
# score = []
# for k in k_range:
#     knn = KNeighborsClassifier(n_neighbors=k)
#     knn.fit(X_train, y_train)
#     y_pred = knn.predict(X_test)
#     score.append(metrics.accuracy_score(y_test, y_pred))
# plt.plot(score)
# plt.show()

knn = KNeighborsClassifier(n_neighbors=9)
knn.fit(X_train, y_train)
y_pred = knn.predict(X_test)
print("KNN : {}".format(metrics.accuracy_score(y_test, y_pred)))