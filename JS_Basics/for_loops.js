
// LAB --- START

function printTo100() {
  for(let i = 1; i <= 100; i++) {
    console.log(i);
  }
}

function numbersBackwards(input) {
  let N = Number(input[0]);

  for(let i = N; i >= 1; i--) {
    console.log(i);
  }
}

function numbersPer3(input) {
  let n = Number(input[0]);

  for(let i = 1; i <= n; i+=3) {
    console.log(i);
  }
}

function even2(input) {
  let n = Number(input[0]);

  for(let i = 0; i <= n; i+=2) {
    console.log(Math.pow(2, i));
  }
}

function printCharacters(input) {

  for(let i = 0; i < input[0].length; i++)
  {
    console.log(input[0][i]);
  }
}

function calculateVowels(input) {
  let word = input[0];
  let result = 0;

  for(let i = 0; i < word.length; i++) {
    switch(word[i]) {
      case 'a':
        result++;
        break;
      case 'e':
        result += 2;
        break;
      case 'i':
        result += 3;
        break;
      case 'o':
        result += 4;
        break;
      case 'u':
        result += 5;
        break;
    }
  }

  console.log(result);
}

function sumDigits(input) {
  let number =input[0];
  let sum = 0;

  for(let i = 0; i < number.length; i++) {
    sum += Number(number[i]);
  }

  console.log(`The sum of the digits is:${sum}`);
}

function divisbleBy9(input) {
  let first = Number(input[0]);
  let second = Number(input[1]);
  let sum = 0;

  for(let i = first; i <= second; i++){
    if(i % 9 == 0) {
      sum+= i;
    }
  }

  console.log(`The sum: ${sum}`);

  for(let i = first; i <= second; i++){
    if(i % 9 == 0) {
      console.log(i);
    }
  }
}


