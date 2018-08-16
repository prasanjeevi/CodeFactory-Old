const path = require('path');
const webpack = require('webpack')

module.exports = {
  entry: './src/index.js',
  output: {
    filename: 'bundle.js', //default: main.js
    path: path.resolve(__dirname, 'dist')
  },
  module: {
    rules: [
      {
        test: /\.css$/,
        use: [
          'style-loader',
          'css-loader'
        ]
      }
    ]
  },
  plugins: [
    //new webpack.ContextReplacementPlugin(/moment[\/\\]locale$/, /ta/)
    new webpack.IgnorePlugin(/^\.\/locale$/, /moment$/)
  ]
};