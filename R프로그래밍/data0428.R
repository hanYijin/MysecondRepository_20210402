#vector 1차원 선형 구조 
ex_vector <- c(1, 2, 3, 4, 5, 6)
ex_vector
print(ex_vector)
ex_vector[c(1,5)] #index 1, 5 요소를 출력
ex_vector[1:3] # index 1~3 요소를 출력

ex_vector <- c('제니','리사','로제','지수')
ex_vector[c(1: 5)]

#Matrix(2차원 배열)
ex_vector <- c(1:6) 
matrix(ex_vector, nrow=2, ncol=3) #1차원 벡터를 2차원 매트릭스로 2행 3열 
#1열 부터 값을 채움 (열 우선으로)
matrix(ex_vector, nrow=3, ncol=2)
matrix(ex_vector, nrow=3, ncol=2, byrow=T)

#Array(다차원 배열)
arr <- c(1:12)
array(arr, dim=c(2, 2, 3))
#2 * 2 * 3 =>3차원 배열
arr <- c(1:12)
array(arr,dim=c(2,2,3), dimnames=list(c('1행','2행'), c('1열','2열'),c('1페이지', '2페이지','3페이지')))


m<-matrix(c(1:5))
m
m <- matrix(c(1:10),nrow=2, byrow=T)
m
