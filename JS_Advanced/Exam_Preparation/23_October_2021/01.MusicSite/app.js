window.addEventListener('load', solve);

function solve() {
    let addButtonElement = document.querySelector('#add-btn');
    addButtonElement.addEventListener('click', addSong);

    let genreInputElement = document.querySelector('#genre');
    let nameInputElement = document.querySelector('#name');
    let authorInputElement = document.querySelector('#author');
    let dateInputElelement = document.querySelector('#date');

    let infoDivElement = document.querySelector('#all-hits div');

    function addSong(e) {
        e.preventDefault();

        let genre = genreInputElement.value;
        let name = nameInputElement.value;
        let author = authorInputElement.value;
        let date = dateInputElelement.value;
        
        if(genre === '' || name === '' || author === '' || date === '') {
            return;
        }

        genreInputElement.value = '';
        nameInputElement.value = '';
        authorInputElement.value = '';
        dateInputElelement.value = '';

        //creating the div element

        let parentDivElement = document.createElement('div');
        parentDivElement.classList.add('hits-info');

        let imgElement = document.createElement('img');
        imgElement.setAttribute('src', './static/img/img.png');

        let genreHeadingElement = document.createElement('h2');
        genreHeadingElement.textContent = `Genre: ${genre}`;

        let nameHeadingElement = document.createElement('h2');
        nameHeadingElement.textContent = `Name: ${name}`;

        let authorHeadingElement = document.createElement('h2');
        authorHeadingElement.textContent = `Author: ${author}`;

        let dateHeadingElement = document.createElement('h3');
        dateHeadingElement.textContent = `Date: ${date}`;

        let saveButtonElement = document.createElement('button');
        saveButtonElement.classList.add('save-btn');
        saveButtonElement.textContent = 'Save song';
        saveButtonElement.addEventListener('click', saveSong);

        let likeButtonElement = document.createElement('button');
        likeButtonElement.classList.add('like-btn');
        likeButtonElement.textContent = 'Like song';
        likeButtonElement.addEventListener('click', likeSong);

        let deleteButtonElement = document.createElement('button');
        deleteButtonElement.classList.add('delete-btn');
        deleteButtonElement.textContent = 'Delete';
        deleteButtonElement.addEventListener('click', deleteSong);

        parentDivElement.appendChild(imgElement);
        parentDivElement.appendChild(genreHeadingElement);
        parentDivElement.appendChild(nameHeadingElement);
        parentDivElement.appendChild(authorHeadingElement);
        parentDivElement.appendChild(dateHeadingElement);
        parentDivElement.appendChild(saveButtonElement);
        parentDivElement.appendChild(likeButtonElement);
        parentDivElement.appendChild(deleteButtonElement);

        infoDivElement.appendChild(parentDivElement);
    }

    function saveSong(e) {
        let divParentElement = e.currentTarget.parentNode;

        divParentElement.querySelector('.save-btn').remove();
        divParentElement.querySelector('.like-btn').remove();

        divParentElement.remove();

        let savedSongsDivElement = document.querySelector('#saved-hits div');
        savedSongsDivElement.appendChild(divParentElement);
    }

    function likeSong(e) {
        e.currentTarget.disabled = true;
        let likesParagraphElement = document.querySelector('#total-likes div p');

        let likes = likesParagraphElement.textContent.match(/\d+/g)[0];
        
        likes++;

        likesParagraphElement.textContent = `Total Likes: ${likes}`;
    }

    function deleteSong(e) {
        e.currentTarget.parentNode.remove();
    }
}