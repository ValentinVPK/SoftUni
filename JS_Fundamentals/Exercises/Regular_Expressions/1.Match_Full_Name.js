
function solve(names) {
  let validNames = [];

  let pattern = /\b[A-Z][a-z]+ [A-Z][a-z]+\b/g;

  let matched = names.match(pattern);

  for (const name of matched) {
    validNames.push(name);
  }

  console.log(validNames.join(', '));
}

solve("Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan	Ivanov");