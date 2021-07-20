

function sortStringArray(inputArray) {
  let index = 1;
  inputArray.sort((a, b) => a.localeCompare(b)).forEach(x => console.log(`${index++}.${x}`));
}

sortStringArray(["John", "Bob", "Christina", "Ema"]);