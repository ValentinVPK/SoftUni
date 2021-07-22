
function solve(inputArray) {
  const result = [];

  for(let str of inputArray) {
    const currObj = {};
    const tokens = str.split(' / ');
    currObj.name = tokens[0];
    currObj.level = Number(tokens[1]);
    currObj.items = tokens[2] ? tokens[2].split(', ') : [];
    result.push(currObj);
  }

  return JSON.stringify(result);
}

console.log(solve(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']));

