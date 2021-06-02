import csv
import pymysql


def covidDateSave():
    file= open('info/vaccine.csv','r', encoding='utf8')
    conn = pymysql.connect(host='localhost', user='admin', password='12345678', db='JSP',  charset='utf8')
    curs = conn.cursor()
    sql = "INSERT INTO vaccine" \
          "(num,class,name,management, f_name, postnum, address, tel)" \
          "VALUES (%d,%s, %s, %s, %s, %s, %s, %s)";
    rd= csv.reader(file)

    for line in rd:
        row=str(line).split(',')

        try:


            curs.execute(sql, (row[0].replace("[", ""),row[1],row[2],row[3],row[4],row[5],row[6].replace("[","")))
            print(row)
            conn.commit()
        except Exception as e:
            print(e)
            continue

    file.close()



