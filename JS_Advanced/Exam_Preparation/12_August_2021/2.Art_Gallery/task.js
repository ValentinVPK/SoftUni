
class ArtGallery {
  constructor(creator) {
    this.creator = creator;
    this.possibleArticles = { "picture":200,"photo":50,"item":250 };
    this.listOfArticles = [];
    this.guests = [];
  }

  addArticle( articleModel, articleName, quantity ) {
    articleModel = articleModel.toLowerCase();
    
    if(!Object.keys(this.possibleArticles).includes(articleModel)) {
      throw new Error('This article model is not included in this gallery!');
    }

    // {articleModel, articleName, quantity}

    if(!this.listOfArticles.some(x => x.articleName === articleName)) {
      this.listOfArticles.push({articleModel, articleName, quantity});
      return `Successfully added article ${articleName} with a new quantity- ${quantity}.`;
    }

    let wantedArticle = this.listOfArticles.find(x => x.articleName === articleName);
    wantedArticle.quantity += quantity;

    return `Successfully added article ${wantedArticle.articleName} with a new quantity- ${wantedArticle.quantity}.`;
  }

  inviteGuest( guestName, personality) {
    //guest - {guestName, points, purchaseArticle: default 0}
    if(this.guests.some(x => x.guestName === guestName)) {
      throw new Error(`${guestName} has already been invited.`);
    }

    let points = 0;
    if(personality === 'Vip') {
      points = 500;
    } else if(personality === 'Middle') {
      points = 250;
    } else {
      points = 50;
    }

    const newGuest = {guestName, points, purchaseArticle: 0};
    this.guests.push(newGuest);

    return `You have successfully invited ${guestName}!`;
  }

  buyArticle( articleModel, articleName, guestName) {
    articleModel = articleModel.toLowerCase();
    if(!this.listOfArticles.some(x => x.articleName === articleName)) {
      throw new Error('This article is not found.');
    }

    let wantedArticle = this.listOfArticles.find(x => x.articleName === articleName);

    if(wantedArticle.articleModel !== articleModel) {
      throw new Error('This article is not found.');
    }

    if(wantedArticle.quantity === 0) {
      return `The ${articleName} is not available.`;
    }

    if(!this.guests.some(x => x.guestName === guestName)) {
      return 'This guest is not invited.';
    }

    let wantedGuest = this.guests.find(x => x.guestName === guestName);

    if(wantedGuest.points < this.possibleArticles[articleModel]) {
      return 'You need to more points to purchase the article.';
    }

    wantedGuest.points -= this.possibleArticles[articleModel];
    wantedGuest.purchaseArticle++;

    wantedArticle.quantity--;

    return `${guestName} successfully purchased the article worth ${this.possibleArticles[articleModel]} points.`;
  }

  showGalleryInfo(criteria) {
    let result = [];
    if(criteria === 'article') {
      result.push('Articles information:');
      for (const article of this.listOfArticles) {
        result.push(`${article.articleModel} - ${article.articleName} - ${article.quantity}`);
      }
    } else if(criteria === 'guest') { 
      result.push('Guests information:');
      for (const guest of this.guests) {
        result.push(`${guest.guestName} - ${guest.purchaseArticle}`);
      }
    }

    return result.join('\n');
  }
}

// const artGallery = new ArtGallery('Curtis Mayfield');
// console.log(artGallery.addArticle('picture', 'Mona Liza', 3));
// console.log(artGallery.addArticle('Item', 'Ancient vase', 2));
// console.log(artGallery.addArticle('PICTURE', 'Mona Liza', 1));

// const artGallery = new ArtGallery('Curtis Mayfield');
// console.log(artGallery.inviteGuest('John', 'Vip'));
// console.log(artGallery.inviteGuest('Peter', 'Middle'));
// console.log(artGallery.inviteGuest('John', 'Middle'));

// const artGallery = new ArtGallery('Curtis Mayfield');
// artGallery.addArticle('picture', 'Mona Liza', 3);
// artGallery.addArticle('Item', 'Ancient vase', 2);
// artGallery.addArticle('picture', 'Mona Liza', 1);
// artGallery.inviteGuest('John', 'Vip');
// artGallery.inviteGuest('Peter', 'Middle');
// console.log(artGallery.buyArticle('picture', 'Mona Liza', 'John'));
// console.log(artGallery.buyArticle('item', 'Ancient vase', 'Peter'));
// console.log(artGallery.buyArticle('item', 'Mona Liza', 'John'));

const artGallery = new ArtGallery('Curtis Mayfield'); 
artGallery.addArticle('picture', 'Mona Liza', 3);
artGallery.addArticle('Item', 'Ancient vase', 2);
artGallery.addArticle('picture', 'Mona Liza', 1);
artGallery.inviteGuest('John', 'Vip');
artGallery.inviteGuest('Peter', 'Middle');
artGallery.buyArticle('picture', 'Mona Liza', 'John');
artGallery.buyArticle('item', 'Ancient vase', 'Peter');
console.log(artGallery.showGalleryInfo('article'));
console.log(artGallery.showGalleryInfo('guest'));

