
function createArrayOfTickets(inputArray, sortProperty) {

  class Ticket {
    constructor(destination, price, status) {
      this.destination  = destination;
      this.price = price;
      this.status = status;
    }
  } 

  let resultArray = [];

  for (const str of inputArray) {
    let tokens = str.split('|');
    let destination = tokens[0];
    let price = Number(tokens[1]);
    let status = tokens[2];

    let currObj = new Ticket(destination, price, status);

    resultArray.push(currObj);
  } 

  return sortProperty === 'price'
    ? resultArray.sort((a,b) => a[sortProperty] - b[sortProperty])
    : resultArray.sort((a,b) => a[sortProperty].localeCompare(b[sortProperty]));

}

console.log(createArrayOfTickets(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'price'));