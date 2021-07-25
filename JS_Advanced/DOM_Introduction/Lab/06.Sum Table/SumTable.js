function sumTable() {
  let sum = 0;
  let tableRowsElements = document.querySelectorAll('table tr');
  
  for(let row = 1; row < tableRowsElements.length; row++) {
    let cols = tableRowsElements[row].children;
    let cost = cols[cols.length - 1].textContent;
    sum += Number(cost);
  }

  document.getElementById('sum').textContent = sum;
}