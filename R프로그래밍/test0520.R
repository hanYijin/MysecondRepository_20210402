#단순회귀분석
y= diamonds$price
x= diamonds$price
df<-data.frame(x,y)
df
result_lm <- lm(formula = y ~ x, data = df)
result_lm

names(result_lm)
fitted.values(result_lm)[1:2]
head(df,1)

plot(price~carat,data=diamonds)
result.lm <- lm(price~carat, data = diamonds)
result.lm
abline(result.lm,col='red')

#다중회귀분석
str(diamonds)
re_lm<- lm(price~carat+cut+color,data = diamonds)
re_lm
library("car")
vif(re_lm)
summary(re_lm)
