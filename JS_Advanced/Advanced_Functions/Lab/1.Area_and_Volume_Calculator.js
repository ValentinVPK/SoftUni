
function area() {
  return Math.abs(this.x * this.y);
};

function vol() {
  return Math.abs(this.x * this.y * this.z);
};


function solve(area, vol, inputStr) {
  let inputArray = JSON.parse(inputStr);

  const resultArr = [];

  inputArray.forEach(inputObj => {
    resultArr.push({'area': area.call(inputObj), 'volume': vol.call(inputObj)});
  });

  return resultArr;
}

console.log(solve(area, vol, '[{"x":"1","y":"2","z":"10"},{"x":"7","y":"7","z":"10"},{"x":"5","y":"2","z":"10"}]'));