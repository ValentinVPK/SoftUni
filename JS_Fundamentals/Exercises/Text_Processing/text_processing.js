
//-----------------------

function printCharacters(inputString) {
  for(let ch of inputString) {
    console.log(ch);
  }
}

//------------------------

function findSubstring(inputString, startingIndex, count) {
  return inputString.substring(startingIndex, startingIndex + count);
}

//------------------------

function censoredWords(inputString, inputWord) {
  while(inputString.includes(inputWord)) {
    inputString = inputString.replace(inputWord, '*'.repeat(inputWord.length));
  }

  return inputString;
}

//------------------------

function countStringOccurrences(text,str) {
  let words = text.split(' ');
  let counter = 0;
  for(let word of words) {
    if(word === str) {
      counter++;
    }
  }

  return counter;
}