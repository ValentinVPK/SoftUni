
function printTwoSmallestNumbers(inputArray) {
  inputArray.sort((a,b) => a - b);

  console.log(`${inputArray[0]} ${inputArray[1]}`);
}

printTwoSmallestNumbers([30, 15, 50, 5]);