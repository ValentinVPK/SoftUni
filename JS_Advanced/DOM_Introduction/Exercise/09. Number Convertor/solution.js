function solve() {
    document.querySelector('#selectMenuTo option').value = 'binary';
    document.querySelector('#selectMenuTo option').textContent = 'Binary';

    document.querySelector('#selectMenuTo').innerHTML += '<option selected value="hexadecimal">Hexadecimal</option>';
    
    document.querySelector('#container button').addEventListener('click', onClick);
    
    function onClick() {
        let selectMenuToElement = document.querySelector('#selectMenuTo');

        let decimalNumber = Number(document.querySelector('#input').value);
        
        let result = '';
        if(selectMenuToElement.value === 'binary') {
            
            while(decimalNumber !== 0) {
                result += decimalNumber % 2;
                
                decimalNumber = Math.floor(decimalNumber / 2);
            }
        } else if(selectMenuToElement.value === 'hexadecimal') {
            const hexadecimalLetters = {
                10: 'A',
                11: 'B',
                12: 'C',
                13: 'D',
                14: 'E',
                15: 'F'
            };
            while(decimalNumber !== 0) {
                let remainder = decimalNumber % 16;

                if(remainder < 10) {
                    result += remainder;
                } else {
                    result += hexadecimalLetters[remainder];
                }
                
                decimalNumber = Math.floor(decimalNumber / 16);
            }
        }

        result = result.split('').reverse().join('');
        document.querySelector('#result').value = result;
    }
}