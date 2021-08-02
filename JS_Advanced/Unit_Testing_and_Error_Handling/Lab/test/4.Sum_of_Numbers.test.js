
const sum = require('../4.Sum_of_Numbers');

const assert = require('chai').assert;

describe('Test sum funtionality', () => {
  
  it('Sum should return correct value', () => {
    let inputArray = [2, 5, 8, 4];
    let expectedResult = 19;

    let actualResult = sum(inputArray);

    assert.equal(expectedResult, actualResult);
  });

});