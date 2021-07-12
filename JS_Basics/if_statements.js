
// LAB --- START
function readMark(input) {
  let mark = Number(input[0]);

  if(mark >= 5.50){
    console.log("Excellent!");
  }
}


function greaterNumber(input) {
  let number1 = Number(input[0]);
  let number2 = Number(input[1]);

  if(number1 >= number2) {
    console.log(number1);
  }
  else {
    console.log(number2);
  }
}

function evenOrOdd(input) {
  let number = Number(input[0]);

  if(number % 2 == 0){
    console.log("even");
  }
  else {
    console.log("odd");
  }
}


function checkNumber(input) {
  let number = Number(input[0]);

  if(number < 100) {
    console.log("Less than 100");
  }
  else if (number >= 100 && number <= 200) {
    console.log("Between 100 and 200");
  }
  else {
    console.log("Greater than 200");
  }
}

function checkPassword(input) {
  let inputPassword = input[0];

  if(inputPassword == "s3cr3t!P@ssw0rd") {
    console.log("Welcome");
  }
  else {
    console.log("Wrong password!");
  }
}


function checkShape(input) {
  let shapeName = input[0];

  if(shapeName == "square") {
    let a = Number(input[1]);
    console.log((a * a).toFixed(3));
  }
  else if(shapeName == "rectangle") {
    let a = Number(input[1]);
    let b = Number(input[2]);

    console.log((a * b).toFixed(3));
  }
  else if(shapeName == "triangle") {
    let a = Number(input[1]);
    let h = Number(input[2]);

    console.log(((a * h) / 2).toFixed(3));
  }
  else if(shapeName == "circle") {
    let radius = Number(input[1]);

    console.log((Math.PI * radius * radius).toFixed(3));
  }
}

function toyShop(input) {
  let tripPrice = Number(input[0]);
  let puzzles = Number(input[1]);
  let dolls = Number(input[2]);
  let bears = Number(input[3]);
  let minions = Number(input[4]);
  let trucks = Number(input[5]);

  let income = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

  if((puzzles + dolls + bears + minions + trucks) >= 50) {
    income = income - (25 / 100) * income;
  }

  income = income - (10 / 100) * income;

  if(income >= tripPrice) {
    console.log(`Yes! ${(income - tripPrice).toFixed(2)} lv left.`);
  }
  else {
    console.log(`Not enough money! ${(tripPrice - income).toFixed(2)} lv needed.`);
  }
}


// EXERCISE --- START

function secondsSum(input) {
  let minutes = Math.floor((Number(input[0]) + Number(input[1]) + Number(input[2])) / 60);
  let seconds = (Number(input[0]) + Number(input[1]) + Number(input[2])) % 60;

  if(seconds < 10) {
    console.log(minutes + ":0" + seconds);
  }
  else {
    console.log(minutes + ":" + seconds);
  }
}

function bonusPoints(input) {
  let points = Number(input[0]);
  let bonus = 0;

  if(points <= 100) {
    bonus = 5;

  }
  else if(points > 100 && points <= 1000) {
    bonus = (20 / 100) * points;
  }
  else {
    bonus = (10 / 100) * points;

  }

  if(points % 2 == 0) {
    bonus += 1;
  }

  if(points % 10 == 5) {
    bonus += 2;
  }
  
  console.log(bonus);
  console.log(bonus + points);
}


function speedInfo(input) {
  let speed = Number(input[0]);

  if(speed <= 10) {
    console.log("slow");
  }
  else if(speed > 10 && speed <= 50) {
    console.log("average");
  }
  else if(speed > 50 && speed <= 150) {
    console.log("fast");
  }
  else if(speed > 150 && speed <= 1000){
    console.log("ultra fast");
  }
  else {
    console.log("extremely fast");
  }
}

function metricConverter(input) {
  let amount = Number(input[0]);
  let first = input[1];
  let second = input[2];

  if(first == "mm") {
    if(second == "cm") {
      console.log((amount / 10.0).toFixed(3));
    }
    else if(second == "m") {
      console.log((amount / 1000.0).toFixed(3));
    }
  }
  else if(first == "cm") {
    if(second == "mm") {
      console.log((amount * 10.0).toFixed(3));
    }
    else if(second == "m") {
      console.log((amount / 100.0).toFixed(3));
    }
  }
  else if(first == "m") {
    if(second == "mm") {
      console.log((amount * 1000.0).toFixed(3));
    }
    else if(second == "cm") {
      console.log((amount * 100.0).toFixed(3));
    }
  }
}


function after15minutes(input) {
  let allMinutes = Number(input[0]) * 60 + Number(input[1]) + 15;

  let hours = Math.floor(allMinutes / 60);
  let minutes = allMinutes % 60;

  if(hours == 24) {
    hours = 0;
  }

  if(minutes < 10) {
    console.log(hours + ":0" + minutes);
  }
  else {
    console.log(hours + ":" + minutes);
  }
}


function solve(input) {
  number = Number(input[0]);
  switch (number) {
     case 1:
        console.log("Monday"); 
        break;
     case 2:
        console.log("Tuesday"); 
        break;
     case 3:
        console.log("Wednesday");
        break;
     case 4:
        console.log("Thursday");
        break;
     case 5:
        console.log("Friday");
        break;
     case 6:
        console.log("Saturday");
        break;
     case 7:
        console.log("Sunday"); 
        break;
     default:
        console.log("Error!"); 
        break;
    }
}


