
**Lab: Regular Expressions** 

1. **Match Full Name** 

Write a JavaScript function to **match full names** from a list of names and **print** them on the console. **Writing the Regular Expression** 

First, write a regular expression to match a valid full name, according to these conditions: 

- A valid full name has the following characteristics: 
- It consists of **two words**. 
- Each word **starts** with a **capital letter**. 
- After the first letter, it **only contains lowercase letters afterwards**. 
- **Each** of the **two words** should be **at least two letters long**. 
- The **two words** are **separated** by a **single space**. 



|**Match ALL of these** |**Match NONE of these** |
| - | - |
|Ivan Ivanov |ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan  Ivanov |
**Examples** 



|**Input** |
| - |
|"Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan  Ivanov"|
|**Output** |
|Ivan Ivanov Test Testov |
2. **Match Phone Number** 

Write a regular expression to match a **valid phone number** from **Sofia**. After you find all **valid phones**, **print** them on the console, separated by a **comma and a space ", "**. 

**Compose the Regular Expression** 

A valid number has the following characteristics: 

- It starts with **"+359"** 
- Then, it is followed by the area code (always **2**) 
- After that, it’s followed by the **number** itself: 
  - The number consists of **7 digits** (separated in **two** **groups** of **3** and **4** **digits** respectively).  
- The different **parts** are **separated** by **either a space or a hyphen** (**'-'**). 

You can use the following table of values to test your RegEx against: ![](Aspose.Words.91a0c6bd-5bfe-40d5-9ab8-004cc35e5f98.001.png)



|**Match ALL of these** |**Match NONE of these** |
| - | - |
|+359 2 222 2222 +359-2-222-2222 |359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 |
**Examples** 



|**Input** |
| - |
|"+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222" |
|**Output** |
|+359 2 222 2222, +359-2-222-2222 |
3. **Match Dates** 

Write a program, which matches a date in the format **"dd{separator}MMM{separator}yyyy"**. 

**Compose the Regular Expression** 

Every valid date has the following characteristics: 

- Always starts with **two digits**, followed by a **separator** 
- After that, it has **one uppercase** and **two lowercase** letters (e.g. **Jan**, **Mar**). 
- After that, it has a **separator** and **exactly 4 digits** (for the year). 
- The separator could be either of three things: a period (**"."**), a hyphen (**"-"**) or a forward slash (**"/"**) 
- The separator needs to be **the same** for the whole date (e.g. 13**.**03**.**2016 is valid, 13**.**03**/**2016 is **NOT**). Use a **group backreference** to check for this. 

You can follow the table below to help with composing your RegEx: 



|**Match ALL of these** |**Match NONE of these** |
| - | - |
|13/Jul/1928, 10-Nov-1934, 25.Dec.1937 |01/Jan-1951, 23/sept/1973, 1/Feb/2016 |
**Examples ![](Aspose.Words.91a0c6bd-5bfe-40d5-9ab8-004cc35e5f98.001.png)**



|**Input** |
| - |
|"13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016" |
|**Output** |
|Day: 13, Month: Jul, Year: 1928 Day: 10, Month: Nov, Year: 1934 Day: 25, Month: Dec, Year: 1937 |

