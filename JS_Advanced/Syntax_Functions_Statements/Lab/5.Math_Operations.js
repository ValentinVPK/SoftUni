
function calculatons(num1, num2, operator) {
  if(operator === '+') {
    return num1 + num2;
  }

  if(operator === '-') {
    return num1 - num2;
  }

  if(operator === '*') {
    return num1 * num2;
  }

  if(operator === '/') {
    return num1 / num2;
  }

  if(operator === '%') {
    return num1 % num2;
  }

  if(operator === '**') {
    return num1 ** num2;
  }
}

console.log(calculatons(5, 6, '+'));