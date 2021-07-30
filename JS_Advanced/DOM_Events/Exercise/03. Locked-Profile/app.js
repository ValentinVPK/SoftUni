function lockedProfile() {
    let profiles = document.querySelectorAll('#main .profile');

    let buttons = document.querySelectorAll('#main .profile button');

    for(let i = 0; i < buttons.length; i++) {
        buttons[i].addEventListener('click', (e) => {
            let radioButton = profiles[i].querySelector(`input[name="user${i + 1}Locked"]:checked`);

            if(radioButton.value === 'unlock') {
                let hiddenDivElement = document.querySelector(`#user${i + 1}HiddenFields`);

                hiddenDivElement.style.display = hiddenDivElement.style.display === 'block'
                    ? 'none'
                    : 'block';

                e.currentTarget.textContent = e.currentTarget.textContent === 'Show more'
                    ? 'Hide It'
                    : 'Show more';
            }
        });
    }
}