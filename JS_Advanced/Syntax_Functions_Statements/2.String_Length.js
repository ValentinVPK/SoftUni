
function calculateStringsLength(str1, str2, str3){
  let sum = str1.length + str2.length + str3.length;
  let average = (sum / 3).toFixed(0);

  console.log(`${sum}\n${average}`);
}

calculateStringsLength('chocolate', 'ice cream', 'cake');