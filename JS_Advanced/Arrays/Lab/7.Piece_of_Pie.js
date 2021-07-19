

function processArray(inputArray, firstPie, secondPie) {
  let resultArr = inputArray.slice(inputArray.indexOf(firstPie), inputArray.indexOf(secondPie) + 1);
  return resultArr;
}

console.log(processArray(['Pumpkin Pie','Key Lime Pie','Cherry Pie','Lemon Meringue Pie','Sugar Cream Pie'],'Key Lime Pie','Lemon Meringue Pie'));