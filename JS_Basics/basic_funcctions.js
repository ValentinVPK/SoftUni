
// LAB -- START:
function hello() {
  console.log("Hello, this is Valio!");
}

function numsFrom1To10() {
  console.log(1);
  console.log(2);

  console.log(3);
  console.log(4);

  console.log(5);
  console.log(6);

  console.log(7);
  console.log(8);

  console.log(9);
  console.log(10);
}

function rectangleArea(input){
  let side = Number(input[0]);
  let area = side * side;
  console.log(area);
}

function inchesToCms(input){
  let inches = Number(input[0]);
  let cms = inches * 2.54;

  console.log(cms);
}

function greetingByName(input){
  let name = input[0];
  console.log(`Hello, ${name}!`);
}

function concatenateData(input){
  let firstName = input[0];
  let lastName = input[1];
  let age = Number(input[2]);
  let town = input[3];

  console.log(`You are ${firstName} ${lastName}, a ${age}-years old person from ${town}.`);
}

function calculateTime(input){
  let architectName = input[0];
  let projects = Number(input[1]);

  let hours = projects * 3;

  console.log(`The architect ${architectName} will need ${hours} hours to complete ${projects} project/s.`);
}

function calculateMoneyForFood(input){
  let dogs = Number(input[0]);
  let others = Number(input[1]);

  let money = dogs * 2.5 + others * 4;

  console.log(`${money} lv.`);
}

function calculateMoneyAndDiscount(input){
  let squareMeters = Number(input[0]);

  let price = squareMeters * 7.61;
  let discount = (18 / 100) * price;
  price -= discount;

  console.log(`The final price is: ${price} lv.`);
  console.log(`The discount is: ${discount} lv.`);
}


// LAB -- END --------------------------------------

// EXERCISE -- START : 

function convertFromUSDToLV(input) {
  let usd = Number(input[0]);

  let lv = usd * 1.79549;

  console.log(lv);
}

function convertFromRadiansToDegrees(input){
  let radians = Number(input[0]);

  let degrees = radians * 180 / Math.PI;

  console.log(degrees.toFixed(0)); // Rounds to whole number;
}

function calculateDeposit(input) {
  let sum = Number(input[0]);
  let months = Number(input[1]);
  let percent = Number(input[2]);

  let result = sum + months * ((sum * (percent / 100)) / 12);

  console.log(result);
}

function calculateHoursForReading(input) {
  let allPages = Number(input[0]);
  let pagesPerHour = Number(input[1]);
  let days = Number(input[2]);

  let result = (allPages / pagesPerHour) / days;

  console.log(result);
}

function calculatePriceForParty(input) {
  let rent = Number(input[0]);
  let cakePrice = (20 / 100) * rent;
  let drinksPrice = cakePrice - (45 / 100) * cakePrice;
  let animatorPrice = (1 / 3) * rent;

  let totalPrice = rent + cakePrice + drinksPrice + animatorPrice;

  console.log(totalPrice);
}

function calculateIncomeFromCharity(input) {
  let days = Number(input[0]);
  let contenders = Number(input[1]);
  let cakesPerDay = Number(input[2]);
  let wafflePerDay = Number(input[3]);
  let pancakesPerDay = Number(input[4]);

  let incomeForOneDay = (cakesPerDay * 45 + wafflePerDay * 5.8 + pancakesPerDay * 3.20) * contenders;
  let finalIncome = days * incomeForOneDay;
  finalIncome = finalIncome - (1/8) * finalIncome;

  console.log(finalIncome);
}

function calculatePriceForFruits(input) {
  let strawberriesPrice = Number(input[0]);
  let bananasQuantitty = Number(input[1]);
  let orangesQuantity = Number(input[2]);
  let raspberriesQuantity = Number(input[3]);
  let strawberriesQuantity = Number(input[4]);

  let raspberriesPrice = (1 / 2) * strawberriesPrice;
  let orangesPrice = raspberriesPrice - (40 / 100) * raspberriesPrice;
  let bananasPrice = raspberriesPrice - (80 / 100) * raspberriesPrice;

  let finalPrice = strawberriesQuantity * strawberriesPrice + raspberriesQuantity * raspberriesPrice + orangesQuantity * orangesPrice + bananasPrice * bananasQuantitty;
  
  console.log(finalPrice);
}





