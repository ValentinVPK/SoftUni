

function rectangle(width, height, color) {
  let upper = color[0].toUpperCase();
  color = color.replace(color[0], upper);

  return {
    width, 
    height, 
    color, 
    calcArea() {
      return this.height * this.width;
    }
  };
}

// Testing the function: 

let rect = rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());
