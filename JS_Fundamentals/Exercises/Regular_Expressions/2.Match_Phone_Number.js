
function solve(input) {

  let validNumbers = [];

  let pattern = /\+359([- ])2\1[0-9]{3}\1[0-9]{4}/g;

  for (const match of input.match(pattern)) {
    if(!validNumbers.includes(match)) {
      validNumbers.push(match);
    }
  }

  console.log(validNumbers.join(', '));
}

solve("+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222");