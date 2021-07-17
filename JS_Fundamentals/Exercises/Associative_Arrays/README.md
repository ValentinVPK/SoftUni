
**Lab: Associative Arrays** 


1. **Phone Book** 

Write a function that stores information about a **person’s name** and his **phone number**. The input comes as an **array of strings**. Each string contains the name and the number. If you receive the same name **twice** just **replace** the number. At the end print the result **without sorting it**. Try using an **associative array.** 

**Example** 



|**Input** |**Output** |
| - | - |
|**['Tim 0834212554', 'Peter 0877547887', 'Bill 0896543112', 'Tim 0876566344']** |**Tim -> 0876566344Peter -> 0877547887 Bill -> 0896543112** |
2. **Meetings** 

Write a function that manages meeting appointments. The input comes as an **array of strings**. Each string contains a **weekday** and person’s **name**. For each **successful** meeting, **print a message**. If you receive the **same weekday** twice, the meeting cannot be scheduled so print a **conflict message**. At the end print a list of all **successful** meetings. See example for message format and details. 

**Example** 



|**Input** |**Output** |
| - | - |
|<p>**['Monday Peter',  'Wednesday Bill',  'Monday Tim',** </p><p>` `**'Friday Tim']** </p>|**Scheduled for Monday Scheduled for Wednesday Conflict on Monday! Scheduled for Friday Monday -> Peter Wednesday -> Bill Friday -> Tim** |
3. **Address Book** 

Write a function that stores information about a person’s **name** and his **address**. The input comes as an **array of strings**. Each string contains the **name** and the **address** separated by a **colon**. If you receive the same name **twice** just **replace** the address. At the end print the full list, **sorted alphabetically** by the person’s name. ![](Aspose.Words.f4a4c1a6-0132-4b21-9482-b6825f5d6782.001.png)



|**Input** |**Output** |
| - | - |
|**['Tim:Doe Crossing',  'Bill:Nelson Place',  'Peter:Carlyle Ave',  'Bill:Ornery Rd']** |**Bill -> Ornery Rd Peter -> Carlyle Ave Tim -> Doe Crossing** |
4. **Storage** 

Write a function that takes a certain number of **items** and their **quantity**. If the same item appears **more than once**, **add the new amount** to the **existing one**. At the end print all the items and their amount without sorting them. The input comes as **array of strings**. Try using a **Map()**. 

**Example** 



|**Input** |**Output** |
| - | - |
|**['tomatoes 10', 'coffee 5', 'olives 100', 'coffee 40']** |**tomatoes -> 10 coffee -> 45 olives -> 100** |

5. **School Grades** 

Write a function to store students with all of their grades. If a student appears more than once, add the new grades. At the end print the students sorted by average grade. The input comes as **array of strings**. 

**Example** 



|**Input** |**Output** |
| - | - |
|**['Lilly 4 6 6 5', 'Tim 5 6', 'Tammy 2 4 3', 'Tim 6 6']** |**Tammy: 2, 4, 3 Lilly: 4, 6, 6, 5 Tim: 5, 6, 6, 6** |

6. **Word Occurrences** 

Write a function that **counts** the times each **word occurs** in a text. Print the words **sorted by count** in **descending** order. The input comes as an **array of strings**. 

**Example** 



|**Input** |**Output** |
| - | - |
|**["Here", "is", "the", "first", "sentence", "Here", "is", "another", "sentence", "And", "finally", "the", "third", "sentence"]** |<p>**sentence -> 3 times Here -> 2 times** </p><p>**is -> 2 times** </p><p>**the -> 2 times first -> 1 times another -> 1 times And -> 1 times finally -> 1 times third -> 1 times** </p>|

7. **Neighborhoods** 

Write a function that receives **list of neighborhoods** and then some **people**, who are going to live in it. The **input** will come as **array of strings**. The **first element** will be the list of neighborhoods **separated** by **", "**. The rest of the element**s** will be a neighborhood followed by a **name** of a person in the format **"{neighborhood} - {person}"**. **Add** the** person to the neighborhood **only** if the neighborhood is in** the **list** of neighborhoods. The order of the elements as they are created should stay the same. At the end print the neighborhoods **sorted** by the count of inhabitants in descending order. Print them in the following format:  

**"{neighborhood}: {inhabitants count} --{1st inhabitant}** 

**--{2nd inhabitant}** 

**…" ![](Aspose.Words.f4a4c1a6-0132-4b21-9482-b6825f5d6782.001.png)**

**Example** 



|**Input** |**Output** |
| - | - |
|<p>**['Abbey Street, Herald Street, Bright Mews', 'Bright Mews - Garry',** </p><p>**'Bright Mews - Andrea',** </p><p>**'Invalid Street - Tommy',** </p><p>**'Abbey Street - Billy']** </p>|<p>**Bright Mews: 2 --Garry --Andrea** </p><p>**Abbey Street: 1 --Billy** </p><p>**Herald Street: 0** </p>|

