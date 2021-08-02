
function printDeckOfCards(cards) {
  let resultStr = '';

  for (const x of cards) {
    let face = '';
    let suit = '';
     try {
      if(x.length === 3) {
        face = x[0] + x[1];
        suit = x[2];
      } else if(x.length === 2){
        face = x[0];
        suit = x[1];
      }

      resultStr += createCard(face, suit).toString() + ' ';
    } catch (error) {
      resultStr = `Invalid card: ${face}${suit}`;
      break;
    }
  }
  

  console.log(resultStr);

  function createCard(face, suit) {
    const faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J','Q', 'K', 'A'];
    const suits = {
      S: '\u2660 ',
      H: '\u2665 ',
      D: '\u2666 ',
      C: '\u2663 '
    };
  
    if(!faces.includes(face) || !(suits.hasOwnProperty(suit))) {
      throw new Error();
    }
  
    return {
      face,
      suit,
      toString() {
        return `${this.face}${suits[this.suit]}`;
      }
    }
  }
}


printDeckOfCards(['AS', '10D', 'KH', '2C']);