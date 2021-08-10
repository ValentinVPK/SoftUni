
let pizzUni = {
  makeAnOrder: function (obj) {

      if (!obj.orderedPizza) {
          throw new Error('You must order at least 1 Pizza to finish the order.');
      } else {
          let result = `You just ordered ${obj.orderedPizza}`;
          if (obj.orderedDrink) {
              result += ` and ${obj.orderedDrink}.`;
          }
          return result;
      }
  },

  getRemainingWork: function (statusArr) {

      const remainingArr = statusArr.filter(s => s.status != 'ready');

      if (remainingArr.length > 0) {

          let pizzaNames = remainingArr.map(p => p.pizzaName).join(', ');
          let pizzasLeft = `The following pizzas are still preparing: ${pizzaNames}.`;

          return pizzasLeft;
      } else {
          return 'All orders are complete!';
      }

  },

  orderType: function (totalSum, typeOfOrder) {
      if (typeOfOrder === 'Carry Out') {
          totalSum -= totalSum * 0.1;

          return totalSum;
      } else if (typeOfOrder === 'Delivery') {

          return totalSum;
      }
  }
}

const {assert} = require('chai');


describe("Tests pizzUni", function() {
  describe("makeAnOrder", function() {
      it("Should throw error if obj input has not got orderedPizza", function() {
        const obj1 = {}; // property missing
        const obj2 = {orderedPizza: undefined} // property undefined
        const obj3 = {orderedPizza: ''} // property empty string
        // Could add more

        assert.throws(() => pizzUni.makeAnOrder(obj1), Error, 'You must order at least 1 Pizza to finish the order.');
        assert.throws(() => pizzUni.makeAnOrder(obj2), Error, 'You must order at least 1 Pizza to finish the order.');
        assert.throws(() => pizzUni.makeAnOrder(obj3), Error, 'You must order at least 1 Pizza to finish the order.');
      });

      it('Should return only pizza name if obj input has orderedPizza and has not got orderedDrink', function() {
        const obj1 = {orderedPizza: 'Margarita'};
        const obj2 = {orderedPizza: 'Margarita', orderedDrink: ''};
        const obj3 = {orderedPizza: 'Margarita', orderedDrink: undefined};

        let expceted = `You just ordered ${obj1.orderedPizza}`;
        assert.equal(pizzUni.makeAnOrder(obj1), expceted);
        assert.equal(pizzUni.makeAnOrder(obj2), expceted);
        assert.equal(pizzUni.makeAnOrder(obj3), expceted);
      });

      it('Should return pizza name and drink name if input obj has orderedPizza and orderedDrink', function() {
        const obj1 = {orderedPizza: 'Margarita', orderedDrink: 'Cola'};
        let expceted = `You just ordered ${obj1.orderedPizza} and ${obj1.orderedDrink}.`;

        assert.equal(pizzUni.makeAnOrder(obj1), expceted);
      });
   });

  describe("getRemainingWork", function() {
    it("Should return correct output if input array is empty or all pizzas are ready", function() {
      const inputArray1 = [{pizzaName: 'Name', status: 'ready'}, {pizzaName: 'Name2', status: 'ready'}];
      const inputArray2 = [];
      let expected = 'All orders are complete!';

      assert.equal(pizzUni.getRemainingWork(inputArray1), expected);
      assert.equal(pizzUni.getRemainingWork(inputArray2), expected);
    });
    it("Should return correct output if input array contains unprepared pizzas", function() {
      const inputArray1 = [{pizzaName: 'Margarita', status: 'preparing'}, {pizzaName: 'Hawai', status: 'preparing'}, {pizzaName: 'Fungi', status: 'ready'}];
      let expected = 'The following pizzas are still preparing: Margarita, Hawai.';

      assert.equal(pizzUni.getRemainingWork(inputArray1), expected);
    });
  });

  describe("orderType", function() {
    it("Should return correct output if order type is Carry Out", function() {
      let totalSum = 100;
      
      let expected = 90;
      assert.equal(pizzUni.orderType(totalSum, 'Carry Out'), expected);
      
      totalSum = 50.75;
      expected = totalSum - 0.1 * totalSum;

      assert.equal(pizzUni.orderType(totalSum, 'Carry Out'), expected);
    });
    
    it("Should return correct output if order type is Delivery", function() {
      let totalSum = 100;
      
      let expected = totalSum;
      assert.equal(pizzUni.orderType(totalSum, 'Delivery'), expected);
      
      totalSum = 50.75;
      expected = totalSum

      assert.equal(pizzUni.orderType(totalSum, 'Delivery'), expected);
    });
  });
});

