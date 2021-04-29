# 라이브러리 설치
#엑셀 데이터 불러오기 함수 라이브러리
library(readxl)
library(xlsx)
#엑셀 데이터 가져오기
excelData <- read_excel('res/data_ex.xlsx')
View(excelData)

#파일 경로로 가져오기
studentx <- read.xlsx(file.choose(),sheetIndex = 1,encoding = 'UTF-8')
studentx
View(studentx)


#연습문제
#1. "2021-04-29 수입3000원",
#   "2021-04-30 수입4500원",
#   "2021-05-01 수입5500원"
#1번의 문자열을 이용하여 아래와 같이 출력
#출력형태>> "3000원" "4500원" "5500원"

library(stringr)
date1 <-"2021-04-29 수입3000원"
date2 <-"2021-04-30 수입4500원"
date3 <-"2021-05-01 수입5500원"
p1 <- str_extract_all(date1,"3000원")
p1
p2<-str_sub(date2,14,18)
p2
p3<- str_sub(date3,14,18)
p3
#2. 1번에서 '-'를 '/'로 변경
# --> str_replace_all()
date1<- str_replace_all(date1,"-","/")
date1
date2 <- str_replace_all(date2,"-","/")
date2
date3<- str_replace_all(date3,"-","/")
date3

#3. 임의의 국어, 영어, 수학 점수를 가지는 벡터 3개 생성
kor <- c(90,85,98)
eng <- c(100,89,79)
mat <- c(98,85,99)

#4. 3번 벡터를 가지는 dataframe 생성
score <- data.frame(kor,eng,mat)
score

#5. 국, 영, 수 dataframe에서 최대값 구하기
max_score <- apply(score,2,max)
max_score
