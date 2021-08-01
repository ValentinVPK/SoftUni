
function solution(command) {
  const commands = {
    upvote: () => {
      this.upvotes++;
      //console.log(this.upvotes);
    },

    downvote: () => {
      this.downvotes++;
      //console.log(this.downvotes);
    },

    score: () => {
      let rating;
      let balance = this.upvotes - this.downvotes;
      let totalVotes = this.upvotes + this.downvotes;

      if(totalVotes < 10) {
        rating = 'new';
      } else if(this.upvotes > 0.66 * (totalVotes)) {
        rating = 'hot';
      } else if(balance >= 0 && (totalVotes) > 100) {
        rating = 'controversial';
      } else if(balance < 0) {
        rating = 'unpopular';
      } else {
        rating = 'new';
      }

      let alternativeUpvotes = totalVotes > 50 ? Math.ceil(this.upvotes + 0.25 * Math.max(this.upvotes, this.downvotes)) : this.upvotes;
      let alternativeDownvotes = totalVotes > 50 ? Math.ceil(this.downvotes + 0.25 * Math.max(this.upvotes, this.downvotes)) : this.downvotes;

      return [alternativeUpvotes, alternativeDownvotes, balance, rating];
    }
  }

  return commands[command]();
}

let post = {
  id: '3',
  author: 'emil',
  content: 'wazaaaaa',
  upvotes: 100,
  downvotes: 100
};
solution.call(post, 'upvote');
solution.call(post, 'downvote');
let score = solution.call(post, 'score'); // [127, 127, 0, 'controversial']
console.log(score);
for (let index = 0; index < 50; index++) {
  solution.call(post, 'downvote');
} 
score = solution.call(post, 'score');     // [139, 189, -50, 'unpopular']
console.log(score);
