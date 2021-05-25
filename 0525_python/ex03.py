import numpy as np

np1= np.linspace(0, 10, 5)
print(np1)

#seed 값 넣기전
#np.random.seed(7)
np2=np.random.randint(0,10,5)

np3=np.array([1,2,4,10,20])
np4=np3
np3[2]=100
print(np4)
# copy 복사는 다른 배열을 생성하여 값 복사가 이루어짐
np4=np.copy(np3)
np3[1]=50
print(np4)

np5=np.array([1,1,2,3,4,2,2,1,3])
print(np.unique(np5))