function search() {
   let lisInTownsUl = document.querySelectorAll('#towns li');
   let match = document.querySelector('#searchText').value;
   let matchCount = 0;
   
   for(let li of lisInTownsUl) {
      if(li.textContent.includes(match)) {
         li.style.fontWeight = 'bold';
         li.style.textDecoration = 'underline';
         matchCount++;
      }
   }

   document.getElementById('result').textContent = matchCount + ' matches found';
}
