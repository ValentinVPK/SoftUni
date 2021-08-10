**JS Advanced - Exam** 

**Problem 3. Unit Testing** 

**Your Task** 

Using **Mocha** and **Chai** write **JS Unit Tests** to test a variable named **pizzUni**, which represents an object. You may use the following code as a template: 

describe(**"*Tests* …"**, **function**() { 

`    `describe(**"*TODO* …"**, **function**() { 

`        `***it***(**"*TODO …*"**, **function**() {             *// **TODO:*** … 

`        `}); 

`     `}); 

`     `*// **TODO:*** … }); 

The object that should have the following functionality:  

- **makeAnOrder(obj)** - A function that accepts an object: 
- the object includes {orderedPizza: ‘the name of the pizza’, orderedDrink: ‘the name of the drink’} 
- the function checks if there are ordered pizza and a drink. 
- Then the function returns confirmation message for your order 
- **getRemainingWork(statusArr)** - A function that accepts array: 
- the array should look like: [{pizzaName: ‘the name of the pizza’, status: ‘ready’ / ‘preparing’ }, …] 
- the function checks the status of the order and returns a message with the order status 
- **orderType(totalSum, typeOfOrder)** - A function that accepts two parameters (number, string): 
- the function first checks what is the type of the order (‘Carry Out’ , ‘Delivery’) 
- if the type of the order is ‘Carry Out’ you get 10% discount 
- then the function returns the total sum of the order 

**JS Code** 

To ease you in the process, you are provided with an implementation which meets all of the specification requirements for the **pizzUni** object: 

**pizza.js ![](Aspose.Words.18cd4584-e14a-4197-a30a-bb47a3fd2b0e.001.png)**



|Let pizzUni = { |
| - |
|makeAnOrder: function (obj) { |
||
|if (!obj.orderedPizza) { |
|throw new Error('You must order at least 1 Pizza to finish the order.'); |
|} else { |
|Let result =  You just ordered ${obj.orderedPizza}  |
|If (obj.orderedDrink) { |
|Result +=   and ${obj.orderedDrink}.  |
|} |
|Return result; |
|} |
|}, |
||
|getRemainingWork: function (statusArr) { |
||
|const remainingArr = statusArr.filter(s => s.status != 'ready'); |
||
|if (remainingArr.length > 0) { |
||
|let pizzaNames = remainingArr.map(p => p.pizzaName).join(', ') |
|let pizzasLeft =  The following pizzas are still preparing: ${pizzaNames}. |
||
|return pizzasLeft; |
|} else { |
|Return 'All orders are complete!' |
|} |
||
|}, |
||
|orderType: function (totalSum, typeOfOrder) { |
|if (typeOfOrder === 'Carry Out') { |
|totalSum -= totalSum \* 0.1; |
||
|return totalSum; |
|} else if (typeOfOrder === 'Delivery') { |
||
|Return totalSum; |
|} |
|} |
|} |
![](Aspose.Words.18cd4584-e14a-4197-a30a-bb47a3fd2b0e.002.png)
