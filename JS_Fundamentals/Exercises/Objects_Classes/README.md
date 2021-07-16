
**Lab: Objects and Classes** 

1. **Person Info** 

Write a function that receives **3 parameters**, sets them to an **object** and **returns** that object. The input comes as **3 separate strings** in the following order: **firstName**, **lastName**, **age**. 

**Examples** 



|**Input** |**Object Properties** |
| - | - |function filterSongs(inputArray) {
  class Song {
    constructor(typeList, name,time){
      this.typeList = typeList;
      this.name = name;
      this.time = time;
    }
  }

  let n = Number(inputArray.shift());
  let filter = inputArray.pop();
  let songs = [];

  for(let song of inputArray) {
    let [typeList, name, time] = song.split('_');
    let currSong = new Song(typeList, name, time);
    songs.push(currSong);
  }

  if(filter === "all") {
    songs.forEach(x => console.log(x.name));
  }
  else {
    songs.filter(x => x.typeList === filter).forEach(x => console.log(x.name));
  }
}
|"Peter",  "Pan", "20" |firstName: Peter lastName: Pan age: 20 |
**Hints** 

![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.001.png)![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.002.png)

2. **City** 

Receive a **single** **parameter** – an **object**, containing **five properties**: 

**{ name, area, population, country, postcode }** 

Loop through all the **keys** and **print** them with their **values** in format: "**{key} -> {value}**" 

See the examples below. 

**Examples ![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.003.png)**



|**Input** |**Output** |
| - | - |
|<p>**{** </p><p>`    `**name: "Sofia",** </p><p>`    `**area: 492,** </p><p>`    `**population: 1238438,     country: "Bulgaria",** </p>|<p>**name -> Sofia** </p><p>**area -> 492 population -> 1238438 country -> Bulgaria postCode -> 1000** </p>|

|`    `**postCode: "1000" }** ||
| :- | :- |
3. **Convert to Object** 

Write a function that receives a **string** in **JSON format** and converts it to **object**. 

Loop through all the keys and print them with their values in format: "**{key}: {value}**" 

**Examples** 



|**Input** |**Output** |
| - | - |
|**'{"name": "George", "age": 40, "town": "Sofia"}'** |**name: George age: 40 town: Sofia** |
**Hints** 

- Use **JSON.parse()** method to parse JSON string to an object 

![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.004.png)![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.005.png)

4. **Convert to JSON** 

Write a Function That Receives Name, LastName, HairColor and Sets Them to an Object. Convert the **object** to **JSON string** and print it. 

Input is provided as **3 single strings** in the order stated above. 

**Examples** 



|**Input** |**Output** |
| - | - |
|**'George', 'Jones', 'Brown'** |**{"name":"George",  "lastName":"Jones",  "hairColor":"Brown"}** |
**Hints** 

- Use **JSON.stringify()** to parse the object to JSON string ![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.003.png)

![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.006.png)![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.007.png)

5. **Cats** 

Write a function that receives **array** of strings in the following format **'{cat name} {age}'**. Create a **Cat** **class** that receives in the **constructor** the **name** and the **age** parsed from the input.  

It should also have a function named **"meow"** that will print **"{cat name}, age {age} says Meow"** on the console. 

For each of the strings provided you must **create a cat object.** 

**Examples** 



|**Input** |**Output** |
| - | - |
|**['Mellow 2', 'Tom 5']** |**Mellow, age 2 says Meow Tom, age 5 says Meow** |
**Hints** 

- Create a Cat class with properties and methods described above 
- Parse the input data 
- Create all objects using class constructor and the parsed input data, store them in an array 
- Loop through the array using **for…of** cycle and **invoke .meow()** method 

![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.008.png)![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.009.jpeg)

6. **Songs** 

Define a **class** **Song**, which holds the following information about songs: **typeList**, **name** and **time**. You will receive the input as an **array**. ![](Aspose.Words.7ab883b2-489b-438a-a4e8-8502402c738c.003.png)

The first element **n** will be the number of songs. Next **n** elements will be the songs data in the following format: **"{typeList}\_{name}\_{time}"**, and the the last element will be **Type List** / **"all".** 

Print only the **names of the songs** which are from that **Type List** / **All songs**.  

**Examples** 



|**Input** |**Output** |
| - | - |
|<p>[3, </p><p>'favourite\_DownTown\_3:14', 'favourite\_Kiss\_4:16', 'favourite\_Smooth Criminal\_4:01', 'favourite'] </p>|<p>DownTown </p><p>Kiss </p><p>Smooth Criminal </p>|
|<p>[4, </p><p>'favourite\_DownTown\_3:14', 'listenLater\_Andalouse\_3:24', 'favourite\_In To The Night\_3:58', 'favourite\_Live It Up\_3:48', 'listenLater'] </p>|Andalouse |
|[2, 'like\_Replay\_3:15', 'ban\_Photoshop\_3:48', 'all'] |Replay Photoshop |


