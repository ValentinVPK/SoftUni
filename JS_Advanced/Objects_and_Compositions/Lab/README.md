
**Lab: Objects & Composition** 


1. **City Record** 

You will receive a city’s **name** (string), **population** (number), and **treasury** (number)** as arguments, which you will need to set as **properties** of an **object** and **return** it. 

**Examples** 



|**Input** |**Output** |
| - | - |
|'Tortuga', 7000, 15000 |<p>{ </p><p>`  `name: 'Tortuga',   population: 7000,   treasury: 15000 } </p>|
|<p>'Santo Domingo', 12000, </p><p>23500 </p>|<p>{ </p><p>`  `name: 'Santo Domingo',   population: 12000, </p><p>`  `treasury: 23500 </p><p>} </p>|
2. **Town Population** 

You have been tasked to create a registry for different **towns** and their **population**. 

**Input** 

The **input** comes as array of strings. Each element will contain data for a town and its population in the following format: **"{townName} <-> {townPopulation}"** 

If you receive the same town twice, **you should add** the **given population** to the **current one**. 

**Output** 

As **output**, you must print all the towns, and their population. 

**Examples ![](Aspose.Words.612a14f9-33f7-43ba-ae2f-430394275d39.001.png)**



|**Input** |**Output** |
| - | - |
|['Sofia <-> 1200000', 'Montana <-> 20000', 'New York <-> 10000000', 'Washington <-> 2345000', 'Las Vegas <-> 1000000'] |<p>Sofia : 1200000 Montana : 20000 </p><p>New York : 10000000 Washington : 2345000 Las Vegas : 1000000 </p>|
|['Istanbul <-> 100000', 'Honk Kong <-> 2100004', 'Jerusalem <-> 2352344', 'Mexico City <-> 23401925', 'Istanbul <-> 1000'] |<p>Istanbul : 101000 Honk Kong : 2100004 </p><p>Jerusalem : 2352344 Mexico City : 23401925 </p>|
3. **City Taxes** 

*This task is an extension of Problem 1, you may use your solution from that task as a base.* 

You will receive a city’s **name** (string), **population** (number), and **treasury** (number)** as arguments, which you will need to set as **properties** of an **object** and **return** it. In addition to the input parameters, the object must have a property **taxRate** with initial value **10**, and three **methods** for managing the city: 

- **collectTaxes() -** Increase **treasury** by  **population** \* **taxRate** 
- **applyGrowth(percentage) -** Increase population by **given percentage** 
- **applyRecession(percentage) -** Decrease treasury by **given percentage** 

Round down the values after each calculation. 

**Input** 

Your solution will receive three valid parameters. The methods that expect parameters will be tested with valid input. 

**Output** 

Return an object as described above. The methods of the object modify the object and don’t return anything. 



|**Input** |**Output** |
| - | - |
|<p>const city =  </p><p>`  `cityTaxes('Tortuga',   7000, </p><p>`  `15000); console.log(city); </p>|<p>{ </p><p>`  `name: 'Tortuga', </p><p>`  `population: 7000, </p><p>`  `treasury: 15000, </p><p>`  `taxRate: 10, </p><p>`  `collectTaxes: [Function: collectTaxes], </p><p>`  `applyGrowth: [Function: applyGrowth], </p><p>`  `applyRecession: [Function: applyRecession] } </p>|
|**Testing with code** |
|**Input** |**Output** |
|<p>const city = </p><p>`  `cityTaxes('Tortuga', </p><p>`  `7000, </p><p>`  `15000); city.collectTaxes(); console.log(city.treasury); city.applyGrowth(5); console.log(city.population); </p>|85000 7350 |
4. **Object Factory** 

Create a function that can compose objects by copying functions from a given library of functions. You will receive **two** **parameters** – a **library** of functions as an associative array (object) and an **array of orders**, represented as objects**.** You must **return** a new array – the fulfilled orders.** 

