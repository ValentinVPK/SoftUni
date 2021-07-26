function solve() {

  let textAreaElement = document.querySelector('#input');
  let outputDivElement = document.querySelector('#output');

  let sentences = textAreaElement.value.split('.').filter(x => x !== '');
  
  let text = '';
  
  for(let i = 0; i < sentences.length; i++) {
    
    text += sentences[i] + '.';

    if((i + 1) % 3 === 0 || i === sentences.length - 1) {
      
      outputDivElement.innerHTML += `<p>${text}</p>`;
      text = '';
    }
  }
}