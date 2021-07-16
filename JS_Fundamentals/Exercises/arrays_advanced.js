
function sumFirstAndLast(inputArr) {
  let first = Number(inputArr.shift());
  let last = Number(inputArr.pop());

  return first + last;
}

function rearrangeArr(inputArr) {
  let resultArr = [];

  for(let number of inputArr) {
    if(number < 0) {
      resultArr.unshift(number);
    }
    else {
      resultArr.push(number);
    }
  }

  console.log(resultArr.join('\n'));
}

function firstAndLastK(inputArr) {
  let k = inputArr[0];

  console.log(inputArr.slice(1, 1 + k).join(' '));
  console.log(inputArr.slice(inputArr.length - k).join(' '));
}

function fibonacciNumbers(n, k) {
  let resultArr = [1];

  for(let i = 1; i < n; i++) {
    let currSum = 0;
    if(i - k < 0) {
      for(let num of resultArr) {
        currSum += num;
      }
    }
    else {
      for(let num of resultArr.slice(i - k)){
        currSum += num;
      }
    }

    resultArr.push(currSum);
  }

  return resultArr.join(' ');
}

function processOddNumbers(inputArray) {
  return inputArray.filter((number, i) => i % 2 !== 0).map((number) => number * 2).reverse().join(' ');
}

function smallestTwoNumbers(inputArray) {
  inputArray.sort((a, b) => a - b);
  console.log(inputArray.slice(0, 2).join(' '));
}

function listOfProducts(inputArr) {
  inputArr.sort((a,b) => a.localeCompare(b));
  for(let i = 0; i < inputArr.length; i++) {
    console.log(`${i + 1}.${inputArr[i]}`);
  }
}

function arrayManipulations(inputArray) {
  let resultArr = inputArray[0].split(' ').map(Number);

  for(let i = 1; i < inputArray.length; i++) {
    // let [ command, firstArg, secondArg] = inputArray[i].split(' ');
    let currCommand = inputArray[i].split(' ');
    if(currCommand[0] === "Add") {
      resultArr.push(Number(currCommand[1]));
    }
    else if(currCommand[0] === "Remove") {
      if(resultArr.includes(Number(currCommand[1]))) {
        resultArr.splice(resultArr.indexOf(Number(currCommand[1])), 1);
      }
    }
    else if(currCommand[0] === "RemoveAt") {
      resultArr.splice(Number(currCommand[1]), 1);
    }
    else if(currCommand[0] === "Insert") {
      resultArr.splice(Number(currCommand[2]), 0, Number(currCommand[1]));
    }
  }

  return resultArr.join(' ');
}

console.log(arrayManipulations(['4 19 2 53 6 43','Add 3','Remove 2','RemoveAt 1','Insert 8 3']));

