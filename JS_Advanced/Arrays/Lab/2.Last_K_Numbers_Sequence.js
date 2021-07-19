
function calculateArray(n, k) {
  let arr = [1];

  for(let i = 1; i < n; i++) {
    let currElement = 0;
    if(i - k < 0) {
      arr.forEach(x => currElement += x);
    }
    else {
      arr.slice(i - k, i).forEach(x => currElement += x);
    }

    arr.push(currElement);
  }

  return arr;
}

console.log(calculateArray(8,2));