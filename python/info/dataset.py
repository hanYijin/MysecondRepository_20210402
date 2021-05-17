import csv
import pymysql

def dataSet():
    file = open('covid.csv','r',encoding='utf8')
    conn= pymysql.connect(host= 'localhost', user='root', password='1234', db='spro', charset='utf8')
    curs= conn.cursor()
    sql= "INSERT INTO covid ( num, date, location, contact) VALUES ( %d, %s, %s, %s)";
    rd=csv.reader(file)

    for index, line in enumerate(rd):
        print(index, line)
        row= tuple(line)
        