The **first parameter** will be an object where each property is a **function**. You will use this **library of functions** to compose new objects. ![](Aspose.Words.612a14f9-33f7-43ba-ae2f-430394275d39.001.png)

The **second parameter** is an **array of orders**. Each order is an **object** with the following shape: 

**{** 

`  `**template: [Object],   parts: string[]** 

**}** 

The **template** is an object that must be **copied**. The **parts array** contains the names of **required functions** as **strings**. 

You must **create and return a new array**, by fulfilling all orders from the **orders array**. To fulfill an order, create a copy of the object’s template and then add to it all functions, listed in the **parts array** of the order, by taking them from the **function library** (first parameter to your solution). 

**Input** 

You will receive two parameters: 

- **library** – an object 
- **orders** – an array of objects 

**Output** 

Your solution must **return an array** of objects. 

**Example ![](Aspose.Words.612a14f9-33f7-43ba-ae2f-430394275d39.001.png)**



|**Input** |
| - |
|<p>const **library** = { </p><p>`  `print: function () { </p><p>`    `console.log( ${this.name} is printing a page ); </p><p>`  `}, </p><p>`  `scan: function () { </p><p>`    `console.log( ${this.name} is scanning a document ); </p><p>`  `}, </p><p>`  `play: function (artist, track) { </p><p>`    `console.log( ${this.name} is playing '${track}' by ${artist} );   }, </p><p>}; </p><p>const **orders** = [ </p><p>`  `{ </p><p>`    `template: { name: 'ACME Printer'}, </p><p>`    `parts: ['print']       </p><p>`  `}, </p><p>`  `{ </p><p>`    `template: { name: 'Initech Scanner'},     parts: ['scan']       </p><p>`  `}, </p><p>`  `{ </p><p>`    `template: { name: 'ComTron Copier'},     parts: ['scan', 'print']       </p><p>`  `}, </p><p>`  `{ </p><p>`    `template: { name: 'BoomBox Stereo'},     parts: ['play']       </p><p>`  `}, </p><p>]; </p>|

|const products = factory(**library**, **orders**); console.log(products);** |
| :- |
|**Output** |
|<p>[ </p><p>`  `{ </p><p>`    `name: 'ACME Printer', </p><p>`    `print: [Function: print]   }, </p><p>`  `{ </p><p>`    `name: 'Initech Scanner',     scan: [Function: scan]   }, </p><p>`  `{ </p><p>`    `name: 'ComTron Copier',     scan: [Function: scan],     print: [Function: print]   }, </p><p>`  `{ </p><p>`    `name: 'BoomBox Stereo',     play: [Function: play]   }, </p><p>] </p>|
5. **Assembly Line** 

Create a function that **returns** a **library of decorator functions**. They can be used to **compose** different functionality in a **car object** that they receive as argument. 

Your solution must **return an object**, containing **three decorator functions**: 

**hasClima** – compose air conditioning controls into the passed in object. This function takes an **object as parameter** and adds to it the following properties: 

- **temp** – **number** with default value **21**; 
- **tempSettings** – **number** with default value **21**; 
- **adjustTemp** – **function** which takes **no arguments**. If **temp** is less than **tempSettings**, this function adds 1 to **temp**. If **temp** is more than **tempSettings**, it decreases **temp** by 1. If **temp** and **tempSettings** are equal, the function does nothing. 

**hasAudio** – compose audio player functionality into the passed in object. This function takes an **object as parameter** and adds to it the following properties: 

- **currentTrack** – **object** with properties **name** (string) and **artist** (string). Default value is **null**; 
- **nowPlaying** – **function**, which **prints** on the console the text **"Now playing '{currentTrack.name}' by ${currentTrack.artist}"**, where **name** and **artist** are properties of the **currentTrack** object. If **currentTrack** is **null**, this function does nothing. 

**hasParktronic** – compose parking aid functionality into the passed in object. This function takes an **object as parameter** and adds to it the following properties: 

