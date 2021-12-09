**JS Advanced Final Exam** 

**Problem 1. Music Site** 



|**Environment Specifics** |
| - |
|Please, be aware that every JS environment may **behave differently** when executing code. Certain things that work |
|in the browser are not supported in **Node.js**, which is the environment used by **Judge**. |
|The following actions are **NOT** supported: |
|- **.forEach()** with **NodeList** (returned by **querySelector()** and **querySelectorAll()**) |
|- **.forEach()** with **HTMLCollection** (returned by **getElementsByClassName()** and **element.children**) |
|- Using the **spread-operator** (**...**) to convert a **NodeList** into an array |
|- **append()** in Judge (use only **appendChild()**) |
|- **replaceWith()** in Judge |
|- **replaceAll()** in Judge |
|- **closest()** in Judge |
|If you want to perform these operations, you may use **Array.from()** to first convert the collection into an array.  |
**Use the provided skeleton to solve this problem.**

**Note**: You **can't** and you have no permission to **change** directly the given HTML code (index.html file). 

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.001.jpeg)

**Your Task** 

**Write the missing JavaScript code** to make the **Music Site** work as expected: 

- A**ll fields (genre, name, author, and date)** are **filled with the correct input** 
  - **Genre, name, author, and date** are **non**-**empty** **strings** 
- The program should not do anything if any of the input fields are empty. 

**1. Getting the information about a new song** 

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.002.jpeg)

- When you click the **["Add"]** button, the information from the input fields must be added to the **div** with the **class** **"all-hits-container"** and then clear input fields.     

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.003.jpeg)

- The HTML structure looks like this: 

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.004.jpeg)

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.005.jpeg)

- When the **["Like song"]** button is clicked: 
- You need to take a value of the current number of **likes** inside the paragraph in the section with the id **"total-likes"** and increase the value by one. 

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.006.png)

- The button **["Like song"]** for the current song must then be **disabled**, as the user has the right to like the song only once (Once the button is **disabled**, its color will turn gray). 

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.007.jpeg)

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.008.jpeg)

- When the **["Save song"]** button is clicked, you need to move the current song in the **div** with **class** **"saved- container"**.  

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.009.jpeg)

- The HTML structure looks like this: 

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.010.jpeg)

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.011.jpeg)

- When you click the **["Delete"]** button, the song should be removed from the current section. **Note:** When deleting a song, you should not reduce the value of the current number of likes. 

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.012.jpeg)

- The HTML structure looks like this: 

![](Aspose.Words.905f5698-bb09-4a5f-a223-429de45e46e4.013.png)

**Submission** 

Submit only your **solve()** function. 

*GOOD LUCK…* J* 
