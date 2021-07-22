
function solve(inputArray) {
  const result = {};
  for(let i = 0; i < inputArray.length; i+=2) {
    result[inputArray[i]] = Number(inputArray[i + 1]);
  }

  return result;
}

console.log(solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']));