
function solve(httpObject) {

  validateMethod(httpObject);
  validateUri(httpObject);
  validateVersion(httpObject);
  validateMessage(httpObject);

  return httpObject;

  function validateMethod(httpObject) {
    let validMethods = ['GET', 'POST', 'DELETE', 'CONNECT'];
    let propName = 'method';

    if(httpObject[propName] === undefined || !validMethods.includes(httpObject[propName])) {
      throw new Error('Invalid request header: Invalid Method');
    }
  }

  function validateUri(httpObject) {
    let propName = 'uri';
    let uriRegex = /^\*$|^[a-zA-Z0-9.]+$/;

    if(httpObject[propName] === undefined || !uriRegex.test(httpObject[propName])) {
      throw new Error('Invalid request header: Invalid URI');
    }
  }

  function validateVersion(httpObject) {
    let validVersions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
    let propName = 'version';

    if(httpObject[propName] === undefined || !validVersions.includes(httpObject[propName])) {
      throw new Error('Invalid request header: Invalid Version');
    }
  }

  function validateMessage(httpObject) {
    let propName = 'message';
    let messageRegex = /^[^<>\\&'"]*$/;

    if(httpObject[propName] === undefined || !messageRegex.test(httpObject[propName])) {
      throw new Error('Invalid request header: Invalid Message');
    }
  }
}

console.log(solve({
  method: 'GET',
  uri: 'svn.public.catalog',
  version: 'HTTP/1.1',
  message: ''
}));