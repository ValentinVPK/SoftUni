window.addEventListener('load', solve);

function solve() {
    let addButtonElement = document.querySelector('#add');

    addButtonElement.addEventListener('click', addFurniture);

    
    function addFurniture(e) {
        e.preventDefault();

        let modelInputElement = e.currentTarget.parentNode.querySelector('#model');
        let model = modelInputElement.value;

        let yearInputElement = e.currentTarget.parentNode.querySelector('#year');
        let year = Number(yearInputElement.value);

        let descriptionTextAreaElement = e.currentTarget.parentNode.querySelector('#description');
        let description = descriptionTextAreaElement.value;

        let priceInputElement = e.currentTarget.parentNode.querySelector('#price');
        let price = Number(priceInputElement.value);

        if(model === '' || description === '' || yearInputElement.value === '' || priceInputElement.value === ''
        || year <= 0|| price <= 0) {
            // could be wrong
            return;
        }

        modelInputElement.value = '';
        yearInputElement.value = '';
        descriptionTextAreaElement.value = '';
        priceInputElement.value = '';

        //Creating the new row
        let parentTbodyElement = document.querySelector('#furniture-list');

        let infoTrElement = document.createElement('tr');
        infoTrElement.classList.add('info');

        let modelTdElement = document.createElement('td');
        modelTdElement.textContent = model;
        infoTrElement.appendChild(modelTdElement);

        let priceTdElement = document.createElement('td');
        priceTdElement.textContent = price.toFixed(2);
        infoTrElement.appendChild(priceTdElement);

        let buttonsTdElement = document.createElement('td');

        let moreInfoButtonElement = document.createElement('button');
        moreInfoButtonElement.classList.add('moreBtn');
        moreInfoButtonElement.textContent = 'More Info';
        moreInfoButtonElement.addEventListener('click', showMoreInfo);
        buttonsTdElement.appendChild(moreInfoButtonElement);

        let buyButtonElement = document.createElement('button');
        buyButtonElement.classList.add('buyBtn');
        buyButtonElement.textContent = 'Buy it';
        buyButtonElement.addEventListener('click', buyFurniture);
        buttonsTdElement.appendChild(buyButtonElement);

        infoTrElement.appendChild(buttonsTdElement);

        parentTbodyElement.appendChild(infoTrElement);

        let hiddenTrElement = document.createElement('tr');
        hiddenTrElement.classList.add('hide');

        let yearTdElement = document.createElement('td');
        yearTdElement.textContent = `Year: ${year}`;
        hiddenTrElement.appendChild(yearTdElement);

        let descriptionTdElement = document.createElement('td');
        descriptionTdElement.setAttribute('colspan', '3'); // could be a number
        descriptionTdElement.textContent = `Description: ${description}`;

        hiddenTrElement.appendChild(descriptionTdElement);

        parentTbodyElement.appendChild(hiddenTrElement);
    }

    function showMoreInfo(e) {
        let allTrsElements = Array.from(e.currentTarget.parentNode.parentNode.parentNode.children);

        let infoTrElement = e.currentTarget.parentNode.parentNode;

        let index = allTrsElements.indexOf(infoTrElement);
        let hiddenTrElement = allTrsElements[index + 1];

        let buttonText = e.currentTarget.textContent;
        if(buttonText === 'More Info') {
            e.currentTarget.textContent = 'Less Info';
            hiddenTrElement.style.display = 'contents';
        } else {
            e.currentTarget.textContent = 'More Info';
            hiddenTrElement.style.display = 'none';
        }
    }

    function buyFurniture(e) {
        let allTrsElements = Array.from(e.currentTarget.parentNode.parentNode.parentNode.children);
        let infoTrElement = e.currentTarget.parentNode.parentNode;
        let index = allTrsElements.indexOf(infoTrElement);
        let hiddenTrElement = allTrsElements[index + 1];

        let price = Number(infoTrElement.children[1].textContent);

        let totalPriceTdElement = document.querySelector('.total-price');
        let currentPrice = Number(totalPriceTdElement.textContent);

        currentPrice += price;

        totalPriceTdElement.textContent = currentPrice.toFixed(2);

        infoTrElement.remove();
        hiddenTrElement.remove();
    }
}
