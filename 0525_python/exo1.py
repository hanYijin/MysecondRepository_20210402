import numpy as np

class Ex01:
    def __init__(self):
        print("init")
    def doSave(sel):
        np1= np.arange(0, 10) #0~9 배열 생성
        np2= np.arange(2,15)
        np.save("np1.npz",np1) # np1.npy에 배열 저장
        
    def doLoad(self):
        np1= np.load("np1.npy")

        return np1
    # 복수 객체 저장하기
    def doSavez(self):
        np1= np.random.randint(0,10,(2,5))
        np2= np.arange(0,10)
        np.savez("np1.npz", arr1=np1, arr2=np2)
    # 복수 객체 불러오기
    def doLoads(self):
        data = np.load("np1.npz")
        print(data['arr1'])
        print(data['arr2'])

