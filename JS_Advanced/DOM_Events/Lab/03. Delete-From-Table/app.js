function deleteByEmail() {
    let tableRowsElements = document.querySelectorAll('#customers tbody tr');

    let inputEmailTextElement = document.querySelector('input').value;
    document.querySelector('input').value = '';

    for(let row of tableRowsElements) {
        let currRowEmail = row.children[1].textContent;
        
        if(currRowEmail === inputEmailTextElement) {
            row.parentNode.removeChild(row);
            document.querySelector('#result').textContent = 'Deleted';
            return;
        }
    }

    document.querySelector('#result').textContent = 'Not found.';
}