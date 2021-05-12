import csv
import pymysql


def covidDateSave():
    file= open('csvcovid.csv','r',encoding='cp949')
    conn = pymysql.connect(host='localhost', user='root', password='1234', db='spro', charset='utf8')
    curs = conn.cursor()
    sql = "INSERT INTO covid ( num, date, location, contact) VALUES ( %s, %s, %s, %s)";
    rd= csv.reader(file)

    for line in rd:
        row=str(line).split(',')

        try:


            curs.execute(sql, ( row[0].replace("['",""), row[1], row[2],row[3].replace("']", "")))
            print(row)
            conn.commit()
        except Exception as e:
            print(e)
            continue

    file.close()



