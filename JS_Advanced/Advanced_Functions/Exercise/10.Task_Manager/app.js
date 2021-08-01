function solve() {
    let sectionsElements = document.querySelectorAll('.wrapper section');

    let addButtonElement = document.querySelector('#add');
    addButtonElement.addEventListener('click', addTask);

    function addTask(e) {
        e.preventDefault();

        let taskInputElement = e.currentTarget.parentNode.querySelector('#task');
        let descriptionTextAreaElement = e.currentTarget.parentNode.querySelector('#description');
        let dateInputElement = e.currentTarget.parentNode.querySelector('#date');

        let task = taskInputElement.value;
        let description = descriptionTextAreaElement.value;
        let date = dateInputElement.value;

        if(task === '' || description === '' || date === '') {
            return;
        }

        // create the new div
        let articleElement = document.createElement('article');

        let h3ChildElement = document.createElement('h3');
        h3ChildElement.textContent = task;

        let descriptionParagraphChildElement = document.createElement('p');
        descriptionParagraphChildElement.textContent = `Description: ${description}`;

        let dateParagraphChildElement = document.createElement('p');
        dateParagraphChildElement.textContent = `Due Date: ${date}`;

        let divChildElement = document.createElement('div');
        divChildElement.setAttribute('class', 'flex');

        let startButtonElement = document.createElement('button');
        startButtonElement.textContent = 'Start';
        startButtonElement.setAttribute('class', 'green');
        startButtonElement.addEventListener('click', startTask);
            

        let deleteButtonElement = document.createElement('button');
        deleteButtonElement.textContent = 'Delete';
        deleteButtonElement.setAttribute('class', 'red');
        deleteButtonElement.addEventListener('click', deleteTask);

        divChildElement.appendChild(startButtonElement);
        divChildElement.appendChild(deleteButtonElement);

        let divParentElement = sectionsElements[1].querySelectorAll('div')[1];

        articleElement.appendChild(h3ChildElement);
        articleElement.appendChild(descriptionParagraphChildElement);
        articleElement.appendChild(dateParagraphChildElement);
        articleElement.appendChild(divChildElement);

        divParentElement.appendChild(articleElement);

        taskInputElement.value = '';
        descriptionTextAreaElement.value = '';
        dateInputElement.value = '';
    }


    function startTask(e) {
        let divParentElement = e.currentTarget.parentNode;
        let articleElement = divParentElement.parentNode;
        let buttonsToDelete = Array.from(divParentElement.querySelectorAll('button'));
        
        buttonsToDelete.forEach(button => button.remove());

        let newDeleteButton = document.createElement('button');
        newDeleteButton.textContent = 'Delete';
        newDeleteButton.setAttribute('class', 'red');
        newDeleteButton.addEventListener('click', deleteTask);

        let finishButton = document.createElement('button');
        finishButton.textContent = 'Finish';
        finishButton.setAttribute('class', 'orange');
        finishButton.addEventListener('click', finishTask);

        divParentElement.appendChild(newDeleteButton);
        divParentElement.appendChild(finishButton);

        sectionsElements[2].querySelector('#in-progress').appendChild(articleElement);
    }

    function deleteTask(e) {
        e.currentTarget.parentNode.parentNode.remove();
    }

    function finishTask(e) {
        let currArticleElement = e.currentTarget.parentNode.parentNode;

        let divElement = e.currentTarget.parentNode;
        divElement.remove();

        sectionsElements[3].querySelectorAll('div')[1].appendChild(currArticleElement);
    }
}