
const assert = require('chai').assert;
const lookupChar = require('../3.Char_Lookup');

describe('Test lookupChar functionality', () => {

  it('Should return char when inputs are correct', () => {
    let expectedResult = 'l';
    let actualResult = lookupChar('hello', 2);

    assert.equal(expectedResult, actualResult);
  });

  it('Should return undefined when string input is incorrect', () => {
    let expectedResult = undefined;

    assert.equal(expectedResult, lookupChar(1, 2));
    assert.equal(expectedResult, lookupChar([], 2));
    assert.equal(expectedResult, lookupChar({}, 2));
    assert.equal(expectedResult, lookupChar(false, 2));
    assert.equal(expectedResult, lookupChar(null, 2));
    assert.equal(expectedResult, lookupChar(undefined, 2));
  });

  it('Should return undefined when index input is incorrect', () => {
    let expectedResult = undefined;

    assert.equal(lookupChar('hello',1.5), expectedResult);
    assert.equal(lookupChar('hello',[]), expectedResult);
    assert.equal(lookupChar('hello',{}), expectedResult);
    assert.equal(lookupChar('hello',false), expectedResult);
    assert.equal(lookupChar('hello',null), expectedResult);
    assert.equal(expectedResult, lookupChar('hello', undefined));
  });

  it('Should return undefined when index too small or too big', () => {
    let expectedResult = 'Incorrect index';

    assert.equal(lookupChar('hello',-1), expectedResult);
    assert.equal(lookupChar('hello',5), expectedResult);
    assert.equal(lookupChar('hello',6), expectedResult);
  });

});