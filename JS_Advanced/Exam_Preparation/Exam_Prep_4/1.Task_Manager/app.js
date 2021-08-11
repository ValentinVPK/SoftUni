function solve() {
    let sectionsElements = document.querySelectorAll('.wrapper section');
    let addButtonElement = document.querySelector('#add');

    addButtonElement.addEventListener('click', addTask);

    function addTask(e) {
        e.preventDefault();
        let taskInputElement = e.currentTarget.parentNode.querySelector('#task');
        let taskName = taskInputElement.value;

        let descriptionTextAreaElement = e.currentTarget.parentNode.querySelector('#description');
        let description = descriptionTextAreaElement.value;

        let dateInputElement = e.currentTarget.parentNode.querySelector('#date');
        let date = dateInputElement.value;

        if(taskName === '' || description === '' || date === '') {
            return;
        }

        taskInputElement.value = '';
        descriptionTextAreaElement.value = '';
        dateInputElement.value = '';

        // Creating the article:

        let articleElement = document.createElement('article');

        let h3Element = document.createElement('h3');
        h3Element.textContent = taskName;
        articleElement.appendChild(h3Element);

        let descriptionParagraphElement = document.createElement('p');
        descriptionParagraphElement.textContent = 'Description: ' + description;
        articleElement.appendChild(descriptionParagraphElement);

        let dateParagraphElement = document.createElement('p');
        dateParagraphElement.textContent = 'Due Date: ' + date;
        articleElement.appendChild(dateParagraphElement);

        let buttonsDivElement = document.createElement('div');
        buttonsDivElement.classList.add('flex');

        let startButtonElement = document.createElement('button');
        startButtonElement.classList.add('green');
        startButtonElement.textContent = 'Start';
        startButtonElement.addEventListener('click', startTask);

        let deleteButtonElement = document.createElement('button');
        deleteButtonElement.classList.add('red');
        deleteButtonElement.textContent = 'Delete';
        deleteButtonElement.addEventListener('click', deleteTask);

        buttonsDivElement.appendChild(startButtonElement);
        buttonsDivElement.appendChild(deleteButtonElement);

        articleElement.appendChild(buttonsDivElement);

        sectionsElements[1].querySelectorAll('div')[1].appendChild(articleElement);
    }


    function startTask(e) {
        let buttonsDivElement = e.currentTarget.parentNode;
        e.currentTarget.remove();

        let finishButtonElement = document.createElement('button');
        finishButtonElement.classList.add('orange');
        finishButtonElement.textContent = 'Finish';
        finishButtonElement.addEventListener('click', finishTask);

        buttonsDivElement.appendChild(finishButtonElement);

        sectionsElements[2].querySelector('#in-progress').appendChild(buttonsDivElement.parentNode);
    }

    function deleteTask(e) {
        e.currentTarget.parentNode.parentNode.remove();
    }

    function finishTask(e) {
        let sectionElement = e.currentTarget.parentNode.parentNode;
        e.currentTarget.parentNode.remove();

        sectionsElements[3].querySelectorAll('div')[1].appendChild(sectionElement);
    }
}