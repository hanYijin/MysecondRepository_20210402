from csvRW import doRead,doWrite
# from myaqlrw import selectMember, insertMember
from daegudb import read_csv_write_mysql
from flask import Flask #flask.py Flack 클래스를 가져온다
#from covidData import covidDateSave
#from csvCovid import read
from dataset import dataSet
app = Flask(__name__)

@app.route("/")
def index():
    return "잘되나"
if __name__ == '__main__':
    #app.run(host="localhost", debug=True)
    # read_csv_write_mysql()
    #doWrite()
    #doRead()
    # ctrl + alt + shift +l 자동정렬
    # selectMember()
    # insertMember()
    dataSet()
    #read()