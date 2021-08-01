function solve() {
    let onscreenButtonElement = document.querySelector('#container button');
    onscreenButtonElement.addEventListener('click', addToScreen);

    let clearArchiveButtonElement = document.querySelector('#archive button');
    clearArchiveButtonElement.addEventListener('click', (e) => {
        let liElements = Array.from(e.currentTarget.parentNode.querySelectorAll('ul li'));
        liElements.forEach(element => element.remove());
    });

    function addToScreen(e) {
        e.preventDefault();
        let inputElements = document.querySelectorAll('#container input');
        let name = inputElements[0].value;
        let hall = inputElements[1].value;
        let price = inputElements[2].value;
        if(name.trim() === '' || hall.trim() === '' || price.trim() === '' || isNaN(price)) {
            return;
        }

        price = Number(price);
        let liElement = document.createElement('li');

        let spanElement = document.createElement('span');
        spanElement.textContent = name;

        let strongElement = document.createElement('strong');
        strongElement.textContent = `Hall: ${hall}`;

        let divElement = document.createElement('div');

        let strongDivChildElement = document.createElement('strong');
        strongDivChildElement.textContent = price.toFixed(2);

        let inputDivChildElement = document.createElement('input');
        inputDivChildElement.setAttribute('placeholder', 'Tickets Sold');

        let buttonDivChildElement = document.createElement('button');
        buttonDivChildElement.textContent = 'Archive';
        buttonDivChildElement.addEventListener('click', archiveMovie);

        // append all the elements to the ul

        let ulElement = document.querySelector('#movies ul');
        
        liElement.appendChild(spanElement);
        liElement.appendChild(strongElement);
        
        divElement.appendChild(strongDivChildElement);
        divElement.appendChild(inputDivChildElement);
        divElement.appendChild(buttonDivChildElement);

        liElement.appendChild(divElement);

        ulElement.appendChild(liElement);

        //Delete input
        inputElements[0].value = '';
        inputElements[1].value = '';
        inputElements[2].value = '';
    }

    function archiveMovie(e) {
        let movieLiElement = e.currentTarget.parentNode.parentNode;

        let ticketsAmount = movieLiElement.querySelector('div input').value;
        if(ticketsAmount === '' || isNaN(ticketsAmount)) {
            return;
        }

        ticketsAmount = Number(ticketsAmount);

        let pricePerTicket = Number(movieLiElement.querySelector('div strong').textContent);
        console.log(pricePerTicket);

        let totalPrice = ticketsAmount * pricePerTicket;

        movieLiElement.querySelector('strong').textContent = `Total amount: ${totalPrice.toFixed(2)}`;

        let divElement = movieLiElement.querySelector('div');
        divElement.remove();

        let deleteButtonElement = document.createElement('button');
        deleteButtonElement.textContent = 'Delete';
        deleteButtonElement.addEventListener('click', (e) => {
            e.currentTarget.parentNode.remove();
        });

        movieLiElement.appendChild(deleteButtonElement);

        let archiveUlElement = document.querySelector('#archive ul');
        archiveUlElement.appendChild(movieLiElement);
    }
}