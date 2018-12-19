import csv
import os
import glob

dirList =['standing', 'walk', 'run']


with open('dataSet\dataSet02.csv', 'w', encoding='UTF-8', newline='') as csv_out_file:

  filewriter = csv.writer(csv_out_file)
  # filewriter.writerow(['gx', "gy", 'gz', 'ax', 'ay', 'az', 'target','targetName'])

  for i in range(len(dirList)):

    for read_file in glob.glob('dataset\\'+dirList[i]+"\*.csv"):

      with open(read_file, 'r', encoding='UTF-8', newline='') as csv_in_file:

        filereader = csv.reader(csv_in_file)

        for row_list in filereader:
          filewriter.writerow(row_list+[str(i)])