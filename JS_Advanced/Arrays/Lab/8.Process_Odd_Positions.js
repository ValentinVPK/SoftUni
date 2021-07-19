
function processOddPositions(inputArray) {
  return inputArray.filter((num, i) => i % 2 !== 0).map(number => number * 2).reverse().join(' ');
}

console.log(processOddPositions([3, 0, 10, 4, 7, 3]));