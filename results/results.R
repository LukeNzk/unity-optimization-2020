require(gdata)

get_mean <- function(filename) {
  csvData <- read.csv(filename, header = FALSE)
  res <- mean(csvData$V1)
  return(res)
}

stage1 <- get_mean("stage1.csv")
stage2 <- get_mean("stage2.csv")

