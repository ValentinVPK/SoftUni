
**Exercise: Classes & Unit Testing on Classes** 

**Classes** 

1. **Rectangle** 

Write a **class** **Rectangle** for a rectangle object. It needs to have a **width** (Number), **height** (Number) and **color** (String) properties, which are set from the constructor and a **calcArea()** method, that calculates and **returns** the rectangle’s area. 

**Input** 

The constructor function will receive valid parameters. 

**Output** 

The **calcArea()** method should **return** a number. 

Submit the class definition as is, **without** wrapping it in any function. 

**Examples** 



|**Sample Input** |**Output** |
| - | - |
|**let rect = new Rectangle(4, 5, 'Red'); console.log(rect.width); console.log(rect.height); console.log(rect.color); console.log(rect.calcArea());** |**4 5 Red 20** |
2. **Data Class** 

Write a **class** **Request** that holds data about an HTTP request. It has the following properties: 

- **method** (String) 
- **uri** (String) 
- **version** (String) 
- **message** (String) 
- **response** (String) 
- **fulfilled** (Boolean) 

The first four properties (**method**, **uri**, **version**, **message**) are set trough the **constructor**, in the listed order. The **response** property is initialized to **undefined** and the **fulfilled** property is initially set to **false**. 

**Constraints** 

- The constructor of your class will receive **valid parameters**.  
- Submit the class definition as is, **without** wrapping it in any function. ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)

**Examples** 



|**Sample Input** |**Resulting object** |
| - | - |
|<p>**let myData = new Request('GET', 'http://google.com', 'HTTP/1.1', '')** </p><p>**console.log(myData);** </p>|<p>**Request {** </p><p>`  `**method: 'GET',** </p><p>`  `**uri: 'http://google.com',   version: 'HTTP/1.1',** </p><p>`  `**message: '',** </p><p>`  `**response: undefined,** </p><p>`  `**fulfilled: false** </p><p>**}** </p>|
3. **Tickets** 

Write a program that manages a database of tickets. A ticket has a **destination,** a **price** and a **status**. Your program will receive **two arguments** - the first is an **array of strings** for ticket descriptions and the second is a **string**, representing a **sorting criterion**. The ticket descriptions have the following format: 

**<destinationName>|<price>|<status>** 

Store each ticket and at the end of execution **return** a sorted summary of all tickets, sorted by either **destination**, **price** or **status**, depending on the **second parameter** that your program received. Always sort in ascending order (default behavior for **alphabetical** sort). If two tickets compare the same, use order of appearance. See the examples for more information. 

**Input** 

Your program will receive two parameters - an **array of strings** and a **single string**. **Output** 

**Return** a **sorted array** of all the tickets that where registered. 

**Examples ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)**



|**Sample Input** |**Output Array** |
| - | - |
|<p>**['Philadelphia|94.20|available',  'New York City|95.99|available',  'New York City|95.99|sold',** </p><p>` `**'Boston|126.20|departed'], 'destination'** </p>|<p>**[ Ticket { destination: 'Boston',** </p><p>`    `**price: 126.20,** </p><p>`    `**status: 'departed' },**  </p><p>`  `**Ticket { destination: 'New York City',     price: 95.99,** </p><p>`    `**status: 'available' },**  </p><p>`  `**Ticket { destination: 'New York City',     price: 95.99,** </p><p>`    `**status: 'sold' },**  </p><p>`  `**Ticket { destination: 'Philadelphia',** </p>|

||<p>**price: 94.20,** </p><p>**status: 'available' } ]** </p>|
| :- | - |
|<p>**['Philadelphia|94.20|available',  'New York City|95.99|available',  'New York City|95.99|sold',** </p><p>` `**'Boston|126.20|departed'], 'status'** </p>|<p>**[ Ticket { destination: 'Philadelphia',     price: 94.20,** </p><p>`    `**status: 'available' },** </p><p>`  `**Ticket { destination: 'New York City',     price: 95.99,** </p><p>`    `**status: 'available' },** </p><p>`  `**Ticket { destination: 'Boston',** </p><p>`    `**price: 126.20,** </p><p>`    `**status: 'departed' },** </p><p>`  `**Ticket { destination: 'New York City',     price: 95.99,** </p><p>`    `**status: 'sold' } ]** </p>|
4. **Sorted List** 

Implement a **class List**, which **keeps** a list of numbers, sorted in **ascending order**. It must support the following functionality: 

