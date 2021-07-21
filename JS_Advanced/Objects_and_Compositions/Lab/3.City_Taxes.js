
function solve(name, population, treasury) {
  let city = {
    name,
    population,
    treasury,
    taxRate: 10,

    collectTaxes() {
      this.treasury += this.population * this.taxRate;
    },

    applyGrowth(percentage) {
      this.population += (percentage / 100) * this.population;
      this.population = Math.floor(this.population);
    },

    applyRecession(percentage) {
      this.treasury -= (percentage / 100) * this.treasury;
      this.treasury = Math.floor(this.treasury);
    }
  }

  return city;
}

console.log(solve('Tortuga',7000,15000));