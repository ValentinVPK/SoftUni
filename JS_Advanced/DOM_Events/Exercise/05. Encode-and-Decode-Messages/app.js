function encodeAndDecodeMessages() {
    let textAreaElements = document.querySelectorAll('#main div textarea');
    let buttonsElements = document.querySelectorAll('#main div button');
    
    

    buttonsElements[0].addEventListener('click', (e) => {
        textAreaElements[1].value = '';

        let inputText = textAreaElements[0].value;
        
        inputText.split('').forEach(c => {
            textAreaElements[1].value += String.fromCharCode(c.charCodeAt() + 1);
        });

        textAreaElements[0].value = '';
    });

    buttonsElements[1].addEventListener('click', (e) => {
        let decodedText = textAreaElements[1].value;
        textAreaElements[1].value = '';


        decodedText.split('').forEach(c => {
            textAreaElements[1].value += String.fromCharCode(c.charCodeAt() - 1);
        });
    });
}