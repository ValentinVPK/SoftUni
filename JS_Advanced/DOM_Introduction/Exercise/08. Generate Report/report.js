function generateReport() {
    const resultArr = [];

    let theadElements = document.querySelectorAll('thead tr th input');

    let trowsElements = document.querySelectorAll('tbody tr');

    for(let row of trowsElements) {

        const currObj = {};
        
        for(let col = 0; col < theadElements.length; col++) {
            if(theadElements[col].checked) {
                currObj[theadElements[col].name] = row.children[col].textContent;
            }
        }

        resultArr.push(currObj);
    }

    document.querySelector('#output').textContent = JSON.stringify(resultArr);
    
}