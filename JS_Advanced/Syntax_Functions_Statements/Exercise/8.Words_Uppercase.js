
function extractWordsAndUppercase(text) {
  let arr = [];
  text += '.';

  for(let i = 0; i < text.length; i++) {
    let currWord = '';
    while(![",", " ", "!", "?", ".", "-", "_", "\"", "\'"].includes(text[i])) {
      currWord += text[i];
      i++;
    }

    arr.push(currWord);
  }

  let upperArr = arr.filter(x => x!== '').map(x => x.toUpperCase());
  console.log(upperArr.join(', '));
}

extractWordsAndUppercase('Functions in JS can be nested, i.e. hold other functions');