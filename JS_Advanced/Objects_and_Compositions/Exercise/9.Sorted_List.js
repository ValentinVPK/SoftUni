
function createSortedList() {
  const arr = [];

  return {
    add(element) {
      arr.push(element);
      arr.sort((a,b) => a - b);
      this.size++;
    },
    
    remove(index) {
      if(index < 0 || index > this.size - 1) {
        throw new RangeError('Index out of range!');
      }

      arr.splice(index, 1);
      this.size--;
    },

    get(index) {
      if(index < 0 || index > this.size - 1) {
        throw new RangeError('Index out of range!');
      }

      return arr[index];
    },

    size: 0
  }
}


//Testing the function :

let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
