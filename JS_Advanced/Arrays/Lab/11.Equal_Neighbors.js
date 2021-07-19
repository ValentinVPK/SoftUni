
function findNeighbors(inputMatrix) {
  let count = 0;

  for(let row = 0; row < inputMatrix.length; row++) {
    for(let col = 0;  col < inputMatrix[row].length; col++) {
      let curr = inputMatrix[row][col];
      let left = inputMatrix[row][col - 1];
      let right = inputMatrix[row][col + 1];
      let up = undefined;
      let down = undefined;
      if(row !== 0) {
        up = inputMatrix[row - 1][col];
      }

      if(row !== inputMatrix.length - 1) {
        down = inputMatrix[row + 1][col];
      }

      if(curr === left) {
        count++;
      }
      
      if(curr === right) {
        count++;
      }

      if(curr === up) {
        count++;
      }

      if(curr === down) {
        count++;
      }
    }
  }

  return count / 2;
}

console.log(findNeighbors([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']]));

/*
2 2 5 7 4
4 0 5 3 4
2 5 5 4 2
*/