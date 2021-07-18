
function isNumberWithSameDigits(number) {
  let isWithSameDigits = true;
  number = number.toString();
  let digit = number[0];
  let sum = Number(number[0]);

  for(let i = 1; i < number.length; i++) {
    if(number[i] !== digit) {
      isWithSameDigits = false;
    }

    sum += Number(number[i]);
  }

  console.log(isWithSameDigits);
  console.log(sum);
}

isNumberWithSameDigits(1234);