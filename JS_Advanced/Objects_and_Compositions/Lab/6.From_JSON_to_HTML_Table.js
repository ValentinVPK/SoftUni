
function readJSON(jsonString) {
  const arr = JSON.parse(jsonString);

  const outputArr = ['<table>'];

  outputArr.push(makeKeyRow(arr[0]));

  arr.forEach(obj => {
    outputArr.push(makeValueRow(obj));
  });

  outputArr.push('</table>');

  console.log(outputArr.join('\n'));

  function makeKeyRow(inputObj) {
    let res = '\t<tr>';
    for(let key in inputObj) {
      res += `<th>${key}</th>`;
    }

    res += '</tr>';
    return res;
  }

  function makeValueRow(inputObj) {
    let res = '\t<tr>';
    for(let value of Object.values(inputObj)) {
       value = escapeHtml(value);
      res += `<td>${value}</td>`;
    }

    res += '</tr>';
    return res;
  }

  function escapeHtml(value) {
    if(typeof(value) === 'string') {
      return value.replace(/&/g, "&amp;")
            .replace(/</g, "&lt;")
            .replace(/>/g, "&gt;")
            .replace(/"/g, "&quot;")
            .replace(/'/g, "&#39;");
    }

    return value;
  }
}

readJSON('[{"Name":"St&<>amat","Score":5.5},{"Name":"Rumen","Score":6}]');