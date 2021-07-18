
function processArray(inputArr) {
  let sum1 = 0;
  inputArr.forEach(x => sum1 += x);
  console.log(sum1);

  let sum2 = 0;
  inputArr.forEach(x => sum2 += (1/x));
  console.log(sum2);

  let concat = inputArr.join('');
  console.log(concat);
}

processArray([1, 2, 3]);