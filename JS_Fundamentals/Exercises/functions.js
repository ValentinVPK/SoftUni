function repeatedString(str, count) {
  let result = '';
  for(let i = 0; i < count; i++) {
    result += str;
  }

  return result;
}

function formatGrade(number) {
  number = Number(number);
  if(number < 3) {
    console.log('Fail (2)');
  }
  else if(number >= 3 && number < 3.50) {
    console.log(`Poor (${number.toFixed(2)})`);
  }
  else if(number >= 3.5 && number < 4.5) {
    console.log(`Good (${number.toFixed(2)})`);
  }
  else if(number >= 4.5 && number < 5.5) {
    console.log(`Very good (${number.toFixed(2)})`);
  }
  else {
    console.log(`Excellent (${number.toFixed(2)})`);
  }
}

function power(number, power) {
  let result = 1;
  for(let i = 0; i < power; i++) {
    result *= number;
  }

  console.log(result);
}

function orderDrink(drinkName, quantity) {
  switch(drinkName) {
    case 'coffee':
      return (quantity * 1.50).toFixed(2);
    case 'water':
      return (quantity * 1).toFixed(2);
    case 'coke':
      return (quantity * 1.4).toFixed(2);
    case 'snacks':
      return (quantity * 2).toFixed(2);
    default:
      return 0;
  }
}

function simpleCalculator(firstNum, secondNum, command) {
  if(command === "multiply") {
    return firstNum * secondNum;
  }
  else if(command === "divide") {
    return firstNum / secondNum;
  }
  else if(command === "add") {
    return firstNum + secondNum;
  }
  else if(command === "subtract") {
    return firstNum - secondNum;
  }

  return 0;
}

function positiveOrNegative(numberOne, numberTwo, numberThree) {
  if((numberOne < 0 && numberTwo < 0 && numberThree < 0) || (numberOne < 0 && numberTwo > 0 && numberThree > 0)
  || (numberOne > 0 && numberTwo < 0 && numberThree > 0) || (numberOne > 0 && numberTwo > 0 && numberThree < 0)){
    return "Negative";
  }
  else {
    return "Positive";
  }
}

