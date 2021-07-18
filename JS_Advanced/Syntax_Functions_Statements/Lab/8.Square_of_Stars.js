
function printSquare(number) {
  if(number === undefined) {
    number = 5;
  }
  for(let rows = 0; rows < number; rows++) {
    console.log('* '.repeat(number));
  }
}

printSquare();