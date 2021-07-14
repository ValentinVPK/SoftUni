function sumFirstAndLast(numbers) {
  console.log(numbers[0] + numbers[numbers.length - 1]);
}

function printDayOfWeek(number) {
  let days = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];
  if(number < 1 || number > 7) {
    console.log('Invalid day!');
  }
  else {
    console.log(days[number - 1]);
  }
}

function reverseAnArrayOfNumbers(number, inputArr) {
  number = Number(number);
  let arr = [];

  for(let i = 0; i < number; i++) {
    arr[i] = Number(inputArr[i]);
  }

  console.log(arr.reverse().join(' '));
}

function reverseAnArrayOfStrings(inputArray) {
  console.log(inputArray.reverse().join(' '));
}

function sumEvenNumbers(inputArr) {
  let sum = 0;
  for(let i = 0; i < inputArr.length; i++) {
    if(Number(inputArr[i]) % 2 === 0) {
      sum += Number(inputArr[i]);
    }
  }

  console.log(sum);
}

function diffBetweenEvenAndOdd(inputArr) {
  for(let i = 0; i < inputArr.length; i++) {
    inputArr[i] = Number(inputArr[i]);
  }

  let sumEven = 0;
  let sumOdd = 0;

  for(let number of inputArr) {
    if(number % 2 === 0) {
      sumEven += number;
    }
    else if(number % 2 === 1) {
      sumOdd += number;
    }
  }

  console.log(sumEven - sumOdd);
}

function equalArrays(arr1, arr2) {
  for(let i = 0; i < arr1.length; i++) {
    arr1[i] = Number(arr1[i]);
  }

  for(let i = 0; i < arr2.length; i++) {
    arr2[i] = Number(arr2[i]);
  }

  let sum = 0;
  let areEqual = true;
  for(let i = 0; i < arr1.length; i++) {
    if(arr1[i] !== arr2[i]) {
      areEqual = false;
      console.log(`Arrays are not identical. Found difference at ${i} index`);
      break;
    }
    sum += arr1[i];
  }

  if(areEqual) {
    console.log(`Arrays are identical. Sum: ${sum}`);
  }
}

function condenseArray(inputArr) {
  while(true) {
    if(inputArr.length === 1) {
      console.log(inputArr[0]);
      break;
    }
    let arr = [];
    for(let i = 0; i < inputArr.length - 1; i++) {
      arr[i] = inputArr[i] + inputArr[i + 1];
    }
    
    inputArr = arr;
  }
}

condenseArray([2,10,3]);

