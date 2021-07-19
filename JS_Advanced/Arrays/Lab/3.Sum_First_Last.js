
function sumFirstAndLastElement(inputArray) {
  let numbers = inputArray.map(Number);

  let firstNumber = numbers.shift();
  let lastNumber = numbers.pop();

  return firstNumber + lastNumber;
}

console.log(sumFirstAndLastElement(['20', '30', '40']));