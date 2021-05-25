import cv2
#픽셀 수 및 이미지 크기 확인
def doA():
    ka=cv2.imread('img.jpg')
    cv2.imshow('ka',ka)
    cv2.waitKey(0)

    #해당 사진 색상 값(bgr) 출력
    bgrv= ka[100,100]
    print(bgrv)
    print(bgrv[2])

    #roi=ka[100:500, 200:500] #너비 200, 높이 200
    #cv2.imshow("roi",roi)
    #cv2.waitKey(0)