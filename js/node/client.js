const requestp = require('./core').requestp;

let options = {
  url: 'https://prasanjeevi.github.io'
}

requestp(options)
.then(body => console.log(body))
.catch(err => console.log(err.message))