- **add(elemenent)** - adds a new element to the collection 
- **remove(index)** - removes the element at position **index** 
- **get(index)** - returns the value of the element at position **index** 
- **size** - number of elements stored in the collection 

The **correct order** of the elements must be kept **at all times**, regardless of which operation is called. **Removing** and **retrieving** elements **shouldn’t** **work** if the provided index points **outside the length** of the collection (either throw an error or do nothing). Note the **size** of the collection is **not** a function. 

**Input / Output** 

All function that expect **input** will receive data as **parameters**. Functions that have **validation** will be tested with both **valid and invalid** data. Any result expected from a function should be **returned** as it’s result. 

Your **add** and **remove** **functions** should **return** an **class** **instance** with the required functionality as it’s result.  

Submit the class definition as is, **without** wrapping it in any function. 

**Examples ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)**



|**Sample Input** |**Output** |
| - | - |
|<p>**let list = new List(); list.add(5);** </p><p>**list.add(6);** </p><p>**list.add(7); console.log(list.get(1));**  </p>|**6 7** |

|**list.remove(1); console.log(list.get(1));** ||
| :- | :- |
5. **Length Limit** 

Create a class **Stringer**, which holds **single string** and a **length** property. The class should be initialized with a **string**, and an **initial length.** The class should always keep the **initial state** of its **given** **string**. 

Name the two properties **innerString** and **innerLength**. 

There should also be functionality for increasing and decreasing the initial **length** property. 

Implement function **increase(length)** and **decrease(length)**, which manipulate the length property with the **given value**. 

The length property is **a numeric value** and should not fall below **0**. It should not throw any errors, but if an attempt to decrease it below 0 is done, it should be automatically set to **0**. 

You should also implement functionality for **toString()** function, which returns the string, the object was initialized with. If the length of the string is greater than the **length property**, the string should be cut to from right to left, so that it has the **same length** as the **length property**, and you should add **3 dots** after it, if such **truncation** was **done**. 

If the length property is **0**, just return **3 dots.** 

**Examples** 

**lengthLimit.js ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.002.png)**

**let *test*** = **new** Stringer(**"Test"**, 5); ***console***.log(***test***.toString()); *// Test* 

***test***.decrease(3); ***console***.log(***test***.toString()); *// Te...* 

***test***.decrease(5); ***console***.log(***test***.toString()); *// ...* 

***test***.increase(4);  ***console***.log(***test***.toString()); *// Test* 

6. **Company** 

**class** Company { 

`    `*// **TODO: implement this class...*** } 

Write a class **Company**, which following these requirements: 

The **constructor** takes no parameters: 

`    `You could initialize an object: 

- **departments** - empty object** 

**addEmployee({username}, {Salary}, {Position}, {Department})** This function should add a new employee to the department with the given name. ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)

- If one of the passed parameters is empty string (""), undefined or null, this function should throw an error with the following message: "**Invalid input!"** 
- If salary is less than 0, this function should throw an error with the following message: **"Invalid input!"** 
- If the new employee is hired successfully, you should add him into the departments array and return the following message: **"New employee is hired. Name: {name}. Position: {position}"** 

**bestDepartment()** 

This function** should return the **department** with the **highest average salary rounded** to the second digit after decimal point and its **employees sorted** by their **salary** by **descending** order and by their **name** in **ascending** order as a second criteria: 

**"Best Department is: {best department's name} Average salary: {best department's average salary} {employee1} {salary} {position}** 

**{employee2} {salary} {position}** 

**{employee3} {salary} {position}** 

**…"** 

**Submission** 

Submit only the **Company** class definition. **Examples** 

This is an example how the code is **intended to be used**: ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)



|**Sample code usage** |
| - |
|let c = new Company(); |
|c.addEmployee("Stanimir", 2000, "engineer", "Construction"); |
|c.addEmployee("Pesho", 1500, "electrical engineer", "Construction"); |
|c.addEmployee("Slavi", 500, "dyer", "Construction"); |
|c.addEmployee("Stan", 2000, "architect", "Construction"); |
|c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing"); |
|c.addEmployee("Pesho", 1000, "graphical designer", "Marketing"); |
|c.addEmployee("Gosho", 1350, "HR", "Human resources"); |
|console.log(c.bestDepartment()); |
|**Corresponding output** |
|<p>**Best Department is: Construction Average salary: 1500.00** </p><p>**Stan 2000 architect** </p><p>**Stanimir 2000 engineer** </p><p>**Pesho 1500 electrical engineer Slavi 500 dyer** </p>|
7. **HEX** 

