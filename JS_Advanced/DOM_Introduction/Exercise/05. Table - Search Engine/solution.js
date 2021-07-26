function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let tableBodyElements = Array.from(document.querySelectorAll('.container tbody tr'));
      let searchTextInput = document.querySelector('#searchField');
      let searchText = searchTextInput.value;


      tableBodyElements.forEach(row => {
           row.classList.remove('select');
           console.log(row);
      });

      for(let tableRow of tableBodyElements) {
         if(tableRow.textContent.includes(searchText) && searchText !== '') {
            tableRow.classList.add('select');
         }
      }

      searchTextInput.value = '';
   }
}