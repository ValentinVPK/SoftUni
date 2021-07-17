//------------------------------
function phoneBook(inputArray) {
  let book = {};
  for(let element of inputArray) {
    let tokens = element.split(' ');
    let name = tokens[0];
    let phone = tokens[1];
    book[name] = phone;
  }

  for(let key in book) {
    console.log(`${key} -> ${book[key]}`);
  }
}

//------------------------------
function meetings(inputArray) {
  let schedule = {};

  for(let element of inputArray) {
    let tokens = element.split(' ');
    let weekday = tokens[0];
    let personName = tokens[1];

    if(schedule.hasOwnProperty(weekday)){
      console.log(`Conflict on ${weekday}!`);
    }
    else {
      schedule[weekday] = personName;
      console.log(`Scheduled for ${weekday}`);
    }
  }

  for(let key in schedule) {
    console.log(`${key} -> ${schedule[key]}`);
  }
}

//------------------------------

function addressBook(inputArray) {

  let book = {};
  for(let element of inputArray) {
    let tokens = element.split(':');
    let name = tokens[0];
    let address = tokens[1];

    book[name] = address;
  }

  for(let key of Object.keys(book).sort((a,b) => a.localeCompare(b))) {
    console.log(`${key} -> ${book[key]}`);
  }
}

//------------------------------

function storage(inputArray) {
  let storageMap = new Map();
  for(let element of inputArray) {
    let tokens = element.split(' ');
    let item = tokens[0];
    let quantity = Number(tokens[1]);

    if(storageMap.has(item)) {
      let currQuantity = storageMap.get(item);
      storageMap.set(item, currQuantity + quantity);
    }
    else {
      storageMap.set(item, quantity);
    }
  }

  for(let key of storageMap.keys()) {
    console.log(`${key} -> ${storageMap.get(key)}`);
  }
}

//------------------------------

function storeGrades(inputArray) {

  function average(numberArray) {
    let sum = 0;
    for(let number of numberArray) {
      sum += number;
    }

    return sum / numberArray.length;
  }

  let grades = {};

  for(let element of inputArray) {
    let tokens = element.split(' ');
    let studentName = tokens.shift();
    tokens = [...tokens.map(Number)];

    if(grades.hasOwnProperty(studentName)) {
      tokens.forEach(grade => grades[studentName].push(grade));
    }
    else {
      grades[studentName] = [...tokens];
    }
  }

  for(let [key, value] of Object.entries(grades).sort((a,b) => average(a[1]) - average(b[1]))) {
    console.log(`${key}: ${value.join(', ')}`);
  }
}

//------------------------------

function wordOccurrences(inputArray) {
  let words = {};

  for(let word of inputArray) {
    if(words.hasOwnProperty(word)) {
      words[word]++;
    }
    else {
      words[word] = 1;
    }
  }

  for(let [key, value] of Object.entries(words).sort((a,b) => b[1] - a[1])) {
    console.log(`${key} -> ${value} times`);
  }
}

//------------------------------

function neighborhoods(inputArray) {
  let info = {};
  inputArray.shift().split(', ').forEach(x => info[x] = []);

  for(let element of inputArray) {
    let tokens = element.split(' - ');
    let streetName = tokens[0];
    let personName = tokens[1];

    if(info.hasOwnProperty(streetName)) {
      info[streetName].push(personName);
    }
  }

  for(let [key, value] of Object.entries(info).sort((a,b) => b[1].length - a[1].length)){
    console.log(`${key}: ${value.length}`);
    value.forEach(x => console.log(`--${x}`));
  }
}


neighborhoods(['Abbey Street, Herald Street, Bright Mews',
'Bright Mews - Garry',
'Bright Mews - Andrea',
'Invalid Street - Tommy',
'Abbey Street - Billy']);

//------------------------------