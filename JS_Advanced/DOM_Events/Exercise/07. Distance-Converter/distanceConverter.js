function attachEventsListeners() {
    let buttonElement = document.querySelector('#convert');

    buttonElement.addEventListener('click', () => {
        let inputDistance = document.querySelector('#inputDistance').value;
        inputDistance = Number(inputDistance);

        let from = document.querySelector('#inputUnits').value;
        let to = document.querySelector('#outputUnits').value;

        let toOutputElement = document.querySelector('#outputDistance');
        toOutputElement.value = convertDistance(from, to, inputDistance);
    });


    function convertDistance(from, to, distance) {
        const distanceInMeters = {
            'km': 1000,
            'm': 1,
            'cm': 0.01,
            'mm': 0.001,
            'mi': 1609.34,
            'yrd': 0.9144,
            'ft': 0.3048,
            'in': 0.0254
        }

        let meters = distanceInMeters[from] * distance;
        return meters / distanceInMeters[to];
    }
}