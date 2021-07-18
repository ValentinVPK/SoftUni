
function calculateTime(stepsAmount, footprintMeters, speed){
  let kms = (stepsAmount * footprintMeters) / 1000;
  let bonusMinutes = Math.floor(kms / 0.5);

  let totalSeconds = (kms / speed) * 3600 + bonusMinutes * 60;
  
  let hours = Math.floor((totalSeconds / 3600));
  let minutes = Math.floor((totalSeconds / 60));
  let seconds = (totalSeconds % 60).toFixed(0);

  console.log(`${hours.toString().padStart(2,'0')}:${minutes.toString().padStart(2,'0')}:${seconds.toString().padStart(2,'0')}`);
}

calculateTime(2564, 0.70, 5.5);