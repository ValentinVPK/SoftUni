
function processArray(inputArray) {
  let resultArr = [];
  let number = 1;
  for(let command of inputArray) {
    if(command === 'add') {
      resultArr.push(number++);
    }
    else if(command === 'remove'){
      resultArr.pop();
      number++;
    }
  }

  if(resultArr.length === 0) {
    console.log('Empty');
  } else {
    resultArr.forEach(x => console.log(x));
  }
}

processArray(['add', 'add', 'remove', 'add', 'add']);