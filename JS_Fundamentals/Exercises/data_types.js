
// Each function is another task!

function concatenateNames(first, second, del) {
  console.log(`${first}${del}${second}`);
}

function replaceChar(first, char, second) {
    for(let i = 0; i < first.length; i++) {
      if(first[i] === '_') {
          if(second[i] === char) {
            console.log("Matched");
          }
          else {
            console.log("Not Matched");
          }
      }
    } 
}

function integerOrFloat(first, second, third) {
  first = Number(first);
  second = Number(second);
  third = Number(third);

  let sum = first + second + third;
  if(Number.isInteger(sum)) {
    console.log(`${sum} - Integer`);
  }
  else {
    console.log(`${sum} - Float`);
  }
}


function amazingNumbers(number) {
  number = number.toString();
  let sum = 0;
  
  for(let i = 0; i < number.length; i++) {
    sum += Number(number[i]);
  }

  let sumAsText = sum.toString();

  if(sumAsText.includes('9')) {
    number += " Amazing? True";
  }
  else {
    number += " Amazing? False";
  }

  console.log(number);
}

function gramophone(band, album, song) {
  let duration = band.length * album.length * (song.length / 2);

  let rotations = Math.ceil(duration / 2.5);

  console.log(`The plate was rotated ${rotations} times.`);
}

function fuelMoney(distance, passengers, fuelPrice) {
  let neededFuelMoney = (((distance / 100) * 7) + passengers*0.100)*fuelPrice;

  console.log(`Needed money for that trip is ${neededFuelMoney} lv`);
}

function centuriesToMinutes(centuries) {
  centuries = Number(centuries);
  let years = centuries * 100;
  let days = Math.trunc(years * 365.2422);
  let hours = days * 24;
  let minutes = hours * 60;

  console.log(`${centuries} centuries = ${years} years = ${days} days = ${hours} hours = ${minutes} minutes`);
}

function specialNumbers(number) {
  number = Number(number);

  for(let i = 1; i <= number; i++) {
    i = i.toString();
    let sum = 0;
    for(let j = 0; j < i.length; j++) {
      sum += Number(i[j]);
    }

    if(sum === 5 || sum === 7 || sum === 11) {
      console.log(`${i} -> True`);
    }
    else {
      console.log(`${i} -> False`);
    }
  }
}

function tripleLetters(number) {
  number = Number(number);

  for(let i = 0; i < number; i++) {
    for(let j = 0; j < number; j++) {
      for(let h = 0; h < number; h++) {
        let letter1 = String.fromCharCode(97 + i);
        let letter2 = String.fromCharCode(97 + j);
        let letter3 = String.fromCharCode(97 + h);

        console.log(letter1 + letter2 + letter3);
      }
    }
  }
}

tripleLetters(3);