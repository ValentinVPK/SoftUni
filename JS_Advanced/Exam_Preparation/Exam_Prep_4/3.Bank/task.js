class Bank {
  constructor(bankName) {
    this._bankName = bankName;
    this.allCustomers = [];
  }

  newCustomer(customer) {
    if(this.allCustomers.some(x => x.personalId === customer.personalId)) {
      throw new Error(`${customer.firstName} ${customer.lastName} is already our customer!`);
    }

    this.allCustomers.push(customer);

    return customer;
  }

  depositMoney(personalId, amount) {
    if(!this.allCustomers.some(x => x.personalId === personalId)) {
      throw new Error('We have no customer with this ID!');
    }

    let currentCustomer = this.allCustomers.find(x => x.personalId === personalId);

    if(!currentCustomer.hasOwnProperty('totalMoney')) {
      currentCustomer.totalMoney = 0;
    }

    if(!currentCustomer.hasOwnProperty('transactions')) {
      currentCustomer.transactions = [];
    }

    currentCustomer.totalMoney += amount;
    currentCustomer.transactions.push(`deposit ${amount}`);

    return `${currentCustomer.totalMoney}$`;
  }

  withdrawMoney(personalId, amount) {
    if(!this.allCustomers.some(x => x.personalId === personalId)) {
      throw new Error('We have no customer with this ID!');
    }

    let currentCustomer = this.allCustomers.find(x => x.personalId === personalId);

    if(currentCustomer.totalMoney < amount || !currentCustomer.hasOwnProperty('totalMoney')) {
      throw new Error(`${currentCustomer.firstName} ${currentCustomer.lastName} does not have enough money to withdraw that amount!`);
    }
    currentCustomer.totalMoney -= amount;
    currentCustomer.transactions.push(`withdraw ${amount}`);

    return `${currentCustomer.totalMoney}$`;
  }

  customerInfo(personalId) {
    if(!this.allCustomers.some(x => x.personalId === personalId)) {
      throw new Error('We have no customer with this ID!');
    }

    let currentCustomer = this.allCustomers.find(x => x.personalId === personalId);
    let result = [`Bank name: ${this._bankName}`, 
    `Customer name: ${currentCustomer.firstName} ${currentCustomer.lastName}`,
    `Customer ID: ${currentCustomer.personalId}`]

    currentCustomer.hasOwnProperty('totalMoney') ? result.push(`Total Money: ${currentCustomer.totalMoney}$`)
      : result.push('Total Money: 0$');

    if(currentCustomer.hasOwnProperty('transactions')) {
      result.push('Transactions:');
      for(let i = currentCustomer.transactions.length - 1; i >= 0; i--) {
        let [type, amount] = currentCustomer.transactions[i].split(' ');

        type === 'deposit' ? result.push(`${i + 1}. ${currentCustomer.firstName} ${currentCustomer.lastName} made deposit of ${amount}$!`)
          : result.push(`${i + 1}. ${currentCustomer.firstName} ${currentCustomer.lastName} withdrew ${amount}$!`);
      }
    }

    return result.join('\n');
  }
}

let bank = new Bank('SoftUni Bank');

console.log(bank.newCustomer({firstName: 'Svetlin', lastName: 'Nakov', personalId: 6233267}));
console.log(bank.newCustomer({firstName: 'Mihaela', lastName: 'Mileva', personalId: 4151596}));

bank.depositMoney(6233267, 250);
console.log(bank.depositMoney(6233267, 250));
bank.depositMoney(4151596,555);

console.log(bank.withdrawMoney(6233267, 125));

console.log(bank.customerInfo(6233267));

