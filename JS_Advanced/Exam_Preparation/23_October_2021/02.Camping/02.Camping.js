class SummerCamp {
  constructor(organizer, location) {
    this.organizer = organizer;
    this.location = location;
    this.priceForTheCamp = {
      child: 150,
      student: 300,
      collegian: 500
    }

    this.listOfParticipants = [];
  }

  registerParticipant (name, condition, money) {
    if(!Object.keys(this.priceForTheCamp).includes(condition.toLowerCase())) {
      throw new Error('Unsuccessful registration at the camp.');
    }

    if(this.listOfParticipants.some(x => x.name === name)) {
      return `The ${name} is already registered at the camp.`;
    }

    if(money < this.priceForTheCamp[condition]) {
      return `The money is not enough to pay the stay at the camp.`;
    }

    const newParticipant = {
      name,
      condition,
      power: 100,
      wins: 0
    }

    this.listOfParticipants.push(newParticipant);

    return `The ${name} was successfully registered.`;
  }

  unregisterParticipant (name) {
    let wantedParticipant = this.listOfParticipants.find(x => x.name === name);
    if(wantedParticipant === undefined) {
      throw new Error(`The ${name} is not registered in the camp.`);
    }

    this.listOfParticipants.splice(this.listOfParticipants.indexOf(wantedParticipant), 1);

    return `The ${name} removed successfully.`;
  }

  timeToPlay (typeOfGame, participant1, participant2) {
    if(typeOfGame === 'WaterBalloonFights') {
      let wantedParticipant1 = this.listOfParticipants.find(x => x.name === participant1);
      let wantedParticipant2 = this.listOfParticipants.find(x => x.name === participant2);

      if(wantedParticipant1 === undefined || wantedParticipant2 === undefined) {
        throw new Error(`Invalid entered name/s.`); // could give an error
      }

      if(wantedParticipant1.condition !== wantedParticipant2.condition) {
        throw new Error(`Choose players with equal condition.`);
      }

      if(wantedParticipant1.power > wantedParticipant2.power) {
        wantedParticipant1.wins++;
        return `The ${wantedParticipant1.name} is winner in the game ${typeOfGame}.`;
      }
      else if(wantedParticipant1.power < wantedParticipant2.power) {
        wantedParticipant2.wins++;
        return `The ${wantedParticipant2.name} is winner in the game ${typeOfGame}.`;
      }

      return `There is no winner.`;
    }
    else {
      let wantedParticipant = this.listOfParticipants.find(x => x.name === participant1);
      if(wantedParticipant === undefined) {
        throw new Error(`Invalid entered name/s.`);
      }

      wantedParticipant.power += 20;
      return `The ${wantedParticipant.name} successfully completed the game ${typeOfGame}.`;
    }
  }

  toString() {
    const result = [];

    result.push(`${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}`);

    for(const participant of this.listOfParticipants.sort((a,b) => b.wins - a.wins)) {
      result.push(`${participant.name} - ${participant.condition} - ${participant.power} - ${participant.wins}`);
    }

    return result.join('\n');
  }
}

// const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 200));
// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
// console.log(summerCamp.registerParticipant("Leila Wolfe", "childd", 200));

// const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
// console.log(summerCamp.unregisterParticipant("Petar"));
// console.log(summerCamp.unregisterParticipant("Petar Petarson"));

// const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
// console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
// console.log(summerCamp.timeToPlay("Battleship", "Petar Petarson"));
// console.log(summerCamp.registerParticipant("Sara Dickinson", "child", 200));
// console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Sara Dickinson"));
// console.log(summerCamp.registerParticipant("Dimitur Kostov", "student", 300));
// console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Dimitur Kostov"));


const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
console.log(summerCamp.timeToPlay("Battleship", "Petar Petarson"));
console.log(summerCamp.registerParticipant("Sara Dickinson", "child", 200));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Sara Dickinson"));
console.log(summerCamp.registerParticipant("Dimitur Kostov", "student", 300));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Dimitur Kostov"));

console.log(summerCamp.toString());
