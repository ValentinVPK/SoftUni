
function solve(inputArray) {

  function findDiagonalSums(inputMatrix) {
    let mainSum = 0;
    let secondarySum = 0;

    let firstIndex = 0;
    let lastIndex = inputMatrix[0].length - 1;

    for(let row of inputMatrix) {
      mainSum += row[firstIndex++];
      secondarySum += row[lastIndex--];
    }

    return [mainSum, secondarySum];
  }

  let matrix = [];
  for(let str of inputArray) {
    matrix.push(str.split(' ').map(Number));
  }

  let [mainDiagSum, secondaryDiagSum] = findDiagonalSums(matrix);
  if(mainDiagSum === secondaryDiagSum) {
    let firstIndex = 0;
    let lastIndex = matrix[0].length - 1;
    
    for(let row of matrix) {
      for(let i = 0; i < row.length; i++) {
        if(i === firstIndex || i === lastIndex) {
          continue;
        }

        row[i] = mainDiagSum;
      }
      firstIndex++;
      lastIndex--;
    }
  }

  for(let row of matrix) {
    console.log(row.join(' '));
  }
}

solve(['5 3 12 3 1',
'11 4 23 2 5',
'101 12 3 21 10',
'1 4 5 2 2',
'5 22 33 11 1']);