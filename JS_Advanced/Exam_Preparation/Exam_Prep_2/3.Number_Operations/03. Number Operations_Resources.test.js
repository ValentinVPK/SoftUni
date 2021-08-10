
const {assert} = require('chai');
const numberOperations = require('./03. Number Operations_Resources');

describe("Tests numberOperations", function() {
  describe("powNumber", function() {
      it("Should return correct answer", function() {
          let expected = 3*3;

          assert.equal(numberOperations.powNumber(3), expected);

          expected = 1.5 * 1.5;
          assert.equal(numberOperations.powNumber(1.5), expected);
      });
   });

   describe("numberChecker", function() {
      it("Should throw error if input is not a number", function() {
        
        //assert.throws(() => numberOperations.numberChecker(''), Error, 'The input is not a number!');
        assert.throws(() => numberOperations.numberChecker('Hello'), Error, 'The input is not a number!');
        //assert.throws(() => numberOperations.numberChecker([]), Error, 'The input is not a number!');
        assert.throws(() => numberOperations.numberChecker(undefined), Error, 'The input is not a number!');
        assert.throws(() => numberOperations.numberChecker({}), Error, 'The input is not a number!');
      });

      it("Should return correct message if number is lower than 100", function() {
        let expected = 'The number is lower than 100!';

        assert.equal(numberOperations.numberChecker(99), expected);
        assert.equal(numberOperations.numberChecker(0), expected);
        assert.equal(numberOperations.numberChecker(50), expected);
        assert.equal(numberOperations.numberChecker(10.5), expected);
      });

      it("Should return correct message if number is equal or higher than 100", function() {
        let expected = 'The number is greater or equal to 100!';

        assert.equal(numberOperations.numberChecker(100), expected);
        assert.equal(numberOperations.numberChecker(150.3), expected);
      });
   });
   describe("sumArrays", function() {
    it("Should return empty array if both inputs are empty arrays", function() {
      let expected = [].join('');
      assert.equal(numberOperations.sumArrays([], []).join(''), expected);
    });
    
    it("Should return the numbers in one of the arrays if the other array is empty", function() {
        let expected = [2, 3.5, 5].join(' ');
        assert.equal(numberOperations.sumArrays([], [2, 3.5, 5]).join(' '), expected);
    });
    
    it("Should return correct array if both inputs are with equal lengths", function() {
        let inputArray = [2, 3.5, 5];
        let expected = [2 + 2, 3.5 + 3.5, 5 + 5].join(' ');
        assert.equal(numberOperations.sumArrays(inputArray, inputArray).join(' '), expected);
    });

    it("Should return correct array if one of the inputs is with greater length", function() {
        let inputArray1 = [2, 4, 5];
        let inputArray2 = [1, 6, 8, 9];
        let expected = [2 + 1, 4 + 6, 5 + 8, 9].join(' ');
        assert.equal(numberOperations.sumArrays(inputArray1, inputArray2).join(' '), expected);
        assert.equal(numberOperations.sumArrays(inputArray2, inputArray1).join(' '), expected);
    });
 });     
});
