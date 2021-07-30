function solve() {
    let buttonElements = document.querySelectorAll('button');

    buttonElements[0].addEventListener('click', isOver);
    buttonElements[1].addEventListener('click', clear);
   
    function isOver() {
        let matrix = [];

        let trowsElements = document.querySelectorAll('#exercise tbody tr');

        for(let row of trowsElements) {
            let rowArray = [];
            let columns = Array.from(row.children);

            columns.forEach(col => {
                rowArray.push(Number(col.children[0].value))
            });

            matrix.push(rowArray);
        }

        let solved = isSolved(matrix);

        let tableElement = document.querySelector('#exercise table');
        let checkParagraphElement = document.querySelector('#check p');
        if(solved) {
            tableElement.style.border = '2px solid green';
            checkParagraphElement.textContent = 'You solve it! Congratulations!';
            checkParagraphElement.style.color = 'green';
        } else {
            tableElement.style.border = '2px solid red';
            checkParagraphElement.textContent = 'NOP! You are not done yet...';
            checkParagraphElement.style.color = 'red';
        }


        function isSolved(inputMatrix) {
            for(let row of inputMatrix) {
                if(!(row.includes(1) && row.includes(2) && row.includes(3))) {
                    return false;
                } 
            }

            for (let col = 0; col < inputMatrix.length; col++) {
                let currCol = [];
                for (let row = 0; row < inputMatrix.length; row++) {
                    currCol.push(inputMatrix[row][col]);   
                }

                if(!(currCol.includes(1) && currCol.includes(2) && currCol.includes(3))) {
                    return false;
                } 
            }

            return true;
        }
    }

    function clear() {
        let tableElement = document.querySelector('#exercise table');
        let checkParagraphElement = document.querySelector('#check p');

        tableElement.style.border = '';
        checkParagraphElement.textContent = '';

        let trowsElements = Array.from(document.querySelectorAll('#exercise tbody tr'));

        trowsElements.forEach(row => {
            let columns = Array.from(row.children);
            columns.forEach(col => {
                col.children[0].value = '';
            });
        });
    }
}