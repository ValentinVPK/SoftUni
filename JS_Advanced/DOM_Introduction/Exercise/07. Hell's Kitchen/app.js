function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      document.querySelector('#bestRestaurant p').textContent = '';
      document.querySelector('#workers p').textContent = '';

      let inputArray = JSON.parse(document.querySelector('#inputs textarea').value);

      const restaurants = {};

      for(let element of inputArray) {
         let tokens = element.split(' - ');

         let restaurantName = tokens[0];
         let inputWorkers = tokens[1].split(', ').map( x => {
            let [name, salary] = x.split(' ');
            salary = Number(salary);
            return {name, salary };
         });

         if(!restaurants.hasOwnProperty(restaurantName)) {
            restaurants[restaurantName] = {
               workers: [],
               getAverageSalary() {
                  let sum = 0;
                  this.workers.forEach(x => sum += x.salary);
                  return sum / this.workers.length;     
               }
            };
         }

         inputWorkers.forEach(x => restaurants[restaurantName].workers.push(x));
      }

      let key = Object.keys(restaurants).sort((a,b) => restaurants[b].getAverageSalary() - restaurants[a].getAverageSalary())[0];



      restaurants[key].workers.sort((a,b) => b.salary - a.salary);
      document.querySelector('#bestRestaurant p').textContent = `Name: ${key} Average Salary: ${restaurants[key].getAverageSalary().toFixed(2)} Best Salary: ${restaurants[key].workers[0].salary.toFixed(2)}`;
      
      for(let worker of restaurants[key].workers) {
         document.querySelector('#workers p').textContent += `Name: ${worker.name} With Salary: ${worker.salary} `
      }
   }
}