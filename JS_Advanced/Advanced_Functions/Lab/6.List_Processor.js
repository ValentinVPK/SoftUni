

function solve(inputArray) {

  let obj = processArray();
  inputArray.forEach(str => {
    let [command, value] = str.split(' ');
    obj[command](value);
  });

  function processArray() {
    let array = [];
  
    return {
      add: function(str) {
        array.push(str);
      },
  
      remove: function(str) {
        while(array.includes(str)) {
          array.splice(array.indexOf(str),1);
        }
      },
  
      print: function() {
        console.log(array.join(','));
      }
    }
  }
}

solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);