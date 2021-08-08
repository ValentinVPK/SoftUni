
**Lab: Prototypes and Inheritance** 

**1.Person** 

Write a JS program which takes **first** & **last** names as **parameters** and returns an object with **firstName**, **lastName** and **fullName** ( **"{firstName} {lastName}"** ) properties which should be all **accessible**, we discovered that "accessible" also means "mutable". This means that: 

- If **firstName** or **lastName** have changed, then **fullName** should also be changed. 
- If **fullName** is changed, then **firstName** and **lastName** should also be changed. 
- If **fullName** is **invalid**, you should not change the other properties. A **valid** **full name** is in the format 

**"{firstName} {lastName}"** 

**Examples** 



|**Sample Input** |
| - |
|**let person = new Person("Peter", "Ivanov"); console.log(person.fullName); *//Peter Ivanov* person.firstName = "George"; console.log(person.fullName); //George Ivanov person.lastName = "Peterson"; console.log(person.fullName); //George Peterson person.fullName = "Nikola Tesla"; console.log(person.firstName); //Nikola console.log(person.lastName); //Tesla** |
|**let person = new Person("Albert", "Simpson"); console.log(person.fullName); //Albert Simpson person.firstName = "Simon"; console.log(person.fullName); //Simon Simpson person.fullName = "Peter"; console.log(person.firstName);  // Simon console.log(person.lastName);  // Simpson** |
**2.Person and Teacher** 

Write a class **Person** and a class **Teacher** which extends **Person**.  

- The **Person** class should have a **name** and an **email** 
- The **Teacher** class should have a **name**, an **email**, and a **subject** 

**Input \ Output** 

There will be **NO** input. Your function should return an object containing the classes **Person** and **Teacher**. **Hints:** 

**template.js ![](Aspose.Words.8d7c3fea-c8db-45f8-aa44-abb88785c41b.001.png)**

**function** *personAndTeacher*() { ![](Aspose.Words.8d7c3fea-c8db-45f8-aa44-abb88785c41b.002.png)

*// **TODO:*** 
\*
`    `**return** { 

`        `***Person***,         ***Teacher***     } 

} 

**3.Inheriting and Replacing ToString** 

Extend the **Person** and **Teacher** from the previous task and add a class **Student** inheriting from **Person** with additional property **course**. Add **toString()** functions to all classes, the formats should be as follows: 

- **Person** - returns "**Person (name: {name}, email: {email})**" 
- **Student** - returns "**Student (name: {name}, email: {email}, course: {course})**" 
- **Teacher** - returns "**Teacher (name: {name}, email:{email}, subject:{subject})**" 

Try to reuse code by using the **toString()** function of the base class. 

**Input / Output** 

There will be **NO** input. Your function should return an object containing the classes **Person**, **Teacher** and **Student**. 

**Hints:** 

**template.js ![](Aspose.Words.8d7c3fea-c8db-45f8-aa44-abb88785c41b.003.png)**

**function** *toStringExtension***() {     *// TODO:***  
\*
`    `**return {** 

`        `***Person*,         *Teacher,         Student*     }** 

**}** 

**4.Extend Prototype** 

Write a function which receives a **class** and attaches to it a property **species** with value "**Human**" and a function **toSpeciesString()**. When called, the function returns a string with format: 

**"I am a <species>. <toString()>"** 

The function **toString()** is called from the current instance (call using **this**). 

**Input / Output** 

Your function will receive a **class** whose prototype it should extend. There is **NO** output, your function should only attach the properties to the given class’ prototype. 

**template.js ![](Aspose.Words.8d7c3fea-c8db-45f8-aa44-abb88785c41b.004.png)![](Aspose.Words.8d7c3fea-c8db-45f8-aa44-abb88785c41b.002.png)**

**function** *extendProrotype*(classToExtend) **{     *// TODO:*** 

**} ![](Aspose.Words.8d7c3fea-c8db-45f8-aa44-abb88785c41b.002.png)**

