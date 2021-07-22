
**Exercises: Objects & Composition** 

1. **Calorie Object** 

Write a function that composes an object by given properties. The input comes as an **array of strings**. Every **even index** of the array represents the **name of the food**. Every **odd index** is a **number** that is equal to the **calories in 100 grams of the given product**. Assign each value to its corresponding property and print it on the console. 

The **input** comes as an **array of string** **elements**. The **output** should be printed on the console. 

**Examples** 



|**Input** |**Output** |
| - | - |
|['Yoghurt', '48', 'Rise', '138', 'Apple', '52'] |{ Yoghurt: 48, Rise: 138, Apple: 52 } |
|['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42'] |{ Potato: 93, Skyr: 63, Cucumber: 18, Milk: 42 } |
2. **Construction Crew** 

Write a program that receives a **worker** object as a parameter and modifies its properties. Workers have the following structure: 

**{ weight: Number,** 

`  `**experience: Number,** 

`  `**levelOfHydrated: Number,   dizziness: Boolean }** 

Weight is expressed in **kilograms**, **experience** in **years** and **levelOfHydrated** is in **milliliters**. If you receive a worker who’s **dizziness** property is set to **true** it means he needs to intake some **water** in order to be able to work correctly. The required amount is 0.1ml per **kilogram** per year of **experience**. The required amount must be **added** to the **existing amount**. Once the water is administered, change the **dizziness** property to **false**. 

Workers who **do not have dizziness** should **not** be modified in any way. Return them as they were. **Input** 

Your function will receive a valid **object** as **parameter**. 

**Output** 

Return the **same object** that was passed in, **modified** as necessary. 

**Examples** 

**Input  Output ![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.001.png)![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.002.png)![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.003.png)**

|<p>**{ weight: 80,** </p><p>`  `**experience: 1,** </p><p>`  `**levelOfHydrated: 0,   dizziness: true }** </p>|<p>**{ weight: 80,** </p><p>`  `**experience: 1,** </p><p>`  `**levelOfHydrated: 8,   dizziness: false }** </p>|
| - | - |
|<p>**{ weight: 120,** </p><p>`  `**experience: 20,** </p><p>`  `**levelOfHydrated: 200,   dizziness: true }** </p>|<p>**{ weight: 120,** </p><p>`  `**experience: 20,** </p><p>`  `**levelOfHydrated: 440,   dizziness: false }** </p>|
|<p>**{ weight: 95,** </p><p>`  `**experience: 3,** </p><p>`  `**levelOfHydrated: 0,   dizziness: false }** </p>|<p>**{ weight: 95,** </p><p>`  `**experience: 3,** </p><p>`  `**levelOfHydrated: 0,   dizziness: false }** </p>|
3. **Car Factory** 

Write a program that assembles a car by **given requirements** out of **existing** **components**. The client will place an order in the form of an **object describing** the car. You need to **determine** which parts to use to fulfil the client’s order. You have the following parts in storage: 

An **engine** has **power** (given in horsepower) and **volume** (given in cubic centimeters). Both of these values are **numbers**. When selecting an engine, pick the **smallest possible** that still meets the requirements. 

**Small engine: { power: 90, volume: 1800 } Normal engine: { power: 120, volume: 2400 } Monster engine: { power: 200, volume: 3500 }** 

A **carriage** has a **type** and **color**. Both of these values are **strings**. You have two types of carriages in storage and can paint it **any color**. 

**Hatchback: { type: 'hatchback', color: <as required> } Coupe: { type: 'coupe', color: <as required> }** 

The **wheels** will be represented by an **array** of 4 **numbers**, each number represents the **diameter** of the wheel in inches. The size can only be an **odd number**. Round **down** any requirements you receive to the nearest odd number.  

**Input** 

You will receive an **object** as an **argument** to your function. The format will be as follows: 

**{ model: <model name>,** 

`  `**power: <minimum power>,** 

`  `**color: <color>,** 

`  `**carriage: <carriage type>,   wheelsize: <size> }** 

**Output** 

**Return** the resulting car **object** as a result of your function. See the examples for details. ![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.003.png)


