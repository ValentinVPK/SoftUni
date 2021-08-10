
class Story {
  constructor(title, creator) {
    this.title = title;
    this.creator = creator;
    this._comments = [];
    this._likes = [];
  }

  get likes() {
    if(this._likes.length === 0) {
      return `${this.title} has 0 likes`;
    }

    let username = this._likes[0];
    if(this._likes.length === 1) {
      return `${username} likes this story!`;
    }

    return `${username} and ${this._likes.length - 1} others like this story!`;
  }

  like(username) {
    if(this._likes.includes(username)) {
      throw new Error("You can't like the same story twice!");
    }

    if(this.title === username) {
      throw new Error("You can't like your own story!");
    }

    this._likes.push(username);
    return `${username} liked ${this.title}!`;
  }

  dislike(username) {
    if(!this._likes.includes(username)) {
      throw new Error("You can't dislike this story!");
    }

    this._likes.splice(this._likes.indexOf(username), 1);
    return `${username} disliked ${this.title}`;
  }

  comment(username, content, id) {
    if(id === undefined || !this._comments.some(x => x.Id === id)) {

      const newComment = {
        Id: this._comments.length + 1,
        Username: username,
        Content: content,
        Replies: []
      };

      this._comments.push(newComment);

      return `${username} commented on ${this.title}`;
    }

    let wantedComment = this._comments.find(x => x.Id === id);

    const newReply = {
      Id: Number(`${wantedComment.Id}.${wantedComment.Replies.length + 1}`),
      Username: username,
      Content: content
    };

    wantedComment.Replies.push(newReply);

    return "You replied successfully";
  }

  toString(sortingType) {
    const sortingObject = {
      asc: (a,b) => a.Id - b.Id,
      desc: (a,b) => b.Id - a.Id,
      username: (a,b) => a.Username.localeCompare(b.Username)
    };

    let result = `Title: ${this.title}\nCreator: ${this.creator}\nLikes: ${this._likes.length}\nComments:`;

    for (const comment of this._comments.sort(sortingObject[sortingType])) {
      result += `\n-- ${comment.Id}. ${comment.Username}: ${comment.Content}`;
      for (const reply of comment.Replies.sort(sortingObject[sortingType])) {
        result += `\n--- ${reply.Id}. ${reply.Username}: ${reply.Content}`;
      }
    }

    return result;
  }
}

let art = new Story("My Story", "Anny");
art.like("John");
console.log(art.likes);
art.dislike("John");
console.log(art.likes);
art.comment("Sammy", "Some Content");
console.log(art.comment("Ammy", "New Content"));
art.comment("Zane", "Reply", 1);
art.comment("Jessy", "Nice :)");
console.log(art.comment("SAmmy", "Reply@", 1));
console.log()
console.log(art.toString('username'));
console.log()
art.like("Zane");
console.log(art.toString('desc'));
