const isNode = typeof module.exports !== 'undefined'

function getMessage() {
  return 'Hello World'
}

if (isNode) {
  module.exports = {
    getMessage: getMessage
  }
}