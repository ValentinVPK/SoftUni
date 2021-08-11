
let string = 'Hello';

// MANIPULATING strings -----

//1. +, += , concat

let result = string.concat(' user!') // Hello user!

//2.indexOf

string.indexOf('Hell') // returns the index in which the substr is found or -1 if substr doesnt exist (0)

//3.lastIndexOf

string.lastIndexOf('Hell') // same as indexOf but starts from the end

//4.substring

string.substring(0,4) // returns the substring from index 0(included) to index 4(not included) (Hell)
string.substring(1) // returns the substring from index 1 to the end (ello);

//5.replace

string.replace('H', 'h') //returns a new string and replaces the substring with the other (hello)

//6.split

let arr = string.split('') // splits the string into an array

//7.includes

string.includes('hell') // returns bool if the substr exists or not (true)

//8.repeat

let repetaed = string.repeat(2) // returns new string with repeated values (hellohello)

//9.trim

string.trim() // returns a new string with removed whitespaces in front and behind

//trimStart() , trimEnd()

//10.startsWith, endsWith

string.startsWith('hel') // (true)

//11.padStart, padEnd

string.padStart(8, '.') //returns a new string and adds . to the end of the string until the length of 8 is achieved