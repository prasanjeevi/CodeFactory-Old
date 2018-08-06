# Pro Code

Shared Folder Structure for HTML with JS, Node.js, Express.js and  Electron.js apps
<br/>![folders-0.0.1.png](screenshots/folders-0.0.1.png?raw=true)

## HTML with JS
### path: `/js/core`
* index.html uses `js/core/`
* Has own package.json
* JS runtime detection
### js/core/index.js
```
const isNode = typeof exports !== 'undefined'

if (isNode) {
  module.exports = {
    getMessage: getMessage
  }
}
```

## Node.js 
### path: `/js/node`
* Intented to share `js/core`
* Has own package.json
* Hello World node.js
### server.js
```
const http = require('http');

const hostname = '127.0.0.1';
const port = 3000;

const server = http.createServer((req, res) => {
  res.statusCode = 200;
  res.setHeader('Content-Type', 'text/plain');
  res.end('Hello World\n');
});

server.listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);
});
```
### requestp.js
`request` wrapped with `Promise`
```
const request = require('request')

module.exports = options => new Promise((resolve, reject) =>
    request(options, (err, res, body) => {
      if (err) {
        reject(err)
      }
      else if (res.statusCode === 200){
        resolve(body)
      }
      else {
        err = new Error('Error on calling ' + options.url)
        err.res = res
        reject(res)
      }
  })
)
```

## Express.js
### path: `/js/node/express`
* Intented to share `js/core` and `js/node/core`
* Has own package.json
* Hello World express.js
### app.js
```
var express = require('express')
var app = express()

app.get('/', function (req, res) {
  res.send('Hello World!')
})

app.listen(3000, function () {
  console.log('Example app listening on port 3000!')
})
```

## Electron.js
### path: `js/node/electron`
* Intented to share `js/core` and `js/node/core`
* Has own package.json
* Hello World electron.js
### main.js
```
const electron = require('electron')
const app = electron.app
const BrowserWindow = electron.BrowserWindow

let mainWindow

electron.app.once('ready', () => {
  mainWindow = new BrowserWindow()
  mainWindow.loadURL(`file://${__dirname}/index.html`)
})
```
#### Static pages
```
const path = require('path')
const __root = path.join(path.resolve(__dirname), "../../../")
app.use(express.static(__root)) // Root - procode
app.use('/public', express.static(__dirname)) // Current Directory
```

## Usage
| scripts | start | command |
|---|---|---|
| node | server.js | npm run node |
| express | app.js | npm run express |
| electron | main.js | npm run electron |