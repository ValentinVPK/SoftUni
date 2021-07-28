function attachGradientEvents() {
    let gradientBoxElement = document.querySelector('#gradient-box');
    let resultElement = document.querySelector('result');

    gradientBoxElement.addEventListener('mousemove', gradiantMove);
    gradientBoxElement.addEventListener('mouseout', gradiantOut);

    function gradiantMove(e) {
        let power = e.offsetX / (e.target.clientWidth - 1);
        power = Math.trunc(power * 100);
        document.getElementById('result').textContent = power + "%";
    }


    function gradiantOut(e) {
        document.getElementById('result').textContent = '';
    }
}