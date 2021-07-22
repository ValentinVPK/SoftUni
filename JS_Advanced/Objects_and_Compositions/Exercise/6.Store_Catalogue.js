
function solve(inputArray) {
  const result = {};
  for(let str of inputArray) {
    let [product, price] = str.split(' : ');
    result[product] = price;
  }

  const sortedKeys = Object.keys(result).sort((a,b) => a.localeCompare(b));
  let firstLetter = sortedKeys[0].charAt(0);
  console.log(firstLetter);
  for(let key of sortedKeys) {
    if(key.charAt(0) !== firstLetter) {
      firstLetter = key.charAt(0);
      console.log(firstLetter);
    }

    console.log(`  ${key}: ${result[key]}`);
  }
}

solve(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']);