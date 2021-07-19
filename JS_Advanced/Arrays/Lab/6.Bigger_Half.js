
function getBiggerHalf(inputArray) {
  inputArray.sort((a,b) => a - b);

  let resultArrLength = Math.ceil((inputArray.length / 2));
  let resultArr = [];

  for(let i = inputArray.length - 1; i >= inputArray.length - resultArrLength; i--) {
    resultArr.unshift(inputArray[i]);
  }

  return resultArr;
}

console.log(getBiggerHalf([3, 19, 14, 7, 2, 19, 6]));