**class** Hex { 

`    `*// **TODO: implement this class...*** } 

Write a class **Hex**, having the following functionality:** 

- The **constructor** takes one parameter **value**, which is a number** 
- **valueOf()** This function should return the **value** property of the hex class. 
- **toString()** This function** will show its **hexadecimal value** starting with "0x" 
- **plus({number})** This function should add a number or Hex object and return a new Hex object. 
- **minus({number})** This function should subtract a number or Hex object and return a new Hex object. 
- **parse({string})** Create a parse **class method** that can **parse** Hexidecimal numbers and convert them to standard decimal numbers. 

**Submission** 

Submit only your **Hex class.** 

**Examples** 

This is an example how the code is **intended to be used**: 



|**Input** |**Output** |
| - | - |
|<p>let FF = new Hex(255); console.log(FF.toString()); FF.valueOf() + 1 == 256; </p><p>let a = new Hex(10); </p><p>let b = new Hex(5); console.log(a.plus(b).toString()); </p><p>console.log(a.plus(b).toString()==='0xF'); console.log(Hex.parse('AAA')); </p>|**0XFF 0XF true 2730** |
**Built-in Collections** 

8. **Juice Flavors** 

You will be given different juices, as **strings**. You will also **receive quantity** as a **number**. If you receive a juice, you already have, **you must sum** the **current quantity** of that juice, with the **given one**. When a juice reaches **1000 quantity**, it produces a bottle. You must **store all produced bottles** and you must **print them** at the end. 

**Note:** **1000 quantity** of juice is **one bottle**. If you happen to have **more than 1000**, you must make **as much bottles as you can**, and store **what** **is** **left** from the juice. 

**Example:** **You have 2643 quantity** of Orange Juice – this is **2 bottles** of Orange Juice and **643 quantity left**. 

**Input** 

The **input** comes as array of strings. Each element holds data about a juice and quantity in the following format: “**{juiceName} => {juiceQuantity}**” ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)

**Output** 

The **output** is the produced bottles. The bottles are to be printed in **order of obtaining the bottles**. Check the second example bellow - even though we receive the Kiwi juice first, we don’t form a bottle of Kiwi juice until the 4th line, at which point we have already created Pear and Watermelon juice bottles, thus the Kiwi bottles appear last in the output. 

**Examples** 



|**Input** |**Output** |
| - | - |
|['Orange => 2000', 'Peach => 1432', 'Banana => 450', 'Peach => 600', 'Strawberry => 549'] |Orange => 2 Peach => 2 |
|<p>['Kiwi => 234', </p><p>'Pear => 2345', 'Watermelon => 3456', 'Kiwi => 4567', </p><p>'Pear => 5678', 'Watermelon => 6789'] </p>|Pear => 8 Watermelon => 10 Kiwi => 4 |
9. **Auto-Engineering Company** 

You are tasked to create a register for a company that produces cars. You need to store **how many cars** have been produced from a **specified model** of a **specified brand**. 

**Input** 

The **input** comes as array of strings. Each element holds information in the following format: “**{carBrand} | {carModel} | {producedCars}**” 

The car **brands** and **models** are **strings**, the **produced cars** are **numbers**. If the **car brand** you’ve received **already exists**, just add the **new** **car model** to it with the **produced cars** **as its value**. If even the car model exists, just **add** the **given value** to the **current one**. 

**Output** 

As **output** you need to print - **for every car brand**, the **car models**, and **number of cars produced** from that model. The output format is: 

**“{carBrand}** 

`  `**###{carModel} -> {producedCars}   ###{carModel2} -> {producedCars}   ...”** 

The order of printing is the **order in which the brands and models first appear in the input**. The first brand in the input should be the first printed and so on. For each brand, the first model received from that brand, should be the first printed and so on.  ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)

