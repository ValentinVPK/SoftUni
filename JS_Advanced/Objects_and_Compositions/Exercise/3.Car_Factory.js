
function solve(requirements) {
  const result = {model: requirements.model};
  
  // Engine:
  if(requirements.power <= 90) {
    result.engine = {power: 90, volume: 1800};
  } else if(requirements.power > 90 && requirements.power <= 120) {
    result.engine = {power: 120, volume: 2400};
  } else {
    result.engine = {power: 200, volume: 3500};
  }

  // Carriage

  result.carriage = {type: requirements.carriage, color: requirements.color};

  // Wheels:

  if(requirements.wheelsize % 2 === 0) {
    let newSize = requirements.wheelsize - 1;
    result.wheels = [newSize, newSize, newSize, newSize];
  } else {
    result.wheels = [requirements.wheelsize,requirements.wheelsize,requirements.wheelsize,requirements.wheelsize];
  }

  return result;
}

console.log(solve({ model: 'Opel Vectra',
power: 110,
color: 'grey',
carriage: 'coupe',
wheelsize: 17 }));