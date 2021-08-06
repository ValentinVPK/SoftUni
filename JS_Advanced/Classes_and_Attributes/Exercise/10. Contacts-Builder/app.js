
class Contact {
  constructor(firstName, lastName, phone, email) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.phone = phone;
    this.email = email;
    this._online = false;
    this.htmlElement = this.createElement();

  }

  createElement() {
    let articleElement = document.createElement('article');

    let titleDivElement = document.createElement('div');
    titleDivElement.setAttribute('class', 'title');
    titleDivElement.textContent = `${this.firstName} ${this.lastName}`;

    let buttonElement = document.createElement('button');
    buttonElement.textContent ='\u2139';
    buttonElement.addEventListener('click', (e) => {
      let infoDiv = e.currentTarget.parentNode.parentNode.querySelector('.info');
      infoDiv.style.display = infoDiv.style.display === 'none'
        ? 'block'
        : 'none';
    });

    titleDivElement.appendChild(buttonElement);


    let infoDivElement = document.createElement('div');
    infoDivElement.setAttribute('class', 'info');
    infoDivElement.style.display = 'none';

    let phoneSpanElement = document.createElement('span');
    phoneSpanElement.textContent = `\u260E ${this.phone}`;

    let emailSpanElement = document.createElement('span');
    emailSpanElement.textContent = `\u2709 ${this.email}`;

    infoDivElement.appendChild(phoneSpanElement);
    infoDivElement.appendChild(emailSpanElement);

    articleElement.appendChild(titleDivElement);
    articleElement.appendChild(infoDivElement);

    return articleElement;
  }

  render(id) {
    let parentElement = document.getElementById(id);

    parentElement.appendChild(this.htmlElement);
  }

  set online(value) {
    this._online = value;

     let titleDivElement = this.htmlElement.querySelector('.title');
     this._online === true
       ? titleDivElement.classList.add('online')
       : titleDivElement.classList.remove('online');
  }
}

function solve() {
  let contacts = [
    new Contact("Ivan", "Ivanov", "0888 123 456", "i.ivanov@gmail.com"),
    new Contact("Maria", "Petrova", "0899 987 654", "mar4eto@abv.bg"),
    new Contact("Jordan", "Kirov", "0988 456 789", "jordk@gmail.com")
  ];
  contacts.forEach(c => c.render('main'));
  setTimeout(() => contacts[1].online = true, 2000);
  contacts[0]._online = true;
}