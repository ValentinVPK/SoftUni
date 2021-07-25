function extractText() {
    let listItems = document.querySelectorAll('#items li');

    let result = '';

    for(let liElement of listItems) {
        result += liElement.textContent + '\n';
    }

    let resultTextAreaElement = document.getElementById('result');
    resultTextAreaElement.textContent = result.trimEnd();
}