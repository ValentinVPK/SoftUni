function solution() {
    let cardSectionUlElements = document.querySelectorAll('.card ul');

    let addButtonElement = document.querySelector('.card div button');

    addButtonElement.addEventListener('click', addGift);

    const giftObject = {};
    function addGift(e) {
        let giftName = e.currentTarget.parentNode.querySelector('input').value;
        e.currentTarget.parentNode.querySelector('input').value = '';

        let ulElement = cardSectionUlElements[0];
        // Create li element
        let liElement = document.createElement('li');
        liElement.classList.add('gift');
        liElement.textContent = giftName;

        let sendButtonElement = document.createElement('button');
        sendButtonElement.setAttribute('id', 'sendButton');
        sendButtonElement.textContent = 'Send';
        sendButtonElement.addEventListener('click', sendGift);

        let discardButtonElement = document.createElement('button');
        discardButtonElement.setAttribute('id', 'discardButton');
        discardButtonElement.textContent = 'Discard';
        discardButtonElement.addEventListener('click', discardGift);

        liElement.appendChild(sendButtonElement);
        liElement.appendChild(discardButtonElement);

        giftObject[giftName] = liElement;

        let currentIlElements = Array.from(ulElement.querySelectorAll('li'));
        currentIlElements.forEach(x => x.remove());

        for (const key of Object.keys(giftObject).sort((a,b) => a.localeCompare(b))) {
            ulElement.appendChild(giftObject[key]);
        }
    }

    function sendGift(e) {
        let liElement = e.currentTarget.parentNode;
        Array.from(liElement.querySelectorAll('button')).forEach(x => x.remove());
        let giftName = liElement.textContent;
        delete giftObject[giftName];
        liElement.remove();

        let newLiElement = document.createElement('li');
        newLiElement.classList.add('gift');
        newLiElement.textContent = giftName;

        cardSectionUlElements[1].appendChild(newLiElement);
    }

    function discardGift(e) {
        let liElement = e.currentTarget.parentNode;
        Array.from(liElement.querySelectorAll('button')).forEach(x => x.remove());
        let giftName = liElement.textContent;
        delete giftObject[giftName];
        liElement.remove();

        let newLiElement = document.createElement('li');
        newLiElement.classList.add('gift');
        newLiElement.textContent = giftName;

        cardSectionUlElements[2].appendChild(newLiElement);
    }
}