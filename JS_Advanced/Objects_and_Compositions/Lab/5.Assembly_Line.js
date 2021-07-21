

function createAssemblyLine() {
  const library = {

    hasClima(carObj) {
      carObj.temp = 21;
      carObj.tempSettings = 21;
      carObj.adjustTemp = function() {
        if(carObj.temp < carObj.tempSettings) {
          carObj.temp++;
        }
        else if(carObj.temp > carObj.tempSettings) {
          carObj.temp--;
        }
      }
    },

    hasAudio(carObj) {
      carObj.currentTrack = null;

      carObj.nowPlaying = function() {
        if(carObj !== null) {
          console.log(`Now playing '${carObj.currentTrack.name}' by ${carObj.currentTrack.artist}`);
        }
      }
    },

    hasParktronic(carObj) {
      carObj.checkDistance = function(distance) {
        if(distance < 0.1) {
          console.log('Beep! Beep! Beep!');
        }
        else if(distance >= 0.1 && distance < 0.25) {
          console.log("Beep! Beep!");
        }
        else if(distance >= 0.25 && distance < 0.5) {
          console.log("Beep!");
        }
        else {
          console.log('');
        }  
      }
    }
  };

  return library;
}


// Testing:

const assemblyLine = createAssemblyLine();

const myCar = {
    make: 'Toyota',
    model: 'Avensis'
};

//First test
assemblyLine.hasClima(myCar);
console.log(myCar.temp);
myCar.tempSettings = 18;
myCar.adjustTemp();
console.log(myCar.temp);

// Second test
assemblyLine.hasAudio(myCar);
myCar.currentTrack = {
    name: 'Never Gonna Give You Up',
    artist: 'Rick Astley'
};
myCar.nowPlaying();

// Third test

assemblyLine.hasParktronic(myCar);
myCar.checkDistance(0.4);
myCar.checkDistance(0.2);

// Final test
console.log(myCar);
