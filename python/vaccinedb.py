
import csv

import pymysql

conn = pymysql.connect(host='127.0.0.1', user='admin',password='12345678', db='JSP',  charset='utf8')

curs = conn.cursor()

conn.commit()

f = open('insert.csv', 'r')

csvReader = csv.reader(f)

for row in csvReader:
    num = (row[0])
    vclass= (row[1])
    name = (row[2])
    management = (row[3])
    f_name = (row[4])
    postnum=(row[5])
    address=(row[6])
    tel=(row[7])
    print(num)
    print(name)

try:
    sql = """INSERT INTO vaccine" \
          "(num,class,name,management, f_name, postnum, address, tel)" \
          "VALUES (%d,%s, %s, %s, %s, %s, %s, %s)"""

    curs.execute(sql, (num, vclass, name, management, f_name, postnum, address, tel )
E
# db의 변화 저장
conn.commit()

f.close()

conn.close()