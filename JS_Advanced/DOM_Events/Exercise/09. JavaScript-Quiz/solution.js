function solve() {
  let rightAnswers = ['onclick', 'JSON.stringify()', 'A programming API for HTML and XML documents'];
  let rightAnswersCount = 0;
  
  let allSectionsElements = document.querySelectorAll('#quizzie section');
  let allButtonElements = document.querySelectorAll('.answer-text');
  
  let sectionIndex = 0;
  for (let i = 0; i < allButtonElements.length; i++) {
    if(i === allButtonElements.length - 2 || i === allButtonElements.length - 1) {
      allButtonElements[i].addEventListener('click', (e) => {
        if(rightAnswers.includes(e.currentTarget.textContent)) {
          rightAnswersCount++;
        }

        allSectionsElements[sectionIndex].style.display = 'none';
        let resultDivElement = document.querySelector('#results');
        resultDivElement.style.display = 'block';
        if(rightAnswersCount === rightAnswers.length) {
          resultDivElement.querySelector('.results-inner h1').textContent = 'You are recognized as top JavaScript fan!';
        } else {
          resultDivElement.querySelector('.results-inner h1').textContent = `You have ${rightAnswersCount} right answers`;
        }
      });
    } else {
      allButtonElements[i].addEventListener('click', (e) => {
        if(rightAnswers.includes(e.currentTarget.textContent)) {
            rightAnswersCount++;
        } 
        allSectionsElements[sectionIndex++].style.display = 'none';
        allSectionsElements[sectionIndex].style.display = 'block';
      });
    }
  }
}
