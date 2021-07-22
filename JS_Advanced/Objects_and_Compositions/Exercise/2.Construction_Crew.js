
function solve(inputObject) {
  if(inputObject['dizziness'] === true) {
    inputObject['levelOfHydrated'] += 0.1 * inputObject['weight'] * inputObject['experience'];
    inputObject['dizziness'] = false;
  }

  return inputObject;
}

console.log(solve({ weight: 80,
  experience: 1,
  levelOfHydrated: 0,
  dizziness: true }
));