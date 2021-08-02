
const isSymmetric = require('../5.Check_for_Symmetry');

const {assert, expect, should} = require('chai');

describe('Check if isSymmetric is working correctly' , () => {
  it('Should return true if array is symmetric', () => {
    let inputArray = [1, 2, 3, 2, 1];
    let expectedResult = true;

    let actualResult = isSymmetric(inputArray);

    assert.equal(expectedResult, actualResult);
  });

  it('Should return false if array is not symmetric', () => {
    let inputArray = [1, 2, 3, 1, 2];
    let expectedResult = false;

    let actualResult = isSymmetric(inputArray);

    assert.equal(expectedResult, actualResult);
  });

  it('Function input should be an array', () => {
    let expectedResult = false;

    assert.equal(isSymmetric(''), expectedResult);
    assert.equal(isSymmetric(0), expectedResult);
    assert.equal(isSymmetric({}), expectedResult);
    assert.equal(isSymmetric(null), expectedResult);
    assert.equal(isSymmetric(undefined), expectedResult);
    assert.equal(isSymmetric(true), expectedResult);
    assert.equal(isSymmetric(false), expectedResult);
  });

  it('Funtion should return true if input array is empty', () => {

    let inputArray = [];
    let expectedResult = true;

    let actualResult = isSymmetric(inputArray);

    assert.equal(actualResult, expectedResult);
  });

  it('Should return false if input array is filled with different types', () => {

    let inputArray = [1, '1'];
    let expectedResult = false;

    let actualResult = isSymmetric(inputArray);

    assert.equal(actualResult, expectedResult);
  });
});