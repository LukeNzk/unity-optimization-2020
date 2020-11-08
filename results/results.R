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