**Examples** 
|**Sample input** |**Output** |
| - | - |
|<p>**{ model: 'VW Golf II',   power: 90,** </p><p>`  `**color: 'blue',** </p><p>`  `**carriage: 'hatchback',   wheelsize: 14 }** </p>|<p>**{ model: 'VW Golf II',** </p><p>`  `**engine: { power: 90,** </p><p>`            `**volume: 1800 },** </p><p>`  `**carriage: { type: 'hatchback',               color: 'blue' },   wheels: [13, 13, 13, 13] }** </p>|
|<p>**{ model: 'Opel Vectra',   power: 110,** </p><p>`  `**color: 'grey',** </p><p>`  `**carriage: 'coupe',** </p><p>`  `**wheelsize: 17 }** </p>|<p>**{ model: 'Opel Vectra',** </p><p>`  `**engine: { power: 120,** </p><p>`            `**volume: 2400 },** </p><p>`  `**carriage: { type: 'coupe',               color: 'grey' },   wheels: [17, 17, 17, 17] }** </p>|
4. **Heroic Inventory** 

In the era of heroes, every hero has his own items which make him unique. Create a function which creates a **register for the heroes**, with their **names**, **level**, and **items**, if they have such. The register should accept data in a specified format, and return it presented in a specified format.  

**Input** 

The **input** comes as array of strings. Each element holds data for a hero, in the following format: 

“**{heroName} / {heroLevel} / {item1}, {item2}, {item3}...**”  

You must store the data about every hero. The **name** is a **string**, the **level** is a **number** and the items are all **strings.** 

**Output** 

The **output** is a **JSON representation** of the data for all the heroes you’ve stored. The data must be an **array of all the heroes**. Check the examples for more info. 

**Examples ![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.003.png)**



|**Input** |**Output** |
| - | - |
|<p>['Isacc / 25 / Apple, GravityGun', </p><p>'Derek / 12 / BarrelVest, DestructionSword', 'Hes / 1 / Desolator, Sentinel, Antara'] </p>|[{"name":"Isacc","level":25,"items":["Apple","GravityGun" ]},{"name":"Derek","level":12,"items":["BarrelVest","Dest ructionSword"]},{"name":"Hes","level":1,"items":["Desola tor","Sentinel","Antara"]}] |
|['Jake / 1000 / Gauss, HolidayGrenade'] |[{"name":"Jake","level":1000,"items":["Gauss","HolidayGr enade"]}] |



5. **Lowest Prices in Cities** 

You will be given several towns, with products and their price. You need to find **the lowest price** for **every product** and **the town it is sold at** for that price. 

**Input** 

The **input** comes as array of strings. Each element will hold data about a **town**, **product**, and **its price** at that town. The **town** and **product** will be **strings**, the **price** will be a **number**. The input will come in the following format: 

**{townName} | {productName} | {productPrice}** 

If you receive the same **town** and **product** **more than once,** you should **update** the **old value** with the **new one**. 

**Output** 

As **output** you must print **each** **product** with its **lowest price** and **the town** at which the product is **sold at that** **price**. If **two towns share** the **same lowest price**, print the one that was **entered first**.  

The output, for every product, should be in the following format: 

**{productName} -> {productLowestPrice} ({townName})** 

The **order of output** is - **order of entrance**. See the examples for more info. 

**Examples** 



|**Input** |**Output** |
| - | - |
|<p>['Sample Town | Sample Product | 1000', 'Sample Town | Orange | 2', </p><p>'Sample Town | Peach | 1', </p><p>'Sofia | Orange | 3', </p><p>'Sofia | Peach | 2', </p><p>'New York | Sample Product | 1000.1', 'New York | Burger | 10'] </p>|<p>Sample Product -> 1000 (Sample Town) Orange -> 2 (Sample Town) </p><p>Peach -> 1 (Sample Town) </p><p>Burger -> 10 (New York) </p>|
6. **Store Catalogue** 

You have to create a sorted catalogue of store products. You will be given the products’ names and prices. You need to order them by **alphabetical order**.  

**Input** 

The **input** comes as array of strings. Each element holds info about a product in the following format: “**{productName} : {productPrice}**” 

The **product’s name** will be a **string**, which will **always** **start with a capital letter**, and the **price** will be **a number**. There will be **NO duplicate product input**. The comparison for alphabetical order is **case-insensitive**. 

**Output** 

As **output** you must print all the products in a specified format. They must be ordered **exactly as specified above**. The products must be **divided into groups**, by the **initial of their name**. The **group’s initial should be printed**, and after that the products should be printed with **2 spaces before their names**. For more info check the examples. ![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.003.png)


