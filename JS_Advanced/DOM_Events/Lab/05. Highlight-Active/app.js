function focused() {
    let inputElements = Array.from(document.querySelectorAll('body div div input'));

    inputElements.forEach(x => {
        x.addEventListener('focus', focusIn);
    });

    inputElements.forEach(x => {
        x.addEventListener('blur', focusOut);
    });

    function focusIn(e) {
        e.currentTarget.parentNode.classList.add('focused');
    }

    function focusOut(e) {
        e.currentTarget.parentNode.classList.remove('focused');
    }
}