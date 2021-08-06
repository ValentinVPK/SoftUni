class Hex {
  constructor(value) {
    this.value = value;
  }

  valueOf() {
    return this.value;
  }

  toString() {
    const valuesMap = new Map([
      [1,'1'],
      [2,'2'],
      [3,'3'],
      [4,'4'],
      [5,'5'],
      [6,'6'],
      [7,'7'],
      [8,'8'],
      [9,'9'],
      [10,'A'],
      [11,'B'],
      [12,'C'],
      [13,'D'],
      [14,'E'],
      [15,'F']
    ]);
    let valueTemp = this.value;
    let hexNumberReversed = '';

    while(valueTemp > 0) {
      hexNumberReversed += valuesMap.get(valueTemp % 16);
      valueTemp = Math.trunc(valueTemp / 16);
    }

    return '0x' + hexNumberReversed.split('').reverse().join('');
  }

  plus(number) {
    if(typeof number === 'number') {
      return new Hex(this.value + number);
    }
    
    return new Hex(this.value + number.value);
  }

  minus(number) {
    if(typeof number === 'number') {
      return new Hex(this.value - number);
    }
    
    return new Hex(this.value - number.value);
  }

  static parse(str) {
    const valuesMap = new Map([
      ['1', 1],
      ['2', 2],
      ['3', 3],
      ['4', 4],
      ['5', 5],
      ['6', 6],
      ['7', 7],
      ['8', 8],
      ['9', 9],
      ['A', 10],
      ['B', 11],
      ['C', 12],
      ['D', 13],
      ['E', 14],
      ['F', 15]
    ]);
    let result = 0;
    let power = 0;
    for(let i = str.length - 1; i >= 0; i--) {
      result += valuesMap.get(str[i]) * (16 ** power);
      power++;
    }

    return result;
  }
}


let FF = new Hex(255);
console.log(FF.toString());
FF.valueOf() + 1 == 256;
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString()==='0xF');
console.log(Hex.parse('AAA'));
