
const assert = require('chai').assert;
const StringBuilder = require('../13.String_Builder');

describe('StringBuilder', () => {
  describe('constructor', () => {
    it('Should initalize with empty array if undefined is passed', () => {
      let sb = new StringBuilder();

      assert.equal(sb.toString(), '');
    });

    it('Should throw error if passed non string argument', () => {
      assert.throws(()=> new StringBuilder(1.23), TypeError, 'Argument must be a string');
      assert.throws(()=> new StringBuilder(null), TypeError, 'Argument must be a string');
      assert.throws(()=> new StringBuilder(true), TypeError, 'Argument must be a string');
      assert.throws(()=> new StringBuilder({}), TypeError, 'Argument must be a string');
    });

    it('Should initialize correct array if passed a string', () => {
      let sb1 = new StringBuilder('abc');
      let sb2 = new StringBuilder('test');

      assert.equal(sb1.toString(), 'abc');
      assert.equal(sb2.toString(), 'test');
    });
  });


  describe('append', () => {
    it('Should throw error if a non string is passed', () => {
      let sb1 = new StringBuilder();

      assert.throws(() => sb1.append(1.23), TypeError, 'Argument must be a string');
      assert.throws(()=> sb1.append(null), TypeError, 'Argument must be a string');
      assert.throws(()=> sb1.append(true), TypeError, 'Argument must be a string');
      assert.throws(()=> sb1.append({}), TypeError, 'Argument must be a string');

      let sb2 = new StringBuilder('abc');

      assert.throws(() => sb2.append(1.23), TypeError, 'Argument must be a string');
      assert.throws(()=> sb2.append(null), TypeError, 'Argument must be a string');
      assert.throws(()=> sb2.append(true), TypeError, 'Argument must be a string');
      assert.throws(()=> sb2.append({}), TypeError, 'Argument must be a string');
    });

    it('Should append the chars when string is passed', () => {
      let sb1 = new StringBuilder();
      let expected1 = '123';

      sb1.append(expected1);
      assert.equal(sb1.toString(), expected1);

      let expected2 = 'abcwow';
      let sb2 = new StringBuilder('abc');
      sb2.append('wow');

      assert.equal(sb2.toString(), expected2);

      // testing a bug in append
      sb2.append('123');
      'abcwowX123'
      sb2.remove(6,1);
      let expected3 = 'abcwow23';
      assert.equal(sb2.toString(), expected3);
    });
  });

  describe('prepend', () => {
    it('Should throw error if a non string is passed', () => {
      let sb1 = new StringBuilder();

      assert.throws(() => sb1.prepend(1.23), TypeError, 'Argument must be a string');
      assert.throws(()=> sb1.prepend(null), TypeError, 'Argument must be a string');
      assert.throws(()=> sb1.prepend(true), TypeError, 'Argument must be a string');
      assert.throws(()=> sb1.prepend({}), TypeError, 'Argument must be a string');

      let sb2 = new StringBuilder('abc');

      assert.throws(() => sb2.prepend(1.23), TypeError, 'Argument must be a string');
      assert.throws(()=> sb2.prepend(null), TypeError, 'Argument must be a string');
      assert.throws(()=> sb2.prepend(true), TypeError, 'Argument must be a string');
      assert.throws(()=> sb2.prepend({}), TypeError, 'Argument must be a string');
    });

    it('Should prepend the chars when string is passed', () => {
      let sb1 = new StringBuilder();
      let expected1 = '123';

      sb1.prepend(expected1);
      assert.equal(sb1.toString(), expected1);

      let expected2 = 'wowabc';
      let sb2 = new StringBuilder('abc');
      sb2.prepend('wow');
      assert.equal(sb2.toString(), expected2);

      'wowXabc';
      sb2.remove(3, 1);
      let expected3 = 'wowbc';

      assert.equal(sb2.toString(), 'wowbc');
    });
  });

  describe('insertAt', () => {
    it('Should throw error if a non string is passed', () => {
      let sb1 = new StringBuilder();

      assert.throws(() => sb1.insertAt(1.23,0), TypeError, 'Argument must be a string');
      assert.throws(()=> sb1.insertAt(null,0), TypeError, 'Argument must be a string');
      assert.throws(()=> sb1.insertAt(true,0), TypeError, 'Argument must be a string');
      assert.throws(()=> sb1.insertAt({},0), TypeError, 'Argument must be a string');

      let sb2 = new StringBuilder('abc');

      assert.throws(() => sb2.insertAt(1.23,0), TypeError, 'Argument must be a string');
      assert.throws(()=> sb2.insertAt(null,0), TypeError, 'Argument must be a string');
      assert.throws(()=> sb2.insertAt(true,0), TypeError, 'Argument must be a string');
      assert.throws(()=> sb2.insertAt({},0), TypeError, 'Argument must be a string');
    });
    
    it('Should insert chars at correct index when passed a string', () => {
      let sb1 = new StringBuilder('hlo');
      let expected1 = 'hello';

      sb1.insertAt('el', 1);
      assert.equal(sb1.toString(), expected1);

      let expected2 = 'hello user';
      sb1.insertAt(' user', 5);
      assert.equal(sb1.toString(), expected2);

      sb1.remove(5,1);
      let expected3 = 'hellouser';
      assert.equal(sb1.toString(), expected3);
    });
  });

  describe('remove', () => {
    it('Should remove chars at correct index', () => {
      let sb1 = new StringBuilder('Hello, user!');
      let expected1 = 'Hello, use!';

      sb1.remove(10, 1);
      assert.equal(sb1.toString(), expected1);

      let expected2 = 'Hello';
      sb1.remove(5,6);
      assert.equal(sb1.toString(), expected2);
    });
  });

  describe('toString', () => {
    it('Should return correct string', () => {
      let sb1 = new StringBuilder();
      assert.equal(sb1.toString(), '');

      let sb2 = new StringBuilder('Hello, user!');
      assert.equal(sb2.toString(), 'Hello, user!');
    });
  });
});