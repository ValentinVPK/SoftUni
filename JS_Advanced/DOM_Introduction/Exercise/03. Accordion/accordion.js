function toggle() {
    let moreButtonElement = document.querySelector('.button');
    let extraDivElement = document.querySelector('#extra');

    if(moreButtonElement.textContent === 'More') {
        extraDivElement.style.display = 'block';
        moreButtonElement.textContent = 'Less';
    } else {
        extraDivElement.style.display = 'none';
        moreButtonElement.textContent = 'More';
    }
}