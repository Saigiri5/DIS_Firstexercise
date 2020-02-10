#GIRIJA BANDARU
library(readxl)

X6304_16_Assignment_1_Data <- read_excel("Downloads/6304-16 Assignment 1 Data.xlsx")

View(X6304_16_Assignment_1_Data)  

sample1=X6304_16_Assignment_1_Data[sample(1:nrow(X6304_16_Assignment_1_Data),100),] 

set.seed(72052670)

sample2=subset(X6304_16_Assignment_1_Data,Make=="chevrolet"|Make=="ford")

mean(sample1$MPG)

median(sample1$MPG)

sd(sample1$MPG)

skewness(sample1$MPG)

kurtosis(sample1$MPG)

boxplot(sample1$`Cubic Inch Displacement`,col="blue",main="Cubic Inch Displacement Box Plot")

quantile(sample1$Weight,probs=seq(0,1,.20))

boxplot(sample2$MPG~sample2$Make,col="red", main = "MPG Ratings, Ford and Chevrolet, 1970-1982",names=c("All the chevys","All the Fords"), ylab = "MPG ratings", xlab = "Vehicle types")




curve(dnorm(x,72,14),from=30,to=120,lwd=3,ylim=c(0,.05))
for(i in 8:13){
  curve(dnorm(x,72,i),from=30,to=120,lwd=3,add=TRUE)
  }
for(i in 1:1000){
  my.data[i,1]=i
  my.data[i,2]=i^2
}
colnames(my.data)=c("First","Second")
my.data[750,]
head(my.data)
tail.(my.data)
tail(my.data)
my.row=data.frame()
