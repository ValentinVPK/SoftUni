
const {assert} = require('chai');
const PaymentPackage = require('../12.Payment_Package');

describe('PaymentPackage', () => {
  describe('constructor', () => {
    it('Should set values to properties when initialized', () => {
      let pay = new PaymentPackage('Default', 10);

      assert.equal(pay.name, 'Default');
      assert.equal(pay.value, 10);
      assert.equal(pay.VAT, 20);
      assert.equal(pay.active, true);
    });
  });

  describe('name', () => {
    it('Should throw error if input is not a string', () => {
      let pay = new PaymentPackage('Default', 10);

      assert.throws(() => pay.name = true, Error, 'Name must be a non-empty string');
      assert.throws(() => pay.name = 1.5, Error, 'Name must be a non-empty string');
      assert.throws(() => pay.name = [], Error, 'Name must be a non-empty string');
      assert.throws(() => pay.name = {}, Error, 'Name must be a non-empty string');
      assert.throws(() => pay.name = null, Error, 'Name must be a non-empty string');
      assert.throws(() => pay.name = undefined, Error, 'Name must be a non-empty string');
    });

    it('Should throw error if input is empty string', () => {
      let pay = new PaymentPackage('Default', 10);

      assert.throws(() => pay.name = '', Error, 'Name must be a non-empty string');
    });
    
    it('Should set name property if input is correct', () => {
      let pay = new PaymentPackage('Default', 10);

      pay.name = 'New';
      assert.equal(pay.name, 'New');
    });
  });

  describe('value', () => {
    it('Should throw error if input is not a number', () => {
      let pay = new PaymentPackage('Default', 10);

      assert.throws(() => pay.value = true, Error, 'Value must be a non-negative number');
      assert.throws(() => pay.value = 'abc', Error, 'Value must be a non-negative number');
      assert.throws(() => pay.value = '', Error, 'Value must be a non-negative number');
      assert.throws(() => pay.value = [], Error, 'Value must be a non-negative number');
      assert.throws(() => pay.value = {}, Error, 'Value must be a non-negative number');
      assert.throws(() => pay.value = null, Error, 'Value must be a non-negative number');
      assert.throws(() => pay.value = undefined, Error, 'Value must be a non-negative number');
    });
    it('Should throw error if input is a negative number', () => {
      let pay = new PaymentPackage('Default', 10);
      
      assert.throws(() => pay.value = -100, Error, 'Value must be a non-negative number');
    });

    it('Should set value property if input is correct', () => {
      let pay = new PaymentPackage('Default', 10);

      pay.value = 50;
      assert.equal(pay.value, 50);
      
      pay.value = 0;
      assert.equal(pay.value, 0);
    });
  });

  describe('VAT', () => {
    it('Should throw error if input is not a number', () => {
      let pay = new PaymentPackage('Default', 10);

      assert.throws(() => pay.VAT = true, Error, 'VAT must be a non-negative number');
      assert.throws(() => pay.VAT = 'abc', Error, 'VAT must be a non-negative number');
      assert.throws(() => pay.VAT = '', Error, 'VAT must be a non-negative number');
      assert.throws(() => pay.VAT = [], Error, 'VAT must be a non-negative number');
      assert.throws(() => pay.VAT = {}, Error, 'VAT must be a non-negative number');
      assert.throws(() => pay.VAT = null, Error, 'VAT must be a non-negative number');
      assert.throws(() => pay.VAT = undefined, Error, 'VAT must be a non-negative number');
    });
    it('Should throw error if input is a negative number', () => {
      let pay = new PaymentPackage('Default', 10);
      
      assert.throws(() => pay.VAT = -100, Error, 'VAT must be a non-negative number');
    });

    it('Should set VAT property if input is correct', () => {
      let pay = new PaymentPackage('Default', 10);

      pay.VAT = 50;
      assert.equal(pay.VAT, 50);

      pay.VAT = 0;
      assert.equal(pay.VAT, 0);
    });
  });

  describe('active', () => {
    it('Should throw error if input is not a boolean', () => {
      let pay = new PaymentPackage('Default', 10);

      assert.throws(() => pay.active = 1.5, Error, 'Active status must be a boolean');
      assert.throws(() => pay.active = 'abc', Error, 'Active status must be a boolean');
      assert.throws(() => pay.active = '', Error, 'Active status must be a boolean');
      assert.throws(() => pay.active = [], Error, 'Active status must be a boolean');
      assert.throws(() => pay.active = {}, Error, 'Active status must be a boolean');
      assert.throws(() => pay.active = null, Error, 'Active status must be a boolean');
      assert.throws(() => pay.active = undefined, Error, 'Active status must be a boolean');
    });

    it('Should set active property if input is correct', () => {
      let pay = new PaymentPackage('Default', 10);

      pay.active = false;
      assert.equal(pay.active, false);
    });
  });

  describe('toString', () => {
    it('Should return correct string if pay is inactive', () => {
      let pay = new PaymentPackage('Default', 50)
      const expected = [
        `Package: ${pay.name}` + (pay.active === false ? ' (inactive)' : ''),
        `- Value (excl. VAT): ${pay.value}`,
        `- Value (VAT ${pay.VAT}%): ${pay.value * (1 + pay.VAT / 100)}`
      ];

      assert.equal(pay.toString(), expected.join('\n'));
    });

    it('Should return correct string if pay is active', () => {
      let pay = new PaymentPackage('Default', 50)
      pay.active = false;
      const expected = [
        `Package: ${pay.name}` + (pay.active === false ? ' (inactive)' : ''),
        `- Value (excl. VAT): ${pay.value}`,
        `- Value (VAT ${pay.VAT}%): ${pay.value * (1 + pay.VAT / 100)}`
      ];

      assert.equal(pay.toString(), expected.join('\n'));
    });
  });
});