© SoftUni –[ https://softuni.org.](https://softuni.org/) Copyrighted document. Unauthorized copy, reproduction or use is not permitted. Follow us: ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.003.png)          Page PAGE8 of NUMPAGES15![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.004.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.005.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.006.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.007.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.008.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.009.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.010.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.011.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.012.png)

|**Input** |**Output** |
| - | - |
|<p>['Audi | Q7 | 1000', </p><p>'Audi | Q6 | 100', </p><p>- BMW | X5 | 1000', </p><p>- BMW | X6 | 100', </p><p>- Citroen | C4 | 123', </p><p>- Volga | GAZ-24 | 1000000', 'Lada | Niva | 1000000', 'Lada | Jigula | 1000000', 'Citroen | C4 | 22', </p><p>'Citroen | C5 | 10'] </p>|<p>Audi </p><p>###Q7 -> 1000 </p><p>###Q6 -> 100 </p><p>BMW </p><p>###X5 -> 1000 </p><p>###X6 -> 100 </p><p>Citroen </p><p>###C4 -> 145 </p><p>###C5 -> 10 </p><p>Volga </p><p>###GAZ-24 -> 1000000 Lada </p><p>###Niva -> 1000000 ###Jigula -> 1000000 </p>|
**Classes Interacting with DOM** 

10. **Contacts Builder** 

Write a JS **class** that generates a **contact** info box. You will receive a person's first name, last name, phone and email. Compose the markup for the contact box, attach all the needed events and when the **render** function is called, **append** the newly created element to the document. 

A contact info box is **composed** of first name, last name, phone, email (all strings) and a property which indicates if the contact is online or not. Clicking a button on the box **toggles** the visibility of the person's contact information (phone and email). *See the examples for more details.* 

The **constructor** of your class needs to take **four** string arguments - first name, last name, phone, email. Additionally, the class should also contain the following functionality: 

- Property **online** – Boolean value, initially set to **false** 
- Function **render(id)** – **appends** the Contact's **HTML element representation** to the **DOM element** with **Id** equal to the argument 

When the value of the **online** property is changed, the corresponding HTML should be updated – if it’s set to **true**, add the class "**online**" to the div with class "**title**" (containing the name). If it’s **false**, remove the class "**online**". 

A contact info box should have the following HTML structure: 



|**Contact** |
| - |
|<**article**> |
|<**div class="title"**>{firstName lastName}<**button**>**&#8505;**</**button**></**div**> |
|<**div class="info"**> |
|<**span**>**&phone;** {phone}</**span**> |
|<**span**>**&#9993;** {email}</**span**> |
|</**div**> |
|</**article**>|
When the box is initiallity created, the div with class "**info**" must be **hidden**. Clicking the button **toggles its visibility**. You can use the HTML skeleton to test your functionality. ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)

Your solution can be **tested** using the following code: 

**Sample JavaScript ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.013.png)**

let contacts = [ 

`  `**new** Contact(**"Ivan"**, **"Ivanov"**, **"0888 123 456"**, **"i.ivanov@gmail.com"**),   **new** Contact(**"Maria"**, **"Petrova"**, **"0899 987 654"**, **"mar4eto@abv.bg"**),   **new** Contact(**"Jordan"**, **"Kirov"**, **"0988 456 789"**, **"jordk@gmail.com"**) ]; 

contacts.forEach(c => c.render(**'main'**)); 

*// After 1 second, change the online status to true* setTimeout(() => contacts[1].**online** = **true**, 2000); 

11. **View Model** 

We need to create a class **Textbox** that represents one or more **HTML input** elements with type="text". The **constructor** takes as parameters a **selector** and a **regex** for invalid symbols.  

Textbox elements created from the class should have: 

- property **value** (has getters and setters)  
- property **\_elements** containing the set of elements matching the selector 
- getter **elements** for the **\_elements** property – return as NodeList 
- property **\_invalidSymbols** - a regex used for validating the textbox value 
- method **isValid()** - if the **\_invalidSymbols** regex can be matched in any of the **\_elements values** return **false**, otherwise return **true**. 

All **\_elements** values and the **value** property should be linked. If the value of an element from **\_elements** change all other elements' values and the **value** property should instantly reflect it, likewise should happen if the **value** property changes.  

**Constraints** 

- Selectors will always point to input elements with type text. 

**Unit Testing on Classes** 

12. **Payment Package** 

You are given the following **JavaScript class**: ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)



