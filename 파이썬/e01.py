import numpy as np
def test():
    ar1= np.random.randint(1,10,size=4).reshape(2,2)
    re_ar1=ar1*10
    re_ar2=ar1+2
    print(ar1)
    print(re_ar1)
    print(re_ar2)