**Examples** 
|**Input** |**Output** |
| - | - |
|<p>['Appricot : 20.4', 'Fridge : 1500', </p><p>'TV : 1499', 'Deodorant : 10', 'Boiler : 300', </p><p>'Apple : 1.25', 'Anti-Bug Spray : 15', 'T-Shirt : 10'] </p>|<p>A </p><p>`  `Anti-Bug Spray: 15   Apple: 1.25 </p><p>`  `Appricot: 20.4 </p><p>B </p><p>`  `Boiler: 300 </p><p>D </p><p>`  `Deodorant: 10 </p><p>F </p><p>`  `Fridge: 1500 </p><p>T </p><p>`  `T-Shirt: 10 </p><p>`  `TV: 1499 </p>|

|**Input** |**Output** |
| - | - |
|<p>['Banana : 2', 'Rubic's Cube : 5', 'Raspberry P : 4999', 'Rolex : 100000', 'Rollon : 10', </p><p>'Rali Car : 2000000', 'Pesho : 0.000001', </p><p>'Barrel : 10'] </p>|<p>B </p><p>`  `Banana: 2 </p><p>`  `Barrel: 10 </p><p>P </p><p>`  `Pesho: 0.000001 R </p><p>`  `Rali Car: 2000000   Raspberry P: 4999   Rolex: 100000 </p><p>`  `Rollon: 10 </p><p>`  `Rubic's Cube: 5 </p>|
7. **Towns to JSON** 

You're tasked to create and print a JSON from a text table. You will receive input as an array of strings, where each string represents a row of a table, with values on the row encompassed by pipes **"|"** and optionally spaces. The table will consist of exactly 3 columns **"Town"**, **"Latitude"** and **"Longitude"**. The **latitude** and **longitude** columns will always contain **valid numbers**. Check the examples to get a better understanding of your task. 

**Input** 

The **input** comes as an array of strings – the first string contains the table’s headings, each next string is a row from the table. 

**Output** 

- The **output** should be an array of objects wrapped in **JSON.stringify()**.  
- **Latitude** and **longitude** must be parsed to **numbers,** and represented till the **second digit after the decimal point**! 

**Examples ![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.003.png)**



|**Input** |**Output** |
| - | - |
|<p>['| Town | Latitude | Longitude |', </p><p>'| Sofia | 42.696552 | 23.32601 |', </p><p>'| Beijing | 39.913818 | 116.363625 |'] </p>|[{"Town":"Sofia",   "Latitude":42.7,   "Longitude":23.32 }, {"Town":"Beijing",   "Latitude":39.91,   "Longitude":116.36 }] |



|<p>['| Town | Latitude | Longitude |', </p><p>'| Veliko Turnovo | 43.0757 | 25.6172 |', '| Monatevideo | 34.50 | 56.11 |'] </p>|<p>[{"Town":"Veliko Turnovo",   "Latitude":43.08, </p><p>`  `"Longitude":25.62 </p><p>}, </p><p>{"Town":"Monatevideo", </p><p>` `"Latitude":34.5, </p><p>` `"Longitude":56.11 </p><p>}] </p>|
| - | :- |
8. **Rectangle** 

Write a **function** that creats and returns a rectangle object. The rectangle needs to have a **width** (Number), **height** (Number) and **color** (String) properties, which are set via arguments during creation, and a **calcArea()** method, that calculates and **returns** the rectangle’s area. 

**Input** 

The function will receive three valid parameters – **width** (Number), **height** (Number) and **color** (String). 

**Output** 

Your function must return an object with all properties and methods as described. The **calcArea()** method of the object should **return** a number. The first letter in the color must be **upperCase().** 

**Examples** 



|**Sample Input** |**Output** |
| - | - |
|<p>**let rect = rectangle(4, 5, 'red'); console.log(rect.width); console.log(rect.height);** </p><p>**console.log(rect.color); console.log(rect.calcArea());** </p>|**4 5 Red 20** |
9. **Sorted List\*** 

Create a function that returns a special **object**, which **keeps** a list of numbers, sorted in **ascending order**. It must support the following functionality: 

- **add(elemenent)** - adds a new element to the collection 
- **remove(index)** - removes the element at position **index** 
- **get(index)** - returns the value of the element at position **index** 
- **size** - number of elements stored in the collection 

The **correct order** of the elements must be kept **at all times**, regardless of which operation is called. **Removing** and **retrieving** elements **shouldn’t** **work** if the provided index points **outside the length** of the collection (either throw an error or do nothing). Note the **size** of the collection is **not** a function. 

**Input / Output** 

The initial function takes no arguments and must **return** an **object**. 

All methods on the object that expect **input** will receive data as **parameters**. Methods that have **validation** will be tested with both **valid and invalid** data. Any result expected from a method should be **returned** as it’s result. ![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.003.png)


**Examples** 
|**Sample Input** |**Output** |
| - | - |
|<p>**let list = createSortedList(); list.add(5);** </p><p>**list.add(6);** </p><p>**list.add(7); console.log(list.get(1));  list.remove(1); console.log(list.get(1));** </p>|**6 7** |
10. **Heroes** 

Create a function **returns** an **object** with 2 methods (**mage** and **fighter**). This object should be able to **create** heroes (fighters and mages). Every hero has a **state**. 

- Fighters have **name**, **health = 100** and **stamina = 100** and every fighter can fight.  When he **fights** his **stamina** **decreases** by **1** and the following message is **printed** on the console: 

` `**${fighter's name} slashes at the foe!**  

- Mages also have state (**name**, **health = 100** and **mana = 100**). Every mage can **cast** **spells**. When a spell is casted the mage's **mana** **decreases** by **1** and the following message is **printed** on the console:** 

` `**${mage's name} cast ${spell}**  

**Note:**  

For more information check the examples below. ![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.003.png)



|**Input** |**Output** |
| - | - |
|<p>let create = solve(); </p><p>const scorcher = create.mage("Scorcher"); scorcher.cast("fireball") scorcher.cast("thunder") scorcher.cast("light") </p><p>const scorcher2 = create.fighter("Scorcher 2"); scorcher2.fight() </p><p>console.log(scorcher2.stamina); console.log(scorcher.mana); </p>|<p>**Scorcher cast fireball Scorcher cast thunder Scorcher cast light** </p><p>**Scorcher 2 slashes at the foe! 99** </p><p>**97** </p>|



11. **Jan's Notation \*** 

Write a program that parses a series of instructions written in **postfix notation** and executes them (postfix means the operator is written **after** the operands). You will receive a **series of instructions** – if the instruction is a **number**, **save it**; otherwise, the instruction is an **arithmetic operator** (**+-\*/**) and you must apply it to the most two **most recently saved** numbers. **Discard** these two numbers and in their place, **save the result** of the operation – this number is now eligible to be an **operand** in a subsequent operation. Keep going until all input instructions have been exhausted, or you encounter an **error**. 

In the end, if you’re left with a **single saved number**, this is the **result** of the calculation and you must **print** it. If there are more numbers saved, then the user supplied **too many instructions** and you must print "**Error: too many operands!**". If at any point during the calculation you **don’t have** two number saved, the user supplied **too few instructions** and you must print "**Error: not enough operands!**".  *See the examples for more details.* 

**Input** 

You will receive an array with numbers **and** strings – the numbers will be **operands** and must be saved; the strings will be **arithmetic operators** that must be applied to the operands. 

**Output** 

Print on the **console** on a single line the **final result** of the calculation or an **error message**, as instructed above. 

**Constraints** 

- The **numbers** (operands) will be integers 
- The **strings** (operators) will always be one of **+-\*/** 
- The result of each operation will be in range [-253…253-1] (**MAX\_SAFE\_INTEGER** will **never** be exceeded) 

**Examples** 



|**Input** |**Output** |**Explanation** |
| - | - | - |
|[3,  4,  '+'] |7 |<p>The first instruction is a **number**, therefor we **save** it. The next one is also a **number**, we **save** it too. </p><p>The third instruction is a **string**, so it must be an **operator** – we **remove the last two** numbers we saved, and perform the operation: **3+4=7**. The result of this operation is then **saved** where the two operands **used to be**. </p><p>We’ve ran out of instructions, so we check the saved values – we only have **one**, so this must be **final result**. We **print** it on the console. </p>|
|[5,  3,  4,  '\*',  '-'] |-7 |<p>We save in order **5**, **3** and **4**. The result of the operation **3\*4** is **12**, which we **save in place** of **3** and **4**. </p><p>Currently we have **5** and **12** saved. The result of the operation **5-12** is **-7**, which we **save in place** of **5** and **12**. </p><p>We have no more instructions and **only one** value saved, which we **print**. </p>|
**Input  Output  Input  Output ![](Aspose.Words.6c75382a-3b2a-44d3-85f4-45c5610c8e1e.014.png)**


|[7,  33,  8,  '-'] |Error: too many operands! |
| :- | - |

|[15,  '/'] |Error: not enough operands! |
| :- | - |

