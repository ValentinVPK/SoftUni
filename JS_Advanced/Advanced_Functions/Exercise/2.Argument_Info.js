
function solve(...params) {
  const objCounter = {};

  params.forEach(param => {
    console.log(`${typeof(param)}: ${param}`);

    if(objCounter.hasOwnProperty(typeof(param))) {
      objCounter[typeof(param)]++;
    } else {
      objCounter[typeof(param)] = 1;
    }
  });

  for(let entry of Object.entries(objCounter).sort((a,b) => b[1] - a[1])) {
    console.log(`${entry[0]} = ${entry[1]}`);
  }
}

solve('cat', 42, function () { console.log('Hello world!'); });