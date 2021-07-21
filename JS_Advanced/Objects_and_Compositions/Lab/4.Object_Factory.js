

function createObjects(library, orders) {
  const resultArr = [];

  for(let obj of orders) {
    const newObj = Object.assign({}, obj.template);
    obj.parts.forEach(part => {
      newObj[part] = library[part];
    });

    resultArr.push(newObj);
  }

  return resultArr;
}


const library = {
  print: function () {
    console.log(`${this.name} is printing a page`);
  },
  scan: function () {
    console.log(`${this.name} is scanning a document`);
  },
  play: function (artist, track) {
    console.log(`${this.name} is playing '${track}' by ${artist}`);
  },
};
const orders = [
  {
    template: { name: 'ACME Printer'},
    parts: ['print']      
  },
  {
    template: { name: 'Initech Scanner'},
    parts: ['scan']      
  },
  {
    template: { name: 'ComTron Copier'},
    parts: ['scan', 'print']      
  },
  {
    template: { name: 'BoomBox Stereo'},
    parts: ['play']      
  },
];

console.log(createObjects(library, orders));


