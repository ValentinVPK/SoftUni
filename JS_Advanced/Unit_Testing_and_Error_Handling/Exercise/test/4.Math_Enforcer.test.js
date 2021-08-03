
const assert = require('chai').assert;

const mathEnforcer = require('../4.Math_Enforcer');

describe('Testing mathEnforcer functionality', () => {
  describe('addFive', () => {
    it('Should return undefined if input is not a number', () => {

      assert.equal(mathEnforcer.addFive(''), undefined);
      assert.equal(mathEnforcer.addFive([]), undefined);
      assert.equal(mathEnforcer.addFive({}), undefined);
      assert.equal(mathEnforcer.addFive(false), undefined);
      assert.equal(mathEnforcer.addFive(undefined), undefined);
      assert.equal(mathEnforcer.addFive(null), undefined);
    });
    
    it('Should return correct result if input is a positive number', () => {
      let expectedResult = 8;
      let actualResult = mathEnforcer.addFive(3);
      
      assert.equal(expectedResult, actualResult);
    });

    it('Should return correct result if input is a negative number', () => {
      let expectedResult = 2;
      let actualResult = mathEnforcer.addFive(-3);
      
      assert.equal(expectedResult, actualResult);
    });

    it('Should return correct result if input is a negative number', () => {
      let expectedResult = -3;
      let actualResult = mathEnforcer.addFive(-8);
      
      assert.equal(expectedResult, actualResult);
    });

    it('Should return correct result if input is a floating point number', () => {
      let expectedResult = 6.99;
      let actualResult = mathEnforcer.addFive(1.999);
      
      assert.closeTo(actualResult, expectedResult, 0.01);
    });
  });

  describe('subtractTen', () => {
    it('Should return undefined if input is not a number', () => {

      assert.equal(mathEnforcer.subtractTen(''), undefined);
      assert.equal(mathEnforcer.subtractTen([]), undefined);
      assert.equal(mathEnforcer.subtractTen({}), undefined);
      assert.equal(mathEnforcer.subtractTen(false), undefined);
      assert.equal(mathEnforcer.subtractTen(undefined), undefined);
      assert.equal(mathEnforcer.subtractTen(null), undefined);
    });
    
    it('Should return correct result if input is a positive number', () => {
      let expectedResult = 2;
      let actualResult = mathEnforcer.subtractTen(12);
      
      assert.equal(expectedResult, actualResult);
    });

    it('Should return correct result if input is a negative number', () => {
      let expectedResult = -12;
      let actualResult = mathEnforcer.subtractTen(-2);
      
      assert.equal(actualResult, expectedResult);
    });

    it('Should return correct result if input is a negative number v2', () => {
      let expectedResult = -4;
      let actualResult = mathEnforcer.subtractTen(6);
      
      assert.equal(actualResult, expectedResult);
    });

    it('Should return correct result if input is a floating point number', () => {
      let expectedResult = -1;
      let actualResult = mathEnforcer.subtractTen(8.999);
      
      assert.closeTo(actualResult, expectedResult, 0.01);
    });
  });

  describe('sum', () => {
    it('Should return undefined if both inputs are not a number', () => {

      assert.equal(mathEnforcer.sum('', undefined), undefined);
      assert.equal(mathEnforcer.sum([], ''), undefined);
      assert.equal(mathEnforcer.sum({}, true), undefined);
      assert.equal(mathEnforcer.sum(false, [3,5]), undefined);
      assert.equal(mathEnforcer.sum(undefined, '2'), undefined);
      assert.equal(mathEnforcer.sum(null, {number: 5}), undefined);
    });

    it('Should return undefined if first input is not a number', () => {

      assert.equal(mathEnforcer.sum('', 2), undefined);
      assert.equal(mathEnforcer.sum([], 2), undefined);
      assert.equal(mathEnforcer.sum({}, 2), undefined);
      assert.equal(mathEnforcer.sum(false, 2), undefined);
      assert.equal(mathEnforcer.sum(undefined, 2), undefined);
      assert.equal(mathEnforcer.sum(null, 2), undefined);
    });
    
    it('Should return undefined if second input is not a number', () => {

      assert.equal(mathEnforcer.sum(2, ''), undefined);
      assert.equal(mathEnforcer.sum(2, []), undefined);
      assert.equal(mathEnforcer.sum(2, {}), undefined);
      assert.equal(mathEnforcer.sum(2, false), undefined);
      assert.equal(mathEnforcer.sum(2, undefined), undefined);
      assert.equal(mathEnforcer.sum(2, null), undefined);
    });

    it('Should return correct result if both inputs are positive numbers', () => {
      let expectedResult = 13;
      let actualResult = mathEnforcer.sum(7,6);
      
      assert.equal(actualResult, expectedResult);
    });

    it('Should return correct result if both inputs are negative numbers', () => {
      let expectedResult = -13;
      let actualResult = mathEnforcer.sum(-6,-7);
      
      assert.equal(actualResult, expectedResult);
    });

    it('Should return correct result if inputs are with different signs', () => {
      let expectedResult = -5;
      let actualResult = mathEnforcer.sum(3,-8);
      
      assert.equal(actualResult, expectedResult);
    });

    it('Should return correct result if inputs are with different signs', () => {
      let expectedResult = 3;
      let actualResult = mathEnforcer.sum(-5, 8);
      
      assert.equal(actualResult, expectedResult);
    });

    it('Should return correct result if inputs 0 0', () => {
      let expectedResult = 0;
      let actualResult = mathEnforcer.sum(0, 0);
      
      assert.equal(actualResult, expectedResult);
    });

    it('Should return correct result if inputs are floating point numbers', () => {
      let expectedResult = 6.99;
      let actualResult = mathEnforcer.sum(3.999,3);

      assert.closeTo(actualResult, expectedResult, 0.01);
    });

    it('Should return correct result if inputs are floating point', () => {
      let expectedResult = 3.32;
      let actualResult = mathEnforcer.sum(1.82, 1.5);
      
      assert.equal(actualResult, expectedResult);
    });
  });
});