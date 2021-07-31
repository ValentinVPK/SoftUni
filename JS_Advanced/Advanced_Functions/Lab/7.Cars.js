
function solve(inputArray) {
  const obj = processArray();

  inputArray.forEach(str => {
    let commands = str.split(' ');
    if(commands[0] === 'create') {
      obj['create'](commands[1], commands[3]);
    } else if(commands[0] === 'set') {
      obj['set'](commands[1], commands[2], commands[3]);
    } else if(commands[0] === 'print') {
      obj['print'](commands[1]);
    }
  });

  function processArray() {
    const resultArr = [];

    return {
      create: function(name, parentName) {
        if(parentName === undefined) {
          resultArr.push({name});
        } else {
          const currObj = {name};
          currObj[parentName] = {};
          
          this.inherit(name, parentName);
          resultArr.push(currObj);
        }
      },

      set: function(name, property, value) {
        let wantedObj = resultArr.find(obj => obj['name'] === name);

        wantedObj[property] = value;

        let childObj = resultArr.find(obj => obj.hasOwnProperty(name));
        if(childObj !== undefined) {
          childObj[name][property] = value;
        }
      },

      print: function(name) {
        let tempArr = [];
        let wantedObj = resultArr.find(obj => obj['name'] === name);
  
        let parentKey = undefined;
        for(let key of Object.keys(wantedObj)) {
          if(key === 'name') { continue;}
          if(resultArr.find(obj => obj['name'] === key) !== undefined) {
            parentKey = key;
            continue;
          }
          tempArr.push(`${key}:${wantedObj[key]}`);
        }

        if(parentKey !== undefined) {
          for(let key of Object.keys(wantedObj[parentKey])) {
            tempArr.push(`${key}:${wantedObj[parentKey][key]}`);
          }
        }

        console.log(tempArr.join(', '));
      },

      inherit: function(childName, parentName) {
        let childObj = resultArr.find(obj => obj['name'] === childName);
        let parentObj = resultArr.find(obj => obj['name'] === parentName);

        for(let key of Object.keys(parentObj).filter(x => x !== 'name')) {
          childObj[parentName][key] = parentObj[key];
        }
      } 
    };
  }
}


solve(['create c1',
'create c2 inherit c1',
'set c1 color red',
'set c2 model new',
'print c1',
'print c2']);