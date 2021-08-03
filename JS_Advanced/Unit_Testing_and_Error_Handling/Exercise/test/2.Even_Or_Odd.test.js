
const assert = require('chai').assert;

const isOddOrEven = require('../2.Even_Or_Odd');

describe('Test isOddOrEven functionality', () => {
  it('Should return undefined if input is not string', () => {
    
    let expectedResult = undefined;

    assert.equal(expectedResult, isOddOrEven(2));
    assert.equal(expectedResult, isOddOrEven([]));
    assert.equal(expectedResult, isOddOrEven({}));
    assert.equal(expectedResult, isOddOrEven(false));
    assert.equal(expectedResult, isOddOrEven(undefined));
    assert.equal(expectedResult, isOddOrEven(null));
  });

  it('Shoud return even if length is even', () => {
    let inputStr = 'hello!';
    let expectedResult = 'even';

    let actualResult = isOddOrEven(inputStr);

    assert.equal(expectedResult, actualResult);
  });

  it('Shoud return odd if length is odd', () => {
    let inputStr = 'hello';
    let expectedResult = 'odd';

    let actualResult = isOddOrEven(inputStr);

    assert.equal(expectedResult, actualResult);
  });
});