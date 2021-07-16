//-----------------------
function personInfo(firstName, lastName, age) {
  return {firstName,lastName, age};
}

//----------------------
function printObjectInfo(inputObject) {
  let properties = Object.keys(inputObject);
  for(let key of properties) {
    console.log(`${key} -> ${inputObject[key]}`);
  }
}

//---------------------
function fromJSONtoObject(inputStr) {
  let object = JSON.parse(inputStr)

  let props = Object.entries(object);
  for(let [key, value] of props) {
    console.log(`${key}: ${value}`);
  }
}

//---------------------
function fromObjectToJSON(name, lastName, hairColor) {
  let object = {name, lastName, hairColor};

  let stringJSON = JSON.stringify(object);
  console.log(stringJSON);
}

//------------------------

function printCats(inputArray) {
  class Cat {
    constructor(catName, age){
      this.catName = catName;
      this.age = age;
    }
  
    meow() {
      console.log(`${this.catName}, age ${this.age} says Meow`);
    }
  }


  for(let str of inputArray) {
    let [catName, age] = str.split(' ');
    let currCat = new Cat(catName, age);
    currCat.meow();
  }
}

//---------------------

function filterSongs(inputArray) {
  class Song {
    constructor(typeList, name,time){
      this.typeList = typeList;
      this.name = name;
      this.time = time;
    }
  }

  let n = Number(inputArray.shift());
  let filter = inputArray.pop();
  let songs = [];

  for(let song of inputArray) {
    let [typeList, name, time] = song.split('_');
    let currSong = new Song(typeList, name, time);
    songs.push(currSong);
  }

  if(filter === "all") {
    songs.forEach(x => console.log(x.name));
  }
  else {
    songs.filter(x => x.typeList === filter).forEach(x => console.log(x.name));
  }
}

filterSongs([3,'favourite_DownTown_3:14','favourite_Kiss_4:16','favourite_Smooth Criminal_4:01','favourite']);