|**PaymentPackage.js** |
| - |
|<p>**class** PaymentPackage { </p><p>`  `constructor(name, value) { </p><p>`    `**this**.name = name; </p><p>`    `**this**.value = value; </p><p>`    `**this**.VAT = 20;      *// Default value*         **this**.active = **true**; *// Default value* </p><p>*  } </p>|
`  `**get** name() { 

`    `**return this**.**\_name**;   } 

`  `**set** name(newValue) { 

`    `**if** (**typeof** newValue !== **'string'**) { 

`      `**throw new** Error(**'Name must be a non-empty string'**);     } 

`    `**if** (newValue.length === 0) { 

`      `**throw new** Error(**'Name must be a non-empty string'**);     } 

`    `**this**.**\_name** = newValue; 

`  `} 

`  `**get** value() { 

`    `**return this**.**\_value**;   } 

`  `**set** value(newValue) { 

`    `**if** (**typeof** newValue !== **'number'**) { 

`      `**throw new** Error(**'Value must be a non-negative number'**);     } 

`    `**if** (newValue < 0) { 

`      `**throw new** Error(**'Value must be a non-negative number'**);     } 

`    `**this**.**\_value** = newValue; 

`  `} 

`  `**get** VAT() { 

`    `**return this**.**\_VAT**;   } 

`  `**set** VAT(newValue) { 

`    `**if** (**typeof** newValue !== **'number'**) { 

`      `**throw new** Error(**'VAT must be a non-negative number'**);     } 

`    `**if** (newValue < 0) { 

`      `**throw new** Error(**'VAT must be a non-negative number'**);     } 

`    `**this**.**\_VAT** = newValue; 

`  `} 

`  `**get** active() { 

`    `**return this**.**\_active**;   } 

`  `**set** active(newValue) { 

`    `**if** (**typeof** newValue !== **'boolean'**) { 

`      `**throw new** Error(**'Active status must be a boolean'**);     } 

`    `**this**.**\_active** = newValue; 

`  `} 

`  `toString() { 

`    `**const** output = [ ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)

© SoftUni –[ https://softuni.org.](https://softuni.org/) Copyrighted document. Unauthorized copy, reproduction or use is not permitted. Follow us: ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.003.png)          Page PAGE11 of NUMPAGES15![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.004.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.005.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.006.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.007.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.008.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.009.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.010.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.011.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.012.png)

`       `**Package:** ${**this**.name}**  + (**this**.active === **false** ? **' (inactive)'** : **''**), 

- **Value (excl. VAT):** ${**this**.value}** , 
- **Value (VAT** ${**this**.VAT}**%):** ${**this**.value \* (1 + **this**.VAT / 100)}**  
**
`    `]; 

`    `**return** output.join(**'\n'**); 

`  `} 

} 

**Functionality** 

The above code defines a **class** that contains information about a **payment package**. An **instance** of the class should support the following operations: 

- Can be **instantiated** with two parameters - a string name and number value 
- Accessor **name** - used to get and set the value of name 
- Accessor **value** - used to get and set the value of value 
- Accessor **VAT** - used to get and set the value of VAT 
- Accessor **active** - used to get and set the value of active 
- Function **toString()** - return a string, containing an overview of the instance; if the package is **not active**, append the label "**(inactive)**" to the printed **name** 

When creating an instance, or changing any of the property values, the parameters are validated. They must follow these rules: 

- **name** - non-empty string 
- **value** - non-negative number 
- **VAT** - non-negative number 
- **active** - Boolean 

If any of the requirements aren’t met, the operation must throw an error. ***Scroll down for examples and details about submitting to Judge.*** 

**Example** 

This is an example how this code is **intended to be used**: ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)



|**Sample code usage** |
| - |
|*// Should throw an error* |
|**try** { |
|**const *hrPack*** = **new** PaymentPackage(**'HR Services'**); |
|} **catch**(err) { |
|**console**.log(**'Error: '** + err.**message**); |
|} |
|**const *packages*** = [ |
|**new** PaymentPackage(**'HR Services'**, 1500), |
|**new** PaymentPackage(**'Consultation'**, 800), |
|**new** PaymentPackage(**'Partnership Fee'**, 7000), |
|]; |
|**console**.log(***packages***.join(**'\n'**)); |
||
|**const *wrongPack*** = **new** PaymentPackage(**'Transfer Fee'**, 100); |
|*// Should throw an error* |
|**try** { |

|***wrongPack***.active = **null**; |
| - |
|} **catch**(err) { |
|**console**.log(**'Error: '** + err.**message**); |
|}|
||
|**Corresponding output** |
|Error: Value must be a non-negative number |
|Package: HR Services |
|- Value (excl. VAT): 1500 |
|- Value (VAT 20%): 1800 |
|Package: Consultation |
|- Value (excl. VAT): 800 |
|- Value (VAT 20%): 960 |
|Package: Partnership Fee |
|- Value (excl. VAT): 7000 |
|- Value (VAT 20%): 8400 |
|Error: Active status must be a boolean |
**Your Task** 

