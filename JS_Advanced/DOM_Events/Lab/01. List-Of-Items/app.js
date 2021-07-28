function addItem() {
    let itemsListElement = document.querySelector('#items');
    let newTextInputElement = document.querySelector('#newItemText');

    let newItemElement = document.createElement('li');

    newItemElement.textContent = newTextInputElement.value;
    itemsListElement.appendChild(newItemElement);

    newTextInputElement.value = '';
}