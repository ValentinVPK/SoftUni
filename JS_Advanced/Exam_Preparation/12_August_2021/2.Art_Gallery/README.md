**Problem 2. Art Gallery** 
Write a **class Art Gallery**, which supports the described functionality below. 

**Functionality Constructor** 

Should have these **4** properties: 

- **creator - string**  
- **possibleArticles - { "picture":200,"photo":50,"item":250 }** 
- **listOfArticles - empty array**  
- **guests - empty array** 

**At the initialization** of the **ArtGallery** class, the **constructor** accepts only the **creator!**  

The **possibleArticles** is an **object**, and the **submitted values** are **by default** and represent the **available article models** **("picture", "photo", "item")**, which** will be displayed in the gallery and the necessary points for purchasing a specific article. 

**Methods**  

**addArticle( articleModel, articleName, quantity )**

This method adds article to the art gallery. Method accepts 3 arguments: 

- **articleModel (string)**; 
- **articleName (string);** 
- **quantity (number)**; 
- If the **articleModel**, is not present in **possibleArticles** object with specified default models, an error with the following message should be thrown: 

**"This article model is not included in this gallery!"** 

**Note** that the resulting **articleModel** argument can be submitted in both **lowercase and uppercase letters** and will **be correct**, and no error should be thrown see the **example below**:  

**articleModel - ("picture") ->correct articleModel - ("Picture") ->correct** 

**articleModel - ("PICTURE") ->correct** 

- If the **articleName** already exists in **listOfArticles array** and** the **articleModel is the same** just add the new quantity to the old one. 
- Otherwise, should **add** the **articleModel, articleName, quantity** to **listOfArticles** array** in** following **format**: **{articleModel, articleName, quantity}.** The **articleModel** must be **toLowerCase().** 
- **And finally**, return the following message**:** 

**"Successfully added article {articleName} with a new quantity- {quantity}."** 

**inviteGuest ( guestName, personality)** 

` `Accept 2 arguments: **guestName (string), personality (string)** 

- If the **guestName** is already present in the **guests array**, throw a new error: 

`           `**"{guestName} has already been invited."** 

- Otherwise, **create a new record** in the **guests array** in **following format: {guestName, points, purchaseArticle: default 0}.** Where the **points** are the **points that the guest has.** With them he can buy an article. They are **determined depending on personality** (see the table below).** 

**Example- (**"**Ivan**"**,** "**Vip**"**)** -> **the points are 500  [** If you get a **personality** that is **not present in the table below**, **put 50 points (**"**Petar**"**,** "**Normal**"**)->50 points)];** 

**The property purchaseArticle** will record the number of **customer purchases, initially** at the invitation of the guest **the value is zero**. 

- Finally, return the message: 

`           `**"You have successfully invited {guestName}!"** 



|**Personality** |**Point** |
| - | - |
|**"Vip"** |**500** |
|**"Middle"** |**250** |

|||
| :- | :- |
|||
|||
**buyArticle ( articleModel, articleName, guestName)** 

Accept 3 arguments: **articleModel (string)**, **articleName (string)** and **guestName (string)**

- If the **articleName** is not found **in listOfArticles array or** the **articleModel doesn’t match**, throw a new error: 

`        `**"This article is not found."** 

- If the **quantity** of the current **article is equal to 0,** return message:                    **"The {articleName}** **is not available."** 
- If the **guestName** is not present in the **guests array,** return message: 

`               `**"This guest is not invited."** 

- Otherwise, you need to check if the **guest has the required number** of **points** to purchase the article. (The necessary points of the article are determined by the model in **possibleArticles array**) 
- If the **points** are **not enough to buy an article**, return the following message: 

**"You need to more points to purchase the article."** 

- If **they are enough**, you need to **reduce the current points of the guest** by according to the points of model article in **possibleArticles array,** **reduce the quantity** of the current article and **increase the number of purchases** of the guest. 
- Finally, return message: 

**"{guestName} successfully purchased the article worth {articlePoint} points."** 

The **articlePoint** is the value at which the article was purchased.   

**showGalleryInfo (criteria)** 

Accept 1 argument-**criteria.** This method **return gallery information** based on the criteria. Possible values for the **criterion** are two types:** 

- If the criterion is-**"article"-** then you need to **return** all the information about the articles saved in **listOfArticle** array in following format: 
- On first line show the following message: 

`   `**"Articles information:"** 

- On the lines, display information about each article: 

**{articleModel} - {articleName} - {quantity}**

- If the criterion is-**"guest"-** then you need to **return** all the information about the guests saved in **guest** array in following format: 
- On first line show the following message: 

`      `**"Guests information:"** 

- On the lines, display information about each guest: **{guestName} - {purchaseArticle}**  

