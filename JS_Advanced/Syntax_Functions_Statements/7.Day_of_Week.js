

function printNumberOfDay(str) {
  if(str === 'Monday') {
    return 1;
  }

  if(str === 'Tuesday') {
    return 2;
  }

  if(str === 'Wednesday') {
    return 3;
  }

  if(str === 'Thursday') {
    return 4;
  }

  if(str === 'Friday') {
    return 5;
  }

  if(str === 'Saturday') {
    return 6;
  }

  if(str === 'Sunday') {
    return 7;
  }

  return 'error';
}

console.log(printNumberOfDay('Monday'));