
function subSumOfArray(inputArray, startIndex, endIndex) {
  if(!Array.isArray(inputArray)) {
    return NaN;
  }

  startIndex = startIndex < 0 
    ? 0 
    : startIndex;

  endIndex = endIndex >= inputArray.length
    ? inputArray.length - 1
    : endIndex;

  let numberArray = inputArray.map(Number);

  let sum = 0;
  for (let index = startIndex; index <= endIndex; index++) {
    sum += numberArray[index];   
  }

  return sum;
}

console.log(subSumOfArray([10, 'twenty', 30, 40], 0, 2));