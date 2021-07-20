
function sortArray(inputArray) {

  inputArray.sort((a, b) => {
    if(a.length - b.length === 0) {
      return a.localeCompare(b);
    }
    else {
      return a.length - b.length;
    }
  }).forEach(x => console.log(x));
}

sortArray(['test', 'Deny', 'omen', 'Default']);