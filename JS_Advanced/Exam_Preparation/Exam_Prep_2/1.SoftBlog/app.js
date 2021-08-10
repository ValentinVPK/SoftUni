function solve(){
   //get the button

   let createButttonElement = document.querySelector('form button');
   createButttonElement.addEventListener('click', postArticle);

   const titlesArray = [];

   function postArticle(e) {
      e.preventDefault();
      // select inputs with information

      let formElement = e.currentTarget.parentNode;

      let author = formElement.querySelector('#creator').value;
      let title = formElement.querySelector('#title').value;
      let category = formElement.querySelector('#category').value;
      let content = formElement.querySelector('#content').value;

      // Creating the article
      let articleElement = document.createElement('article');

      let h1Element = document.createElement('h1');
      h1Element.textContent = title;
      articleElement.appendChild(h1Element);

      let categoryParagraphElement = document.createElement('p');
      categoryParagraphElement.textContent = 'Category:';
      let strongCategoryElement = document.createElement('strong');
      strongCategoryElement.textContent = category;
      categoryParagraphElement.appendChild(strongCategoryElement);
      articleElement.appendChild(categoryParagraphElement);


      let creatorParagraphElement = document.createElement('p');
      creatorParagraphElement.textContent = 'Creator:';
      let strongCreatorElement = document.createElement('strong');
      strongCreatorElement.textContent = author;
      creatorParagraphElement.appendChild(strongCreatorElement);
      articleElement.appendChild(creatorParagraphElement);

      let contentParagraphElement = document.createElement('p');
      contentParagraphElement.textContent = content;
      articleElement.appendChild(contentParagraphElement);

      let buttonsDivElement = document.createElement('div');
      buttonsDivElement.setAttribute('class', 'buttons');

      let deleteButtonElement = document.createElement('button');
      deleteButtonElement.textContent = 'Delete';
      deleteButtonElement.classList.add('btn');
      deleteButtonElement.classList.add('delete');
      deleteButtonElement.addEventListener('click', deletePost);

      let archiveButtonElement = document.createElement('button');
      archiveButtonElement.textContent = 'Archive';
      archiveButtonElement.classList.add('btn');
      archiveButtonElement.classList.add('archive');
      archiveButtonElement.addEventListener('click', archivePost);
      
      buttonsDivElement.appendChild(deleteButtonElement);
      buttonsDivElement.appendChild(archiveButtonElement);
      articleElement.appendChild(buttonsDivElement);

      let mainSectionElement = document.querySelector('.site-content section');
      mainSectionElement.appendChild(articleElement);

      
   }

   function deletePost(e) {
      e.currentTarget.parentNode.parentNode.remove();
   }

   function archivePost(e) {
      let currentTitle = e.currentTarget.parentNode.parentNode.querySelector('h1').textContent;
      titlesArray.push(currentTitle);

      let olElement = document.querySelector('.archive-section ol');
      let liElements = Array.from(document.querySelectorAll('.archive-section ol li'));

      liElements.forEach(x => x.remove());

      titlesArray.sort((a,b) =>a.localeCompare(b));

      titlesArray.forEach(el => {
         let currentLi = document.createElement('li');
         currentLi.textContent = el;
         olElement.appendChild(currentLi);
      });

      e.currentTarget.parentNode.parentNode.remove();
   }
}
