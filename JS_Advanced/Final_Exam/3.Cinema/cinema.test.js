
const cinema = require('./cinema');
const {assert} = require('chai');

describe("Tests cinema", function() {
  describe("showMovies", function() {
      it("Should return correct message if input is an empty array", function() {
          let expectedResult = 'There are currently no movies to show.';

          assert.equal(cinema.showMovies([]), expectedResult);
      });

      it("Should return correct message if input is not an empty array", function() {
        let moviesArray = ['King Kong', 'The Tomorrow War', 'Joker'];
        let expectedResult = moviesArray.join(', ');

        assert.equal(cinema.showMovies(moviesArray), expectedResult);
    });
  });

   describe("ticketPrice", function() {
    it("Should throw error if the type is incorrect", function() {
      let type = '3D';

      assert.throws(() => cinema.ticketPrice(type), Error, 'Invalid projection type.');

      type = '';
      assert.throws(() => cinema.ticketPrice(type), Error, 'Invalid projection type.');
    });

    it("Should return correct price if input type is correct", function() {
      let type = 'Premiere';
      let expected = 12.0;
      assert.equal(cinema.ticketPrice(type), expected);

      type = 'Normal';
      expected = 7.5;
      assert.equal(cinema.ticketPrice(type), expected);

      type = 'Discount';
      expected = 5.5;
      assert.equal(cinema.ticketPrice(type), expected);
    });
 });

 describe("swapSeatsInHall", function() {
      it("Should return correct message first input is incorrect", function() {
          let expectedResult = 'Unsuccessful change of seats in the hall.';

          // isNumber
          assert.equal(cinema.swapSeatsInHall('Hi', 15), expectedResult);
          assert.equal(cinema.swapSeatsInHall(true, 15), expectedResult);
          assert.equal(cinema.swapSeatsInHall('', 15), expectedResult);
          assert.equal(cinema.swapSeatsInHall([], 15), expectedResult);
          assert.equal(cinema.swapSeatsInHall({}, 15), expectedResult);
          assert.equal(cinema.swapSeatsInHall(15.4, 15), expectedResult);

          // Correct interval

          assert.equal(cinema.swapSeatsInHall(0, 15), expectedResult);
          assert.equal(cinema.swapSeatsInHall(-2, 15), expectedResult);
          assert.equal(cinema.swapSeatsInHall(25, 15), expectedResult);

          //Equal
          assert.equal(cinema.swapSeatsInHall(15, 15), expectedResult);
      });

      it("Should return correct message second input is incorrect", function() {
        let expectedResult = 'Unsuccessful change of seats in the hall.';

        // isNumber
        assert.equal(cinema.swapSeatsInHall(15,'Hi'), expectedResult);
        assert.equal(cinema.swapSeatsInHall(15,true), expectedResult);
        assert.equal(cinema.swapSeatsInHall(15,''), expectedResult);
        assert.equal(cinema.swapSeatsInHall(15,[]), expectedResult);
        assert.equal(cinema.swapSeatsInHall(15,{}), expectedResult);
        assert.equal(cinema.swapSeatsInHall(15,15.4), expectedResult);

        // Correct interval

        assert.equal(cinema.swapSeatsInHall(15,0), expectedResult);
        assert.equal(cinema.swapSeatsInHall(15,-2), expectedResult);
        assert.equal(cinema.swapSeatsInHall(15,25), expectedResult);

        //Equal
        assert.equal(cinema.swapSeatsInHall(15, 15), expectedResult);
    });

      it("Should return correct if both of the inputs are correct", function() {
        let expectedResult = 'Successful change of seats in the hall.';

        assert.equal(cinema.swapSeatsInHall(20, 15), expectedResult);
        assert.equal(cinema.swapSeatsInHall(13, 15), expectedResult);
        assert.equal(cinema.swapSeatsInHall(15, 20), expectedResult);
        assert.equal(cinema.swapSeatsInHall(15, 13), expectedResult);
      });
  });
});
