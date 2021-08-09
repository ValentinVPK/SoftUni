function solve() {
    let addButtonElement = document.querySelector('.form-control button');

    addButtonElement.addEventListener('click', addLecture);

    let modules = {};
    function addLecture(e) {
        e.preventDefault();

        let inputElements = e.currentTarget.parentNode.parentNode.querySelectorAll('.form-control input');

        let lectureName = inputElements[0].value;
        let date = inputElements[1].value;

        let selectElement = e.currentTarget.parentNode.parentNode.querySelector('.form-control select');
        let module = selectElement.value.toUpperCase() + '-MODULE';

        if(lectureName === '' || date === '' || module === 'Select module') {
            return;
        }

        //Checking if module already exists:
        let moduleExists = document.querySelector(`#${module}`) !== null;

        // Creating the new li
        let liElement = document.createElement('li');
        liElement.setAttribute('class', 'flex');

        let h4Element = document.createElement('h4');
        h4Element.textContent = `${lectureName} - ${date.slice(0,4)}/${date.slice(5,7)}/${date.slice(8,10)} - ${date.slice(11)}`;

        let deleteButtonElement = document.createElement('button');
        deleteButtonElement.setAttribute('class', 'red');
        deleteButtonElement.textContent = 'Del';

        deleteButtonElement.addEventListener('click', deleteLecture);

        liElement.appendChild(h4Element);
        liElement.appendChild(deleteButtonElement);

        if(moduleExists) {
            modules[module][date] = liElement;
            let currentUlElement = document.querySelector(`#${module} ul`);

            let currentLiElements = Array.from(currentUlElement.querySelectorAll('li'));
            for (const li of currentLiElements) {
                li.remove();
            }

            for (const currentDate of Object.keys(modules[module]).sort((a,b)=> a.localeCompare(b))) {
                currentUlElement.appendChild(modules[module][currentDate]);
            }
            
        } else {
            //Creating the new div:

            modules[module] = {};
            modules[module][date] = liElement;
            let moduleDivElement = document.createElement('div');
            moduleDivElement.setAttribute('class', 'module');
            moduleDivElement.setAttribute('id', `${module}`);

            let h3Element = document.createElement('h3');
            h3Element.textContent = module;

            let ulElement = document.createElement('ul');
            ulElement.appendChild(liElement);
            
            moduleDivElement.appendChild(h3Element);
            moduleDivElement.appendChild(ulElement);

            document.querySelector('.modules').appendChild(moduleDivElement);
        }
    }

    function deleteLecture(e) {
        let currObj = e.currentTarget.parentNode;
        let emptyModule = '';
        let divModuleObject = undefined;
        for (const module in modules) {

            for (const date in modules[module]) {
                if(modules[module][date] === currObj) {
                    delete modules[module][date];
                    divModuleObject = e.currentTarget.parentNode.parentNode.parentNode;
                    currObj.remove();
                }
            }
            if(Object.keys(modules[module]).length === 0){
                emptyModule = module;
            }
        }

        if(emptyModule !== '') {
            delete modules[emptyModule];
            divModuleObject.remove();
        }
    }
}