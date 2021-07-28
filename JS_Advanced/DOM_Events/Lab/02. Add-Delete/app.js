function addItem() {
    let itemsListElement = document.querySelector('#items');
    let newTextInputElement = document.querySelector('#newItemText');
    
    let newItemElement = document.createElement('li');
    
    newItemElement.textContent = newTextInputElement.value;
    
    //Add delete button: 
    let deleteAnchor = document.createElement('a');
    deleteAnchor.setAttribute('href', '#');
    deleteAnchor.textContent = '[Delete]';
    deleteAnchor.addEventListener('click', (e) => {
        e.currentTarget.parentNode.remove();
    });


    newItemElement.appendChild(deleteAnchor);

    itemsListElement.appendChild(newItemElement);
    newTextInputElement.value = '';
}