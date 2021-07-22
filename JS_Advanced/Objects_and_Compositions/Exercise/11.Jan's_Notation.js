

function solve(inputArray) {
  const operands = [];

  for(let element of inputArray) {
    if(typeof element === 'number') {
      operands.push(element);
    } else if(typeof element === 'string') {
      if(operands.length < 2) {
        return 'Error: not enough operands!';
      }
  
      let curr = applyOperation(operands[operands.length - 2], operands[operands.length - 1], element);
      operands.splice(operands.length - 2, 2, curr);
    }
  }

  if(operands.length > 1) {
    return 'Error: too many operands!';
  }

  return operands[0];

  function applyOperation(operand1, operand2, operator) {
    const arithmetics = {
      '+': function() {return operand1 + operand2},
      '-': function() {return operand1 - operand2},
      '*': function() {return operand1 * operand2},
      '/': function() {return operand1 / operand2}
    }

    return arithmetics[operator]();
  }
}


console.log(solve([-1,1,'+',101,'*',18,'+',3,'/']));
