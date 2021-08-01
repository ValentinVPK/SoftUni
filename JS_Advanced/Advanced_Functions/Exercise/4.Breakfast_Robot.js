

function solution() {
  const recipes = {
    apple: {carbohydrate: 1, flavour: 2},
    lemonade: {carbohydrate: 10, flavour: 20},
    burger: {carbohydrate: 5, fat: 7, flavour: 3},
    eggs: {protein: 5, fat: 1, flavour: 1},
    turkey: {protein: 10, carbohydrate: 10, fat: 10, flavour: 10}
  }


  const storageRobot = {
    protein: 0,
    carbohydrate: 0,
    fat: 0,
    flavour: 0,

    restock: function(ingredient, quantiy) {
      quantiy = Number(quantiy);
      this[ingredient] += quantiy;
      return 'Success';
    },

    prepare: function(meal, quantiy) {
      quantiy = Number(quantiy);
      let neededIngredients = Object.keys(recipes[meal]);

      
      for (const ingredient of neededIngredients) {
        if(this[ingredient] < recipes[meal][ingredient] * quantiy) {
          return `Error: not enough ${ingredient} in stock`;
        }
      }
     
      neededIngredients.forEach(ingredient => {
        this[ingredient] -= recipes[meal][ingredient] * quantiy;
      });

      return 'Success';
    },

    report: function() {
      return `protein=${this.protein} carbohydrate=${this.carbohydrate} fat=${this.fat} flavour=${this.flavour}`;
    }
  }

  return function(command) {
    let tokens = command.split(' ');

    if(tokens[0] === 'restock') {
      let [command, ingredient, quantiy] = [...tokens];
      return storageRobot[command](ingredient, quantiy);
    } 

    if(tokens[0] === 'prepare') {
      let [command, recipe, quantiy] = [...tokens];
      return storageRobot[command](recipe,quantiy);
    } 

    if(tokens[0] === 'report') {
      return storageRobot[tokens[0]]();
    }
  }
}

let manager = solution ();
console.log(manager('restock carbohydrate 10')) // Success
console.log(manager('restock flavour 10')) // Success
console.log(manager('prepare apple 1')) // Success
console.log(manager('restock fat 10')) // Success
console.log(manager('prepare burger 1')) // Success
console.log(manager('report')) // protein=0 carbohydrate=4 fat=3 flavour=5


