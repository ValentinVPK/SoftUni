function solve() {
  let textString = document.querySelector('#text').value;
  let namingConventionString = document.querySelector('#naming-convention').value;

  let result = applyNamingConvention(textString, namingConventionString);

  document.querySelector('#result').textContent = result;

  function applyNamingConvention(text, convention) {
    const conventionSwitch = {
      'Pascal Case': function() {
        return text.toLowerCase()
        .split(' ')
        .map(x => x[0].toUpperCase() + x.substring(1))
        .join('')
      },
      'Camel Case': function() {
        let textPascal = text.toLowerCase()
        .split(' ')
        .map(x => x[0].toUpperCase() + x.substring(1))
        .join('')
        
        return textPascal.replace(textPascal[0], textPascal[0].toLowerCase());
      },
      default: function() {
        return 'Error!';
      }
    }

    return (conventionSwitch[convention] || conventionSwitch.default)();
  }
}