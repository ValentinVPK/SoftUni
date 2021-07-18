
function evaluateSpeed(speed, place) {
  let kmAllowed = 0;
  switch(place) {
    case 'residential':
      kmAllowed = 20;
      break;
    case 'city':
      kmAllowed = 50;
      break;
    case 'interstate':
      kmAllowed = 90;
      break;
    case 'motorway':
      kmAllowed = 130;
      break;
  }

  if(speed <= kmAllowed) {
    console.log(`Driving ${speed} km/h in a ${kmAllowed} zone`);
  }
  else if(speed - kmAllowed <= 20) {
    console.log(`The speed is ${speed - kmAllowed} km/h faster than the allowed speed of ${kmAllowed} - speeding`);
  }
  else if(speed - kmAllowed > 20 && speed - kmAllowed <= 40) {
    console.log(`The speed is ${speed - kmAllowed} km/h faster than the allowed speed of ${kmAllowed} - excessive speeding`);
  }
  else {
    console.log(`The speed is ${speed - kmAllowed} km/h faster than the allowed speed of ${kmAllowed} - reckless driving`);
  }
}