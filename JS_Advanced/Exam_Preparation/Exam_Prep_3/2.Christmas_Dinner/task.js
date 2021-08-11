class ChristmasDinner {
  constructor(budget) {
    if(budget < 0) {
      throw new Error('The budget cannot be a negative number');
    }
    this.budget = budget;
    this.dishes = [];
    this.products = [];
    this.guests = {};
  }

  shopping(product) {
    let [type, price] = product;
    if(price > this.budget) {
      throw new Error('Not enough money to buy this product');
    }

    this.budget -= price;
    this.products.push(type);

    return `You have successfully bought ${type}!`;
  }

  recipes(recipe) {
    for (const element of recipe.productsList) {
      if(!this.products.includes(element)) {
        throw new Error('We do not have this product');
      }
    }

    this.dishes.push(recipe);
    return `${recipe.recipeName} has been successfully cooked!`;
  }

  inviteGuests(name, dish) {
    if(!this.dishes.some(x => x.recipeName === dish)) {
      throw new Error('We do not have this dish');
    }

    if(this.guests.hasOwnProperty(name)) {
      throw new Error('This guest has already been invited');
    }

    this.guests[name] = dish;
  }

  showAttendance() {
    let result = '';
    for (const guest in this.guests) {
      let guestDish = this.dishes.find(x => x.recipeName === this.guests[guest]);
      
      result += `${guest} will eat ${this.guests[guest]}, which consists of ${guestDish.productsList.join(', ')}\n`;
    }

    return result.trim();
  }
}

let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());


