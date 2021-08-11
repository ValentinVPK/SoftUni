let numbers = [10, 20, 30, 40, 50];

//Rest operator:
let [a,b,...elements1] = numbers; // a - 10, b - 20, elements1 = [30, 40, 50]

// Destructor operator:
let elements2 = [...numbers]; // [10, 20, 30, 40, 50] - copies the array

//MUTATOR methods - modifies the array: ----------------------

//1.Pop

numbers.pop() // removes and returns the last element of the array (50)

//2.Push

numbers.push(50) // adds the elements to the end of the array and returns the length of the array (5)

//3.Shift

numbers.shift() // removes and returns the first element of the array (10);

//4.Unshift()

numbers.unshift(10) // adds the elements to the beginning of the array and returns the length (5)

//5.Splice

let nums = [1, 3, 4, 5, 6];
nums.splice(1, 0, 2); // inserts the element 2 at index 1 - [1,2,3,4,5,6]

nums.splice(4,1,19) // replaces the element at index 4 with 19 - [1,2,3,4,19,6]

nums.splice(2, 1); // removes 1 element at index 2 - [ 1, 2, 4, 19, 6 ]


//6.Fill
let arr = [1, 2, 3, 4];

arr.fill(0, 2, 4); // fill with 0 from position 2 until position 4 - [1, 2, 0, 0]
arr.fill(6); // [6, 6, 6, 6]

// 7.Reverse 

numbers.reverse() // reverses the array - [50,40,30,20,10];

//8.Sort
numbers.sort((a,b) => a - b) // [10, 20, 30, 40 ,50]

//ACCESSOR Methods - dont modify the array, returns a new one ---------------------------------------

//1. Concat

const numbers2 = [1,2, 3];

const combines = numbers.concat(numbers2) // merges the two arrays but returns a new one [10,20,30,40,50,1,2,3]

//2.Slice
let fruits = ['Banana', 'Orange', 'Lemon', 'Apple', 'Mango'];

let citrus = fruits.slice(1, 3); //Gets the elements from index 1(included) to index 3(not included) and returns a new array

let fruitsCopy = fruits.slice(); // copies the array

//3.includes

fruits.includes('Banana'); //Checks if the given element is in the array or not (true)

//4.indexOf

fruits.indexOf('Banana') // returns the first index of the searched element or -1 if the element doesnt exist (0)

//ITERATION METHODS

//1. forEach

//2. Some

numbers.some(x => x % 2 === 0) // returns true if one of the elements passes the test (true)

//3.Find

numbers.some(x => x % 2 === 0) // returns the first element which passes the test (10)

//4.Filter

let filteredNumbers = numbers.filter(x => x % 2 === 0) // creates a new array with all of the elements which pass the test

// 5.Map

let increasedNumbers = numbers.map(x => x + 1) // creates a new array with the results of the function

//6. REDUCE

numbers.reduce(reducer, startingValue);

//The reducer function takes four arguments:
//  Accumulator 
//  Current Value 
//  Current Index (Optional)
//  Source Array (Optional)
// Your reducer function's returned value is assigned to the accumulator
// Accumulator's value - the final, single resulting value
let sum = [0, 1, 2, 3].reduce(function (acc, curr) {
       return acc + curr;
     }, 0);
  
