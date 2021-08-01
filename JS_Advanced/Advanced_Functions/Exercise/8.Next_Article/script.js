function getArticleGenerator(articles) {
    
    return function() {
        if(articles.length === 0) {
            return;
        }
        let currArticle = articles.shift();
        let articleElement = document.createElement('article');
        articleElement.textContent = currArticle;

        document.querySelector('#content').appendChild(articleElement);
    }
}
