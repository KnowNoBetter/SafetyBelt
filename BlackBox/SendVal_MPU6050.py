from mpu6050 import mpu6050
import sys
import time
import socket
import json

hostname = sys.argv[1]
port = sys.argv[2]

RestrictPitch = True

sensor = mpu6050(0x68)

time.sleep(1)
timer = time.time()

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
print("..........conneting..........")
s.connect((hostname,int(port)))
print("!!!!!!!!!-connect--!!!!!!!!!")
while True:
    dic = {}
    try:
        # Read Accelerometer raw value
        accel_data = sensor.get_accel_data()
        accX = accel_data['x']
        accY = accel_data['y']
        accZ = accel_data['z']

        # Read Gyroscope raw value
        gyro_data = sensor.get_gyro_data()
        gyroX = gyro_data['x']
        gyroY = gyro_data['y']
        gyroZ = gyro_data['z']
        dic = {'ax':accX, 'ay':accY, 'az':accZ, 'gx':gyroX, 'gy':gyroY, 'gz':gyroZ}

        jsonData = json.dumps(dic)
        print(jsonData)
        s.sendall(str(jsonData).encode('utf-8'))
        recvData = s.recv(1024)
        time.sleep(0.01)
    except Exception as exc:
        print("error")
