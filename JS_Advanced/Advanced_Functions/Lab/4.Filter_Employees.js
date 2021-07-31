
function solve(input, criteria) {
  inputArray = JSON.parse(input);

  let resultArray = [];

  if(criteria === 'all') {
    resultArray = [...inputArray];
  } else {
    let [property,value] = criteria.split('-');
    resultArray = inputArray.filter(obj => {
      return obj[property] === value;
    });
  }

  for (let index = 0; index < resultArray.length; index++) {
    console.log(`${index}. ${resultArray[index]['first_name']} ${resultArray[index]['last_name']} - ${resultArray[index]['email']}`);
  }
}

solve(`[{
  "id": "1",
  "first_name": "Ardine",
  "last_name": "Bassam",
  "email": "abassam0@cnn.com",
  "gender": "Female"
}, {
  "id": "2",
  "first_name": "Kizzee",
  "last_name": "Jost",
  "email": "kjost1@forbes.com",
  "gender": "Female"
},  
{
  "id": "3",
  "first_name": "Evanne",
  "last_name": "Maldin",
  "email": "emaldin2@hostgator.com",
  "gender": "Male"
}]`, 
'gender-Female');