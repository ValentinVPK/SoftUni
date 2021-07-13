
function clock() {
  for(let i = 0; i <= 23; i++) {
    for(let j = 0; j <= 59; j++) {
      console.log(i + ":" + j);
    }
  }
}

function multiplicationTable() {
  for(let i = 1; i <= 10; i++) {
    for(let j = 1; j<= 10; j++) {
      console.log(i + " * " + j + " = " + (i * j));
    }
  }
}

function sumOf3Numbers(input) {
  let n = Number(input[0]);
  let result = 0;

  for(let i = 0; i <= n; i++) {
    for(let j = 0; j <= n; j++) {
      for(let h = 0; h <= n; h++) {
        if((i + j + h) == n) {
          result++;
        }
      }
    }
  }

  console.log(result);
}


function sumOf2Numbers(input) {
  let first = Number(input[0]);
  let second = Number(input[1]);
  let magicNumber = Number(input[2]);
  let combinations = 1;
  let isFound = false;

  for(let i = first; i <= second; i++) {
    for(let j = first; j <= second; j++) {
      if(i + j == magicNumber) {
        console.log(`Combination N:${combinations} (${i} + ${j} = ${magicNumber})`);
        isFound = true;
        break;
      }
      combinations++;
    }
    if(isFound) {
      break;
    }
  }

  if(!isFound) {
    console.log(`${combinations - 1} combinations - neither equals ${magicNumber}`);
  }
}

function moneyForTravels(input) {
  let index = 0;

  while(true) {
    if(input[index] == "End") {
      break;
    }

    let destination = input[index++];
    let moneyNeeded = Number(input[index++]);
    let moneyCollected = 0;
    while(true) {
      if(moneyCollected >= moneyNeeded) {
        console.log(`Going to ${destination}!`);
        break;
      }

      moneyCollected += Number(input[index++]);
    }
  }
}


function building(input) {
  let floors = Number(input[0]);
  let roomsPerFloor = Number(input[1]);

  for(let i = floors; i >= 1; i--) {
    let floorStr = "";
    for(let j = 0; j < roomsPerFloor; j++) {
      if(i == floors) {
        floorStr += "L" + i + j + " ";
      }
      else if(i % 2 == 0) {
        floorStr += "O" + i + j + " ";
      }
      else if(i % 2 == 1) {
        floorStr += "A" + i + j + " ";
      }
    }
    console.log(floorStr);
  }
}

building(["6", "4"]);
