const library = {
  calcPriceOfBook(nameOfBook, year) {

      let price = 20;
      if (typeof nameOfBook != "string" || !Number.isInteger(year)) {
          throw new Error("Invalid input");
      } else if (year <= 1980) {
          let total = price - (price * 0.5);
          return `Price of ${nameOfBook} is ${total.toFixed(2)}`;
      }
      return `Price of ${nameOfBook} is ${price.toFixed(2)}`;
  },

  findBook: function(booksArr, desiredBook) {
      if (booksArr.length == 0) {
          throw new Error("No books currently available");
      } else if (booksArr.find(e => e == desiredBook)) {
          return "We found the book you want.";
      } else {
          return "The book you are looking for is not here!";
      }

  },
  arrangeTheBooks(countBooks) {
      const countShelves = 5;
      const availableSpace = countShelves * 8;

      if (!Number.isInteger(countBooks) || countBooks < 0) {
          throw new Error("Invalid input");
      } else if (availableSpace >= countBooks) {
          return "Great job, the books are arranged.";
      } else {
          return "Insufficient space, more shelves need to be purchased.";
      }
  }

};

const {assert} = require('chai');

describe("Tests library", function() {
  describe("calcPriceOfBook", function() {
      it("Throws error if name of book isnt a string", function() {
          let name = 5;

          assert.throws(() => library.calcPriceOfBook(name, 0), Error, 'Invalid input');

          name = true;
          assert.throws(() => library.calcPriceOfBook(name, 0), Error, 'Invalid input');

          name = [];
          assert.throws(() => library.calcPriceOfBook(name, 0), Error, 'Invalid input');

          name = {};
          assert.throws(() => library.calcPriceOfBook(name, 0), Error, 'Invalid input');

          name = undefined;
          assert.throws(() => library.calcPriceOfBook(name, 0), Error, 'Invalid input');
      });

      it("Throws error if year is not a number", function() {
        let year = 'hello';

        assert.throws(() => library.calcPriceOfBook('Test', year), Error, 'Invalid input');

        year = undefined;
        assert.throws(() => library.calcPriceOfBook('Test', year), Error, 'Invalid input');

        year = {};
        assert.throws(() => library.calcPriceOfBook('Test', year), Error, 'Invalid input');

        year = 5.5;
        assert.throws(() => library.calcPriceOfBook('Test', year), Error, 'Invalid input');
        // could add more
      });

      it("Should return correct message if year > 1980", function() {
        let bookName = 'Test';
        let year = 1981;
        let price = 20;
        
        let expectedResut = `Price of ${bookName} is ${price.toFixed(2)}`;
        let actualResult = library.calcPriceOfBook(bookName, year);

        assert.equal(actualResult, expectedResut);

        year = 2000;

        actualResult = library.calcPriceOfBook(bookName, year);
        assert.equal(actualResult, expectedResut);
      });

      it("Should return correct message if year <= 1980", function() {
        let bookName = 'Test';
        let year = 1980;
        let price = 20 - (0.5 * 20);
        
        let expectedResut = `Price of ${bookName} is ${price.toFixed(2)}`;
        let actualResult = library.calcPriceOfBook(bookName, year);

        assert.equal(actualResult, expectedResut);

        year = 1979;

        actualResult = library.calcPriceOfBook(bookName, year);
        assert.equal(actualResult, expectedResut);
      });
   });
   
   describe("findBook", function() {
    it("Should throw error if input array is empty", function() {
      let booksArr = [];
      let wantedBook = 'Test';

      assert.throws(() => library.findBook(booksArr, wantedBook), Error, 'No books currently available');
    });

    it("Should return correct message if wanted book isnt in array", function() {
      let booksArr = ['Test1', 'Test2', 'Test3'];
      let wantedBook = 'Test';

      let expectedResult = 'The book you are looking for is not here!';

      assert.equal(library.findBook(booksArr, wantedBook), expectedResult);
    });

    it("Should return correct message if wanted book is in array", function() {
      let booksArr = ['Test1', 'Test2', 'Test3'];
      let wantedBook = 'Test3';

      let expectedResult = 'We found the book you want.';

      assert.equal(library.findBook(booksArr, wantedBook), expectedResult);
    });
   });

   describe("arrangeTheBooks", function() {
    it("Should throw error if count is not an integer", function() {
      let count1 = 'Hello';
      let count2 = '5';
      let count3 = undefined;
      let count4 = {};
      let count5 = true;
      let count6 = [];
      let count7 = 5.5;

      assert.throws(() => library.arrangeTheBooks(count1), Error, 'Invalid input');
      assert.throws(() => library.arrangeTheBooks(count2), Error, 'Invalid input');
      assert.throws(() => library.arrangeTheBooks(count3), Error, 'Invalid input');
      assert.throws(() => library.arrangeTheBooks(count4), Error, 'Invalid input');
      assert.throws(() => library.arrangeTheBooks(count5), Error, 'Invalid input');
      assert.throws(() => library.arrangeTheBooks(count6), Error, 'Invalid input');
      assert.throws(() => library.arrangeTheBooks(count7), Error, 'Invalid input');
    });

    it("Should throw error if count is negative", function() {
      let count1 = -5;
      let count2 = -3.5;
     

      assert.throws(() => library.arrangeTheBooks(count1), Error, 'Invalid input');
      assert.throws(() => library.arrangeTheBooks(count2), Error, 'Invalid input');
    });

    it("Should return correct message if space is enough", function() {
      let count1 = 40;
      let count2 = 5;
      let count3 = 0;
    
      let expectedResult = 'Great job, the books are arranged.';
      assert.equal(library.arrangeTheBooks(count1), expectedResult);
      assert.equal(library.arrangeTheBooks(count2), expectedResult);
      assert.equal(library.arrangeTheBooks(count3), expectedResult);
    });

    it("Should return correct message if space is not enough", function() {
      let count1 = 41;
      let count2 = 100;
    
      let expectedResult = 'Insufficient space, more shelves need to be purchased.';
      assert.equal(library.arrangeTheBooks(count1), expectedResult);
      assert.equal(library.arrangeTheBooks(count2), expectedResult);
    });
   });
});