Using **Mocha** and **Chai** write **unit tests** to test the entire functionality of the **PaymentPackage** class. Make sure instances of it have all the required functionality and validation. You may use the following code as a template: 

describe(**"*TODO* …"**, **function**() {     ***it***(**"*TODO …*"**, **function**() {         *// **TODO:*** … 

`    `}); 

`    `*// **TODO:*** … 

}); 

13. **String Builder \*** 

You are given the following **JavaScript class**: ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)



|**string-builder.js** |
| - |
|<p>**class** StringBuilder { </p><p>`  `constructor(string) { </p><p>`    `**if** (string !== ***undefined***) { </p><p>`      `StringBuilder.*\_vrfyParam*(string); </p><p>`      `**this**.**\_stringArray** = Array.from(string);     } **else** { </p><p>`      `**this**.**\_stringArray** = []; </p><p>`    `} </p><p>`  `} </p><p>`  `append(string) { </p><p>`    `StringBuilder.*\_vrfyParam*(string); </p><p>`    `**for**(**let** i = 0; i < string.**length**; i++) {       **this**.**\_stringArray**.push(string[i]); </p><p>`    `} </p><p>`  `} </p><p>`  `prepend(string) { </p>|
`    `StringBuilder.*\_vrfyParam*(string); 

`    `**for**(**let** i = string.**length** - 1; i >= 0; i--) {       **this**.**\_stringArray**.unshift(string[i]); 

`    `} 

`  `} 

`  `insertAt(string, startIndex) { 

`    `StringBuilder.*\_vrfyParam*(string); 

`    `**this**.**\_stringArray**.splice(startIndex, 0, ...string);   } 

`  `remove(startIndex, length) { 

`    `**this**.**\_stringArray**.splice(startIndex, length);   } 

`  `**static** *\_vrfyParam*(param) { 

`    `**if** (**typeof** param !== **'string'**) **throw new TypeError**(**'Argument must be a string'**);   } 

`  `toString() { 

`    `**return this**.**\_stringArray**.join(**''**);   } 

} 

**Functionality** 

The above code defines a **class** that holds **characters** (strings with length 1) in an array. An **instance** of the class should support the following operations: 

- Can be **instantiated** with a passed in **string** argument or **without** anything 
- Function **append(string)** - **converts** the passed in **string** argument to an **array** and adds it to the **end** of the storage 
- Function **prepend**(**string**) - **converts** the passed in **string** argument to an **array** and adds it to the **beginning** of the storage 
- Function **insertAt(string, index)** - **converts** the passed in **string** argument to an **array** and adds it at the **given** index (you only need to test the behaviour when the index is in range) 
- Function **remove(startIndex, length)** - **removes** elements from the storage, starting at the given index (**inclusive**), **length** number of characters (you only need to test the behaviour when the index is in range) 
- Function **toString()** - **returns** a string with **all** elements joined by an **empty** string 
- All passed in **arguments** should be **strings.** If any of them are **not**, **throws** a type **error** with the following message: **'Argument must be a string'** 

**Example** 

This is an example how this code is **intended to be used**: 

**Sample code usage  Corresponding output ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.014.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.015.png)![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)**

**let** str = **new** StringBuilder(**'hello'**);  User,woop hello, there str.append(**', there'**);  User,w hello, there str.prepend(**'User, '**); 

str.insertAt(**'woop'**,5 ); 

**console**.log(str.toString()); 

str.remove(6, 3); 

**console**.log(str.toString()); 

**Your Task** 

Using **Mocha** and **Chai** write **JS unit tests** to test the entire functionality of the **StringBuilder** class. Make sure it is **correctly defined as a class** and instances of it have all the required functionality. You may use the following code as a template: 

describe(**"*TODO* …"**, **function**() {     ***it***(**"*TODO …*"**, **function**() {         *// **TODO:*** … 

`    `}); 

`    `*// **TODO:*** … 

}); ![](Aspose.Words.39a9f933-ff1d-4ff5-bea4-651edfa19fa7.001.png)

