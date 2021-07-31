
function solution() {
  const resultObj = {
    str: '',

    append(inputStr) {
      this.str = this.str.concat(inputStr);
    },

    removeStart(n) {
      this.str = this.str.slice(n);
    },

    removeEnd(n) {
      this.str = this.str.slice(0,this.str.length - n);
    },
    
    print() {
      console.log(this.str);
    }
  }

  return resultObj;
}

let firstZeroTest = solution();

firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.removeStart(3);
firstZeroTest.removeEnd(4);
firstZeroTest.print();
