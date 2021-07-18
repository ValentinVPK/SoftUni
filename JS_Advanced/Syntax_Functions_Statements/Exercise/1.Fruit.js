
function calculatePrice(fruitType, grams, pricePerKg) {
  let kgs = grams / 1000;
  let totalPrice = kgs * pricePerKg;

  console.log(`I need $${totalPrice.toFixed(2)} to buy ${kgs.toFixed(2)} kilograms ${fruitType}.`);
}

calculatePrice('orange', 2500, 1.80);