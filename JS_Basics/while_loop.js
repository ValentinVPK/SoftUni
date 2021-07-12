
function printToStop(input) {
  let index = 0;
  while(true) {
    if(input[index] == "Stop") {
      break;
    }

    console.log(input[index]);
    index++;
  }
}

function inputPassword(input) {
  let name = input[0];
  let userPassword = input[1];

  let index = 2;
  while(true) {
    if(input[index++] == userPassword) {
      console.log(`Welcome ${name}!`);
      break;
    }
  }
}

function sumUntilBigger(input) {
  let target = Number(input[0]);
  let sum = 0;
  let index = 1;
  while(true) {
    if(sum >= target) {
      console.log(sum);
      break;
    }

    sum += Number(input[index++]);
  }
}

function numbersRow(input) {
  let n = Number(input[0]);
  let counter = 1;

  while(counter <= n) {
    console.log(counter);

    counter = counter * 2 + 1;
  }
}


function addMoney(input) {
  let index = 0;
  let account = 0;

  while(true) {
    if(input[index] == "NoMoreMoney") {
        console.log(`Total: ${account.toFixed(2)}`);
        break;
    }

    if(Number(input[index]) < 0) {
      console.log("Invalid operation!");
      console.log(`Total: ${account.toFixed(2)}`);
      break;
    }

    account += Number(input[index]);
    console.log(`Increase: ${Number(input[index]).toFixed(2)}`);
    index++;
  }
}

function findBiggestNumber(input) {
  let max = Number(input[0]);
  let index = 1;

  while(true) {
    if(input[index] == "Stop") {
      console.log(max);
      break;
    }

    if(Number(input[index]) >= max) {
      max = Number(input[index]);
    }
    index++;
  }
}

function findSmallestNumber(input) {
  let min = Number(input[0]);
  let index = 1;

  while(true) {
    if(input[index] == "Stop") {
      console.log(min);
      break;
    }

    if(Number(input[index]) < min) {
      min = Number(input[index]);
    }
    index++;
  }
}


