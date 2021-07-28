function solve() {
   let addButtonElements = Array.from(document.querySelectorAll('.add-product'));
   let finalPrice = 0;
   let productArr = [];

   addButtonElements.forEach(x => {
      x.addEventListener('click', addProduct);
   });

   let checkoutButtonElement = document.querySelector('.checkout');
   checkoutButtonElement.addEventListener('click', (e) => {
      e.currentTarget.parentNode.querySelector('textarea').textContent += `You bought ${productArr.join(', ')} for ${finalPrice.toFixed(2)}.`;
      addButtonElements.forEach(x => x.disabled = true);
      e.currentTarget.disabled = true;
   });


   function addProduct(e) {
      let currentProductElement = e.currentTarget.parentNode.parentNode;

      let currProductName = currentProductElement.querySelector('.product-title').textContent;
      let currProductPrice = currentProductElement.querySelector('.product-line-price').textContent;
      finalPrice += Number(currProductPrice);

      if(!productArr.includes(currProductName)) {
         productArr.push(currProductName);
      }

      document.querySelector('textarea').textContent += `Added ${currProductName} for ${currProductPrice} to the cart.\n`;
   }
}