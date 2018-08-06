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