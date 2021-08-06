
function solve(inputArray) {
  let quantityMap = new Map();
  let bottlesMap = new Map();

  inputArray.forEach(str => {
    let [key, value] = str.split(' => ');
    value = Number(value);

    if(!quantityMap.has(key)) {
      quantityMap.set(key, 0);
    }

    let previousValue = quantityMap.get(key);
    quantityMap.set(key,previousValue + value);
    
    let currValue = quantityMap.get(key);
    let bottles = 0;
    while(currValue >= 1000) {
      currValue -= 1000;
      bottles++;
    }

    if(bottles > 0) {
      quantityMap.set(key, currValue);

      if(!bottlesMap.has(key)) {
        bottlesMap.set(key, 0);
      }

      bottlesMap.set(key, bottlesMap.get(key) + bottles);
    }
  });

  for (const entry of bottlesMap.entries()) {
    console.log(`${entry[0]} => ${entry[1]}`);
  }
}

solve(['Kiwi => 234',
'Pear => 2345',
'Watermelon => 3456',
'Kiwi => 4567',
'Pear => 5678',
'Watermelon => 6789']);