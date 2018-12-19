from Kalman import KalmanAngle
from mpu6050 import mpu6050
import smbus
import time
import math
import csv
import sys

filename = sys.argv[1]
label = sys.argv[2]

kalmanX = KalmanAngle()
kalmanY = KalmanAngle()

RestrictPitch = True
radToDeg = 57.2957786
kalAngleX = 0
kalAngleY = 0

sensor = mpu6050(0x68)

time.sleep(1)
#Read Accelerometer raw value
accel_data = sensor.get_accel_data()
accX = accel_data['x']
accY = accel_data['y']
accZ = accel_data['z']

#print(accX,accY,accZ)
#print(math.sqrt((accY**2)+(accZ**2)))
if (RestrictPitch):
    roll = math.atan2(accY,accZ) * radToDeg
    pitch = math.atan(-accX/math.sqrt((accY**2)+(accZ**2))) * radToDeg
else:
    roll = math.atan(accY/math.sqrt((accX**2)+(accZ**2))) * radToDeg
    pitch = math.atan2(-accX,accZ) * radToDeg
# print(roll)
kalmanX.setAngle(roll)
kalmanY.setAngle(pitch)
gyroXAngle = roll
gyroYAngle = pitch
compAngleX = roll
compAngleY = pitch

timer = time.time()
flag = 0
f = open(filename+'.csv', 'w')
wr = csv.writer(f)
while True:
    if(flag >100): #Problem with the connection
        print("There is a problem with the connection")
        flag=0
        continue
    try:
        #Read Accelerometer raw value
        accel_data = sensor.get_accel_data()
        accX = accel_data['x']
        accY = accel_data['y']
        accZ = accel_data['z']

        #Read Gyroscope raw value
        gyro_data = sensor.get_gyro_data()
        gyroX = gyro_data['x']
        gyroY = gyro_data['y']
        gyroZ = gyro_data['z']

        dt = time.time() - timer
        timer = time.time()
        print('1')
        if (RestrictPitch):
	        roll = math.atan2(accY,accZ) * radToDeg
	        pitch = math.atan(-accX/math.sqrt((accY**2)+(accZ**2))) * radToDeg
        else:
            roll = math.atan(accY/math.sqrt((accX**2)+(accZ**2))) * radToDeg
            pitch = math.atan2(-accX,accZ) * radToDeg
    
        gyroXRate = gyroX/131
        gyroYRate = gyroY/131

        if (RestrictPitch):

            if((roll < -90 and kalAngleX >90) or (roll > 90 and kalAngleX < -90)):
	            kalmanX.setAngle(roll)
	            complAngleX = roll
	            kalAngleX   = roll
	            gyroXAngle  = roll
            else:
	            kalAngleX = kalmanX.getAngle(roll,gyroXRate,dt)

            if(abs(kalAngleX)>90):
	            gyroYRate  = -gyroYRate
	            kalAngleY  = kalmanY.getAngle(pitch,gyroYRate,dt)
        else:

            if((pitch < -90 and kalAngleY >90) or (pitch > 90 and kalAngleY < -90)):
	            kalmanY.setAngle(pitch)
	            complAngleY = pitch
	            kalAngleY   = pitch
	            gyroYAngle  = pitch
            else:
	            kalAngleY = kalmanY.getAngle(pitch,gyroYRate,dt)

            if(abs(kalAngleY)>90):
	            gyroXRate  = -gyroXRate
	            kalAngleX = kalmanX.getAngle(roll,gyroXRate,dt)

        gyroXAngle = gyroXRate * dt
        gyroYAngle = gyroYAngle * dt

        compAngleX = 0.93 * (compAngleX + gyroXRate * dt) + 0.07 * roll
        compAngleY = 0.93 * (compAngleY + gyroYRate * dt) + 0.07 * pitch

        if ((gyroXAngle < -180) or (gyroXAngle > 180)):
	        gyroXAngle = kalAngleX
        if ((gyroYAngle < -180) or (gyroYAngle > 180)):
	        gyroYAngle = kalAngleY

        #print("Angle X: " + str(kalAngleX)+"   " +"Angle Y: " + str(kalAngleY))
        #print(str(roll)+"  "+str(gyroXAngle)+"  "+str(compAngleX)+"  "+str(kalAngleX)+"  "+str(pitch)+"  "+str(gyroYAngle)+"  "+str(compAngleY)+"  "+str(kalAngleY))

        wr.writerow([str(kalAngleX), str(kalAngleY), accX, accY, accZ, label])
        time.sleep(0.01)
    except Exception as exc:
    	flag += 1
f.close()
