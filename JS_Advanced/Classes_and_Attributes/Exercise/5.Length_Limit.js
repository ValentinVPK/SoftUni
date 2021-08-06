
class Stringer {
  constructor(innerString, innerLength) {
    this.innerString = innerString;
    this.innerLength = innerLength;
  }

  increase(length) {
    this.innerLength = length;
  }

  decrease(length) {
    if(length > this.innerLength) {
      this.innerLength = 0;
    } else {
      this.innerLength -= length;
    }
  }

  toString() {
    if(this.innerString.length > this.innerLength) {
      return this.innerLength === 0
        ? '...'
        : this.innerString.substring(0,this.innerString.length - this.innerLength) + '...';
    } else {
      return this.innerString;
    }
  }
}

let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4); 
console.log(test.toString()); // Test
