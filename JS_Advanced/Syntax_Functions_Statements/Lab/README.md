
**Lab: Syntax, Functions and Statements** 

1. **Echo Function** 

Write a JS function that takes **one string parameter** and **prints** on two lines the **length** of the parameter and then the **unchanged parameter** itself. 

**Examples** 



|**Input** |**Output** |
| - | - |
|'Hello, JavaScript!' |<p>18 </p><p>Hello, JavaScript! </p>|
|'strings are easy' |<p>16 </p><p>strings are easy </p>|

2. **String Length** 

Write a JS function that takes **three** **string arguments** as an input.  

Calculate the **sum** of the **length** of the **strings** and the **average length** of the strings **rounded** **down** to the nearest integer. 

The **input** comes as **three string arguments** passed to your function. The **output** should be printed on the console on two lines. 

**Examples** 



|**Input** |**Output** |
| - | - |
|'chocolate', 'ice cream', 'cake' |22 7 |
|'pasta', '5', '22.3' |10 3 |


3. **Largest Number** 

Write a function that takes **three number arguments** as an input and find the **largest** of them. Print the following text on the console:  '**The largest number is {number}.**'. 

The **input** comes as **three number arguments** passed to your function. The **output** should be printed to the console. 

**Example** 



|**Input** |**Output** |
| - | - |
|5, -3, 16 |The largest number is 16. |
|-3, -5, -22.5 |The largest number is -3. |


**Example** 


|**Input** |**Output** |
| - | - |
|5 |78.54 |
|'name' |We can not calculate the circle area, because we receive a string. |


5. **Math Operations** 

Write a JS function that takes **two** **numbers** and **a string** as an input.  The string may be one of the following: '**+**', '**-**', '**\***', '**/**', '**%**', '**\*\***'.   

Print on the console the result of the mathematical **operation** between **both numbers** and the **operator** you receive as a string. 

The **input** comes as **two numbers** and **a string argument** passed to your function. The **output** should be printed on the console. 

**Examples** 



|**Input** |**Output** |
| - | - |
|5, 6, '+' |11 |
|3, 5.5, '\*' |16.5 |

6. **Sum of Numbers N…M** 

Write a JS function that takes two numbers **n** and **m** as an input and **prints the sum** of all numbers from **n** to **m**. 

The **input** comes as **two string elements** that need to be **parsed** as numbers. The **output** should **return** the **sum**. 

**Examples** 



|**Input** |**Output** |
| - | - |
|'1', '5'  |15 |
|'-8', 20' |174 |


7. **Day of Week** 

Write a function that prints a number between 1 and 7 when a **day of the week** is passed to it as a string and an **error message** if the string is **not recognized**. 

The **input** comes as a single string argument. The **output** should be returned as a result. 

**Examples** 



|**Input** |**Output** |
| - | - |
|Monday |1 |
|Friday |5 |
|Invalid |error |
8. **Square of Stars** 

Write a function that **prints a rectangle** made of **stars** with variable **size**, depending on an input parameter. If there is **no parameter** specified, the rectangle should **always** be of **size 5**. Look at the examples to get an idea. 

The **input** comes as a single **number** argument. 

The **output** is a series of lines printed on the console, forming a rectangle of variable size. 

**Examples** 



|**Input** |**Output** |
| - | - |
|1 |\* |

|**Input** |**Output** |
| - | - |
|2 |<p>* \* </p><p>* \* </p>|

|**Input** |**Output** |
| - | - |
|5 |<p>* \* \* \* \* </p><p>* \* \* \* \* </p><p>* \* \* \* \* </p><p>* \* \* \* \* </p><p>* \* \* \* \* </p>|

|**Input** |**Output** |
| - | - |
||<p>* \* \* \* \* </p><p>* \* \* \* \* </p><p>* \* \* \* \* </p><p>* \* \* \* \* </p><p>* \* \* \* \* </p>|
9. **Aggregate Elements** 

Write a program that performs different operations on an array of elements. Implement the following operations: 

- **Sum(ai)** - calculates the sum all elements from the input array** 
- **Sum(1/ai)** - calculates the sum of the inverse values (1/ai) of all elements from the array ![](Aspose.Words.68f14cf2-a353-494a-a881-bafe38ae755c.001.png)
- **Concat(ai)** - concatenates the string representations of all elements from the array** 

The **input** comes as an array of number elements. 

The **output** should be printed on the console on a new line for each of the operations. 

**Examples ![](Aspose.Words.68f14cf2-a353-494a-a881-bafe38ae755c.001.png)**



|**Input** |**Output** |
| - | - |
|[1, 2, 3] |6 1.8333 123 |

|**Input** |**Output** |
| - | - |
|[2, 4, 8, 16] |30 0.9375 24816 |

