

function solve(inputArray) {
  const result = {};
  for(let str of inputArray) {
    let [town, product, price] = str.split(' | ');
    price = Number(price);

     if(!result.hasOwnProperty(product)) {
        result[product] = {};
     } 

     result[product][town] = price;
  }

  for(let key in result) {
    // key -> product, value -> objects {townName: price, ...};
    let [town,price] = Object.entries(result[key]).sort((a,b) => a[1] - b[1])[0];
    console.log(`${key} -> ${price} (${town})`);
  }
}

solve(['Sofia City | Audi | 100000',
  'Sofia City | BMW | 100000',
  'Sofia City | Mitsubishi | 10000',
  'Sofia City | Mercedes | 10000',
  'Sofia City | NoOffenseToCarLovers | 0',
  'Mexico City | Audi | 1000',
  'Mexico City | BMW | 99999',
  'New York City | Mitsubishi | 10000',
  'New York City | Mitsubishi | 1000',
  'Mexico City | Audi | 100000',
  'Washington City | Mercedes | 1000']);