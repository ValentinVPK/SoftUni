
const rgbToHexColor = require('../6.RGB_to_Hex');

const assert = require('chai').assert;

describe('Test rgbToHex functionality', () => {

  it('Shoud return string if everything is correct', () => {
    
    let expectedResult = '#324B64';
    let red = 50;
    let green = 75;
    let blue = 100;

    let actualResult = rgbToHexColor(red,green,blue);

    assert.equal(expectedResult, actualResult);
  });

  it('Shoud return undenfied if number for red is undefined', () => {
    
    assert.equal(rgbToHexColor(-1, 100, 150), undefined);
    assert.equal(rgbToHexColor(256, 100, 150), undefined);
    assert.equal(rgbToHexColor('', 100, 150), undefined);
    assert.equal(rgbToHexColor(234.5, 100, 150), undefined);
    assert.equal(rgbToHexColor(false, 100, 150), undefined);
    assert.equal(rgbToHexColor(undefined, 100, 150), undefined);
    assert.equal(rgbToHexColor(null, 100, 150), undefined);
    assert.equal(rgbToHexColor([], 100, 150), undefined);
    assert.equal(rgbToHexColor({}, 100, 150), undefined);
  });

  it('Shoud return undenfied if number for green is undefined', () => {
    
    assert.equal(rgbToHexColor(100, -1, 150), undefined);
    assert.equal(rgbToHexColor(100, 256, 150), undefined);
    assert.equal(rgbToHexColor(100, '', 150), undefined);
    assert.equal(rgbToHexColor(100, 234.5, 150), undefined);
    assert.equal(rgbToHexColor(100, false, 150), undefined);
    assert.equal(rgbToHexColor(100, undefined, 150), undefined);
    assert.equal(rgbToHexColor(100, null, 150), undefined);
    assert.equal(rgbToHexColor(100, [], 150), undefined);
    assert.equal(rgbToHexColor(100, {}, 150), undefined);
  });

  it('Shoud return undenfied if number for blue is undefined', () => {
    
    assert.equal(rgbToHexColor(100, 150,-1), undefined);
    assert.equal(rgbToHexColor(100, 150,256), undefined);
    assert.equal(rgbToHexColor(100, 150,''), undefined);
    assert.equal(rgbToHexColor(100, 150,234.5), undefined);
    assert.equal(rgbToHexColor(100, 150,false), undefined);
    assert.equal(rgbToHexColor(100, 150,undefined), undefined);
    assert.equal(rgbToHexColor(100, 150,null), undefined);
    assert.equal(rgbToHexColor(100, 150,[]), undefined);
    assert.equal(rgbToHexColor(100, 150,{}), undefined);
  });
});