
function solve(commands) {
  function isOver(inputMatrix) {
    // checking rows:

    for(let row of inputMatrix) {
      if((row[0] === 'X' && row[1] === 'X' && row[2] === 'X') || (row[0] === 'O' && row[1] === 'O' && row[2] === 'O')) {
        return true;
      }
    }

    // checking cols :

    for(let col = 0; col < inputMatrix[0].length; col++) {
      if((inputMatrix[0][col] === 'X' && inputMatrix[1][col] === 'X' && inputMatrix[2][col] === 'X') || 
      (inputMatrix[0][col] === 'O' && inputMatrix[1][col] === 'O' && inputMatrix[2][col] === 'O')) {
        return true;
      }
    }

    // checking diagonals 
    if((inputMatrix[0][0] === 'X' && inputMatrix[1][1] === 'X' && inputMatrix[2][2] === 'X') || 
    (inputMatrix[0][0] === 'O' && inputMatrix[1][1] === 'O' && inputMatrix[2][2] === 'O')) {
      return true;
    }

    if((inputMatrix[0][2] === 'X' && inputMatrix[1][1] === 'X' && inputMatrix[2][0] === 'X') || 
    (inputMatrix[0][2] === 'O' && inputMatrix[1][1] === 'O' && inputMatrix[2][0] === 'O')) {
      return true;
    }    

    return false;
  }

  let field = [[false, false, false],
               [false, false, false],
               [false, false, false]];

  let turnO = false;
  let turnX = true;
  for(let i = 0; i < commands.length; i++) {
    let [row, col] = commands[i].split(' ');
    row = Number(row);
    col = Number(col);

    if(!field[0].includes(false) && !field[1].includes(false) && !field[2].includes(false)) {
      break;
    }

    if(field[row][col] !== false) {
      console.log('This place is already taken. Please choose another!');
      continue;
    } else {
      if(turnO) {
        field[row][col] = 'O';
        turnO = false;
        turnX = true;
      } else {
        field[row][col] = 'X';
        turnO = true;
        turnX = false;
      }  
    }

    if(isOver(field)) {
      if(turnO) {
        console.log('Player X wins!');
      } else {
        console.log('Player O wins!');
      }
      field.forEach(arr => console.log(arr.join('\t')));
      return;
    }
  }

  console.log('The game ended! Nobody wins :(');
  field.forEach(arr => console.log(arr.join('\t')));
  return;
}

solve(["0 1",
"0 0",
"0 2",
"2 0",
"1 0",
"1 2",
"1 1",
"2 1",
"2 2",
"0 0"]);