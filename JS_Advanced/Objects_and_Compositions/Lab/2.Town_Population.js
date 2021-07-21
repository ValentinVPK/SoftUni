
function solve(inputArray) {
  let dictionary = {};
  for(let element of inputArray) {
    let [town, population] = element.split(' <-> ');
    if(dictionary.hasOwnProperty(town)) {
      dictionary[town] += Number(population);
    } else {
      dictionary[town] = Number(population);
    }
  }

  for(let key in dictionary) {
    console.log(`${key} : ${dictionary[key]}`);
  }
}

solve(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']);