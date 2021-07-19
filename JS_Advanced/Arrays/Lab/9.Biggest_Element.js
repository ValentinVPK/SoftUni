
function findMaxElementInMatrix(inputMatrix) {
  let max = inputMatrix[0][0];

  for(let row = 0; row < inputMatrix.length; row++) {
    for(let col = 0; col < inputMatrix[row].length; col++) {
      if(inputMatrix[row][col] >= max) {
        max = inputMatrix[row][col];
      }
    }
  }

  return max;
}

console.log(findMaxElementInMatrix([[20, 50, 10],[8, 33, 145]]));