import numpy as np

def doA():
    np1=np.array([1,5,2,9,10])
    np1.sort()
    print(np1)

def doB():
    np1 = np.array([10, 12, 1, 2, 13])
    np1.sort()
    print(np1[1:4:2]) #1~3까지 1증가
    # 슬라이싱 기법
    print(np1[::-2])

def doC():
    np1= np.array([[1,2,3,4,5],[2,3,5,4,8]])
    np1.sort(axis=0)
    print(np1)