
class Company {
  constructor() {
    this.departments  = {};
  }

  addEmployee(username, salary, position, department) {
    if(username === '' || username === undefined || username === null
      || salary === undefined || salary === null || salary <= 0
      || position === '' || position === undefined || position === null
      || department === '' || department === undefined || department === null) {
        throw new Error('Invalid input!');
    }

    if(!this.departments.hasOwnProperty(department)) {
      this.departments[department] = [];
    } 

    let currEmployee = {username, salary, position};
    this.departments[department].push(currEmployee);

    return `New employee is hired. Name: ${username}. Position: ${position}`;
  }

  bestDepartment() {
    let resultStr = '';

    //Finding the department with best average salary
    let bestAverage = 0;
    let bestDepartmentKey = '';

    for(const key of Object.keys(this.departments)) {
      let currSum = 0;
      this.departments[key].forEach(e => currSum += e.salary);

      let currAverage = (currSum / this.departments[key].length).toFixed(2);

      if(currAverage > bestAverage) {
        bestAverage = currAverage;
        bestDepartmentKey = key;
      }
    }
    
    resultStr += `Best Department is: ${bestDepartmentKey}\nAverage salary: ${bestAverage}`;
    
    this.departments[bestDepartmentKey].sort((a,b) => {
      return b.salary - a.salary === 0
        ? a.username.localeCompare(b.username)
        : b.salary - a.salary;})
    .forEach(e => {
      resultStr += `\n${e.username} ${e.salary} ${e.position}`  ;
    });

    return resultStr;
  }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
