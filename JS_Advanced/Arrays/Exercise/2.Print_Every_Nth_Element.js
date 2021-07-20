
function printElements(inputArray, number) {
  let resultArr = [];
  for(let i = 0; i < inputArray.length; i+= number) {
    resultArr.push(inputArray[i]);
  }

  return resultArr;
}

console.log(printElements(['5', '20', '31', '4', '20'], 2));