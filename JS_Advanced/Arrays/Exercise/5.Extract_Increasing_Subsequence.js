

function processArray(inputArray) {
  
  let resultArr = inputArray.reduce((acc, number) => {
    if(acc.length === 0 || number >= acc[acc.length - 1]) {
      acc.push(number);
    }
    return acc;
  }, []);

  return resultArr;
}

console.log(processArray([1, 3, 8, 10, 12, 24]));