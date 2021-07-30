function solve() {
  let textAreaElements = document.querySelectorAll('#exercise textarea');
  let buttonsElements = document.querySelectorAll('#exercise button');

  let tableBodyElement = document.querySelector('.table tbody');

  buttonsElements[0].addEventListener('click', (e) => {
    let inputArray = JSON.parse(textAreaElements[0].value);
    
    inputArray.forEach(obj => {
      let newRow = document.createElement('tr');
      
      let firstTd = document.createElement('td');
      let image = document.createElement('img');
      image.setAttribute('src', `${obj['img']}`);

      firstTd.appendChild(image);
      newRow.appendChild(firstTd);

      let secondTd = document.createElement('td');
      let secondPara = document.createElement('p');
      secondPara.textContent = obj['name'];
      secondTd.appendChild(secondPara);
      newRow.appendChild(secondTd);

      let thirdTd = document.createElement('td');
      let thirdPara = document.createElement('p');
      thirdPara.textContent = obj['price'];
      thirdTd.appendChild(thirdPara);
      newRow.appendChild(thirdTd);


      let fourthTd = document.createElement('td');
      let fourthPara = document.createElement('p');
      fourthPara.textContent = obj['decFactor'];
      fourthTd.appendChild(fourthPara);
      newRow.appendChild(fourthTd);

      let fifthTd = document.createElement('td');
      let inputCheckBox = document.createElement('input');
      inputCheckBox.type = 'checkbox';
      
      fifthTd.appendChild(inputCheckBox);
      newRow.appendChild(fifthTd);
      
      tableBodyElement.appendChild(newRow);
    });
  });


  buttonsElements[1].addEventListener('click', (e) => {
    textAreaElements[1].textContent = '';
    let checkedRowsElements = Array.from(tableBodyElement.querySelectorAll('tr'));

    let names = [];
    let totalPrice = 0;
    let sumFactors = 0;
    let checkedAmount = 0;
    checkedRowsElements.forEach(x => {
      let checkedTdElements = x.children;
      
      if(checkedTdElements[4].children[0].checked === true) {
        
        names.push(checkedTdElements[1].children[0].textContent);
        totalPrice += Number(checkedTdElements[2].children[0].textContent);
        sumFactors += Number(checkedTdElements[3].children[0].textContent);
        checkedAmount++;
      }
    });

    textAreaElements[1].textContent += `Bought furniture: ${names.join(', ')}\n`
    textAreaElements[1].textContent += `Total price: ${totalPrice.toFixed(2)}\n`;
    textAreaElements[1].textContent += `Average decoration factor: ${sumFactors / checkedAmount}`;
  });
}