import cv2

def doA():
    myimg=cv2.imread('img.jpg')
    cv2.imshow('img',myimg)
    a= cv2.waitKey(0) #0은 무한정 기다릴때 쓴다
    print('a= ',a)

    grayimg= cv2.cvtColor(myimg,cv2.COLOR_BGR2GRAY)
    cv2.imshow("grarimg",grayimg)
    b= cv2.waitKey(5000) #5초 후 자동 종료
    print('b= ',b)