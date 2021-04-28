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
#행 묶음으로 행렬 객체 생성
# rbind()함수
x1 <- c(5, 40, 50:52)
x2 <- c(30, 5, 6:8)
mr <- rbind(x1,x2)
mr
#열 묶음으로 행렬 객체 생성
# cbind() 함수
mc <- cbind(x1,x2)
mc
#matrix()함수 이용 행렬 객체 생성
m3 <-matrix(10:19,2)
m4 <- matrix(10:20,2)
m3
m4

m3[1,]
m3[,5]
m3[2,3]
m3[1,c(2:5)]
length(m3)
ncol(m3)
nrow(m3)

#Array 자료구조: 같은 자료형을 갖는 다차원 배열구조
#배열 생성 함수: array()

vec <- c(1:12)
arr <- array(vec, c(3,2,2))
arr
arr[,,1]
arr[,,2]
#[연습문제]
#1. 'R' 문자가 5회 반복 처리되는 벡터
vec <- rep('R',5)
vec
#2. 1~10까지 3간격으로 연속되는 벡터
vec2 <- seq(1,10,3)
vec2
#3. 1~10까지 3간격으로 연속된 정수가 3회 반복
vec3 <- rep(vec2,3)
vec3
#4. 2번, 3번 모두 포함되는 벡터
vec4 <- c(vec2,vec3)
vec4
#5. 4번에서 홀수 번째 값들만 저장하는 벡터 
func <- function(a){
  for(i in a){
    if(i %% 2 !=0){
      v<-c(i)
    }return(v)
  }
}
vec5 <- c(func(vec4))
vec5
vec5<- seq(vec4,,2)
