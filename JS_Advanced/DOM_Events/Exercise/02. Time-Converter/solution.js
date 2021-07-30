function attachEventsListeners() {
    let daysButtonElement = document.querySelector('#daysBtn');
    let hoursButtonElement = document.querySelector('#hoursBtn');
    let minutesButtonElement = document.querySelector('#minutesBtn');
    let secondsButtonElement = document.querySelector('#secondsBtn');

    let daysInputElement = document.querySelector('#days');
    let hoursInputElement = document.querySelector('#hours');
    let minutesInputElement = document.querySelector('#minutes');
    let secondsInputElement = document.querySelector('#seconds');

    daysButtonElement.addEventListener('click', (e) => {
        let days = Number(daysInputElement.value);

        hoursInputElement.value = days * 24;
        minutesInputElement.value = days * 1440;
        secondsInputElement.value = days * 86400; 
    });   

    hoursButtonElement.addEventListener('click', (e) => {
        let hours = Number(hoursInputElement.value);

        daysInputElement.value = hours / 24;
        minutesInputElement.value = hours * 60;
        secondsInputElement.value = hours * 3600; 
    });   

    minutesButtonElement.addEventListener('click', (e) => {
        let minutes = Number(minutesInputElement.value);

        daysInputElement.value = minutes / 1440;
        hoursInputElement.value = minutes / 60;
        secondsInputElement.value = minutes * 60; 
    }); 

    secondsButtonElement.addEventListener('click', (e) => {
        let seconds = Number(secondsInputElement.value);

        daysInputElement.value = seconds / 86400;
        hoursInputElement.value = seconds / 1440;
        minutesInputElement.value = seconds / 60; 
    }); 
}