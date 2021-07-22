
function solve(inputArray) {
  const resultArray = [];

  for(let i = 1; i < inputArray.length; i++) {
    let [townName, latitude, longitude] = inputArray[i].split(' | ');
    townName = townName.replace('| ', '');
    longitude = longitude.replace(' |', '');
    
    latitude = Number(latitude);
    longitude = Number(longitude);

    const currObj = {Town: townName, Latitude: Number(latitude.toFixed(2)), Longitude: Number(longitude.toFixed(2))};
    resultArray.push(currObj);
  }

  return JSON.stringify(resultArray);
}


console.log(solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']));

