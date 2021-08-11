
const dealership = require('./task');
const {assert} = require('chai');

describe("Tests dealership", function() {
  describe("newCarCost", function() {
      it("Should return discounted price if the first input is an old car", function() {
          let newPrice = 30000;
          let oldCar = 'Audi A4 B8';
          let expected = 15000;

          assert.equal(dealership.newCarCost(oldCar, newPrice), expected);
      });

      it("Should return normal price if the first input is not an old car", function() {
        let newPrice = 30000.50;
        let oldCar = 'BMW X4';
        let expected = newPrice;

        assert.equal(dealership.newCarCost(oldCar, newPrice), expected);
    });
   });
   describe("carEquipment", function() {
    it("Should return empty array if indexArray is empty", function() {
        let indexArray = [];
        let expected = [].join(', ');
        let actualResult = dealership.carEquipment(['heated seats', 'sliding roof', 'sport rims', 'navigation'], indexArray).join(', ');

        assert.equal(actualResult, expected);
    });

    it("Should return correct array if indexArray contains indexes", function() {
      let indexArray = [0, 1, 3];
      let expectedResult = 'heated seats, sliding roof, navigation';
      let actualResult = dealership.carEquipment(['heated seats', 'sliding roof', 'sport rims', 'navigation'], indexArray).join(', ');
      assert.equal(actualResult, expectedResult);
  });
 });
describe("euroCategory", function() {
    it("Should return discounted price if input number is 4 or above", function() {
        let total = dealership.newCarCost('Audi A4 B8', 30000);
        total = total - (total * 0.05);
        let expectedResult = `We have added 5% discount to the final price: ${total}.`;

        let actualResult = dealership.euroCategory(4);

        assert.equal(actualResult, expectedResult);

        actualResult = dealership.euroCategory(6);
        assert.equal(actualResult, expectedResult);
    });

    it("Should return normal price if number is below 4", function() {
      let expected = 'Your euro category is low, so there is no discount from the final price!';
      let actual = dealership.euroCategory(3);

      assert.equal(actual, expected);

      actual = dealership.euroCategory(1);

      assert.equal(actual, expected);
  });
 });
});



