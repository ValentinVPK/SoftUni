

function isMatrixMagic(inputMatrix) {
  let sum = inputMatrix[0].reduce((acc, number) => acc + number);

  // checking rows:

  for(let row of inputMatrix) {
    let currSum = row.reduce((acc, number) => acc + number);
    if(sum !== currSum) {
      return false;
    }
  }

  // checking cols:
  for(let col = 0; col < inputMatrix[0].length; col++) {
    let currSum = 0;
    for(let row = 0; row < inputMatrix.length; row++) {
      currSum += inputMatrix[row][col];
    }

    if(currSum !== sum) {
      return false;
    }
  }

  return true;
}

console.log(isMatrixMagic([[1, 0, 0],
  [0, 0, 1],
  [0, 1, 0]]));

