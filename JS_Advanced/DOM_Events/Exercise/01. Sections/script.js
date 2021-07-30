function create(words) {
   let contentDivElement = document.querySelector('#content');

   words.forEach(w => {
      let newDivElement = document.createElement('div');

      let newParagraphElement = document.createElement('p');
      newParagraphElement.textContent = w;
      newParagraphElement.style.display = 'none';

      newDivElement.appendChild(newParagraphElement);
      newDivElement.addEventListener('click', (e) => {
         e.currentTarget.children[0].style.display = 'block';
      });

      contentDivElement.appendChild(newDivElement);
   });
}