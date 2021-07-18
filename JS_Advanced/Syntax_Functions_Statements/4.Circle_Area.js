
function calculateCircleArea(input) {
  if(typeof(input) === 'number' ) {
    return (Math.PI * Number(input) * Number(input)).toFixed(2);
  }
  else {
    return `We can not calculate the circle area, because we receive a ${typeof(input)}.`;
  }
}

console.log(calculateCircleArea('name'));
