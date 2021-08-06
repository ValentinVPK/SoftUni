
function solve(inputArray) {
  let carDealship = {};

  inputArray.forEach(str => {
    let [brand, model, price] = str.split(' | ');
    price = Number(price);

    if(!carDealship.hasOwnProperty(brand)) {
      carDealship[brand] = {};
    }

    if(carDealship[brand].hasOwnProperty(model)) {
      carDealship[brand][model] += price;
    } else {
      carDealship[brand][model] = price;
    }
  });

  for (const key of Object.keys(carDealship)) {
    console.log(key);
    for (const modelKey of Object.keys(carDealship[key])) {
      console.log(`###${modelKey} -> ${carDealship[key][modelKey]}`);
    }
  }
}

solve(['Audi | Q7 | 1000',
'Audi | Q6 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10']);