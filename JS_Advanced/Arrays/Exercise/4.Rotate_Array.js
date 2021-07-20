
function rotateArray(inputArray, number) {
  for(let i = 0; i < number; i++) {
    inputArray.unshift(inputArray.pop());
  }

  console.log(inputArray.join(' '));
}

rotateArray(['Banana', 'Orange', 'Coconut', 'Apple'], 15);