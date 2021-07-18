
function findGCD(num1, num2) {
  let smallerNumber = Math.min(num1, num2);
  let biggerNumber = Math.max(num1, num2);
  let GCD = 1;

  for(let i = 1; i <= smallerNumber; i++) {
    if(smallerNumber % i === 0 && biggerNumber % i === 0) {
      GCD = i;
    }
  }

  return GCD;
}

console.log(findGCD(2154, 458));