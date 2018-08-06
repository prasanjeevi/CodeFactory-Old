const express = require('express')
const app = express()
const jsCore = require('../../core')
const nodeCore = require('../core')
const path = require('path')
const options = {
  url: 'https://prasanjeevi.github.io'
}
const __root = path.join(path.resolve(__dirname), "../../../")

app.get('/', function (req, res) {
  res.send(jsCore.getMessage())
})

app.get('/profile', function (req, res) {
  nodeCore.requestp(options)
  .then(body => res.send(body))
  .catch(err => res.send(err.message))
})

app.use(express.static(__root)) // Root - procode
app.use('/public', express.static(__dirname)) // Current Directory

app.listen(3000, function () {
  console.log('Example app listening on port 3000!')
})