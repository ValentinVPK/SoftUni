
function rearangeArray(inputArray) {
  let resultArr = [];
  for(let element of inputArray) {
    if(element < 0) {
      resultArr.unshift(element);
    } else {
      resultArr.push(element);
    }
  }

  resultArr.forEach(x => console.log(x));
}

rearangeArray([7, -2, 8, 9]);