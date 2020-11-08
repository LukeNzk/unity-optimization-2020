require(gdata)

get_mean <- function(filename) {
  csvData <- read.csv(filename, header = FALSE)
  res <- mean(csvData$V1)
  return(res)
}

stage1 <- get_mean("stage1.csv")
stage2 <- get_mean("stage2.csv")
stage3 <- get_mean("stage3.csv")
stage4 <- get_mean("stage4.csv")
stage5 <- get_mean("stage5.csv")
stage6 <- get_mean("stage6.csv")
stage7 <- get_mean("stage7.csv")
stage8.1 <- get_mean("stage8-1.csv")
stage8.2 <- get_mean("stage8-2.csv")

columns <- c("STAGE 1",
             "STAGE 2",
             "STAGE 3",
             "STAGE 4",
             "STAGE 5",
             "STAGE 6",
             "STAGE 7",
             "STAGE 8.2")

values <- c(stage1,
            stage2,
            stage3,
            stage4,
            stage5,
            stage6,
            stage7,
            stage8.2)

measurementDf <- data.frame(columns, values)
measurementDf <- measurementDf[order(values),]

barplot(measurementDf$values,
        names.arg = measurementDf$columns,
        horiz = TRUE, xlab = "Time [ms]", xlim = c(0, 30))
