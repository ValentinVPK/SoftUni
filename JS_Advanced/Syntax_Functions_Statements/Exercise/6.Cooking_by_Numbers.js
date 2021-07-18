
function processNumber(number,rule1,rule2,rule3,rule4,rule5) {
  number = Number(number);
  let arr = [rule1,rule2,rule3,rule4,rule5];

  for(let i = 0; i < 5; i++) {
    if(arr[i] === 'chop') {
      number /= 2;
    }
    else if(arr[i] === 'dice') {
      number = Math.sqrt(number);
    }
    else if(arr[i] === 'spice') {
      number++;
    }
    else if(arr[i] === 'bake') {
      number *= 3;
    }
    else if(arr[i] === 'fillet') {
      number = number - (20 / 100) * number;
    }

    console.log(number);
  }
}

processNumber('9', 'dice', 'spice', 'chop', 'bake', 'fillet');