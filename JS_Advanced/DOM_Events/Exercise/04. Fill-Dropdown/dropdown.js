function addItem() {
    let inputText = document.querySelector('#newItemText').value;
    let inputValue = document.querySelector('#newItemValue').value;

    let inputButtonElement = document.querySelector('input[type="button"]');

    let newOption = document.createElement('option');
    newOption.textContent = inputText;
    newOption.value = inputValue;
    document.querySelector('#menu').appendChild(newOption);
    document.querySelector('#newItemText').value = '';
    document.querySelector('#newItemValue').value = '';       
}