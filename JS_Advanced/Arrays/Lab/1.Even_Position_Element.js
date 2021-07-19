
function findEvenElements(inputArray) {
  let resultArr = [];

  for(let i = 0; i < inputArray.length; i++) {
    if(i % 2 === 0) {
      resultArr.push(inputArray[i]);
    }
  }

  console.log(resultArr.join(' '));
}

findEvenElements(['20', '30', '40', '50', '60']);