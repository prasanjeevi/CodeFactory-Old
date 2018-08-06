'use strict'

const electron = require('electron')
const remote = electron.remote
const request = require('request')
const secret = require('./secret.json')
let authWindow
authWindow = new remote.BrowserWindow()

let clientId = secret.clientId
let clientSecret = secret.clientSecret
let scopes = ['user', 'repo', 'gist']
let githubAuthorize = `https://github.com/login/oauth/authorize?client_id=${clientId}&scope=${scopes}`
let githubToken = 'https://github.com/login/oauth/access_token'
let githubUser = 'https://api.github.com/user'

// Redirect users to request GitHub access to get 'code'
authWindow.loadURL(githubAuthorize)

authWindow.webContents.on('will-navigate', (event, url) => {
  alert(url)
})

authWindow.webContents.on('did-get-redirect-request', (event, oldUrl, newUrl) => {
  
  let code = /code=([^&]*)/.exec(newUrl)
  code = code ? code[1] : null
  
  if (code){
    let options = {
      uri: githubToken,
      method: 'POST',
      headers: {
        'User-Agent': 'request'
      },
      form: {
        'client_id': clientId,
        'client_secret': clientSecret,
        'code': code
      },
      json: true
    }

    // Get Access Token
    request(options, (err, res, body) => {
      
      let token = body.access_token

      // Access GitHub API
      authWindow.loadURL(githubUser + '?access_token=' + token);
    })
  }

})