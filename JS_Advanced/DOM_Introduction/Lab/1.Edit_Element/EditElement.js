function editElement(htmlObject, textToReplace, replacement) {
    const content = htmlObject.textContent;
    const matcher = new RegExp(textToReplace, 'g');
    const edited = content.replace(matcher, replacement);
    htmlObject.textContent = edited;
}