- **checkDistance** – **function**, which takes a **single argument** **distance** (number) and **prints** a message on the console, depending on its value: ![](Aspose.Words.612a14f9-33f7-43ba-ae2f-430394275d39.001.png)

**distance** < 0.1 – **"Beep! Beep! Beep!"** 

0.1 <= **distance** < 0.25 – **"Beep! Beep!"** 

0.25 <= **distance** < 0.5 – **"Beep!"** 

In any other case, print an **empty string**. 

**Input** 

Your **solution** will receive **no arguments**. All the methods in the returned library must take an **object as argument**. Any methods that you compose into this object must meet the input requirements listed in the description above. 

**Output** 

Your **solution** must **return an object** containing the **three decorators** described above. 

**Example ![](Aspose.Words.612a14f9-33f7-43ba-ae2f-430394275d39.001.png)**



|**Setup** |
| - |
|<p>const **assemblyLine** = createAssemblyLine(); </p><p>const **myCar** = { </p><p>`    `make: 'Toyota',     model: 'Avensis' }; </p>|
|**Input** |**Output** |
|**assemblyLine**.hasClima(**myCar**); console.log(**myCar**.temp); **myCar**.tempSettings = 18; **myCar**.adjustTemp(); console.log(**myCar**.temp);** |21 20** |
|**Input** |**Output** |
|<p>**assemblyLine**.hasAudio(**myCar**); **myCar**.currentTrack = { </p><p>`    `name: 'Never Gonna Give You Up',     artist: 'Rick Astley' </p><p>}; </p><p>**myCar**.nowPlaying(); </p>|Now playing 'Never Gonna Give You Up' by Rick Astley |
|**Input** |**Output** |
|**assemblyLine**.hasParktronic(**myCar**); **myCar**.checkDistance(0.4); **myCar**.checkDistance(0.2);** |Beep! Beep! Beep! |
|**Input** |**Output** |
|console.log(**myCar**); |<p>{ </p><p>`  `make: 'Toyota', </p><p>`  `model: 'Avensis', </p><p>`  `temp: 20, </p><p>`  `tempSettings: 18, </p><p>`  `adjustTemp: [Function], </p><p>`  `currentTrack: { </p><p>`    `name: 'Never Gonna Give You Up',     artist: 'Rick Astley' </p><p>`  `}, </p><p>`  `nowPlaying: [Function], </p>|

||`  `checkDistance: [Function] } |
| :- | :- |
6. **From JSON to HTML Table** 

You’re tasked with creating an HTML table of students and their scores. You will receive a single string representing an **array of objects**, the **table’s headings** should be equal to the **object’s keys**, while **each object’s values** should be a **new entry** in the table. Any **text values** in an object should be **escaped**, in order to avoid introducing dangerous code into the HTML.  

**Input** 

The **input** comes a **single string argument** (the array of objects). 

**Output** 

The **output** should be printed on the console – for each **entry** **row** in the input print the **object** **representing** **it**. **Note:** 



|**Input** |**Output** |
| - | - |
|'[{"Name":"Stamat",     "Score":5.5},    {"Name":"Rumen",     "Score":6}]' |<p><table> </p><p>`   `<tr><th>Name</th><th>Score</th></tr>    <tr><td>Stamat</td><td>5.5</td></tr>    <tr><td>Rumen</td><td>6</td></tr> </table> </p>|
|<p>'[{"Name":"Pesho",     "Score":4, </p><p>- Grade":8}, </p><p>`   `{"Name":"Gosho",     "Score":5, </p><p>- Grade":8}, </p><p>`   `{"Name":"Angel",     "Score":5.50, </p><p>- Grade":10}]' </p>|<p><table> </p><p>`   `<tr><th>Name</th><th>Score</th><th>Grade</th></tr>    <tr><td>Pesho</td><td>4</td><td>8</td></tr> </p><p>- tr><td>Gosho</td><td>5</td><td>8</td></tr> </p><p>- tr><td>Angel</td><td>5.5</td><td>10</td></tr> </p><p></table> </p>|


