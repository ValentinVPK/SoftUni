
function processArray(inputArray) {
  inputArray.sort((a,b) => a - b);
  
  let resultArr = [];

  while(inputArray.length > 0) {
    if(inputArray.length === 1) {
      resultArr.push(inputArray.shift());
    } else {
      resultArr.push(inputArray.shift());
      resultArr.push(inputArray.pop());
    }
  }

  return resultArr;
}

console.log(processArray([1, 65, 3, 52, 48, 63, 31, -3, 18]));

