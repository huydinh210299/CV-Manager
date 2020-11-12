var path = require('path');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const { CleanWebpackPlugin } = require("clean-webpack-plugin");

const dirName = "wwwroot/dist";
const mode = 'development';
module.exports = {
    mode: mode,
    devtool: "source-map",
    entry: {
 
        cvbuilder: [
            "./src/script/CVBuilder/index.js",
            "./src/style/CVBuilder/styles.scss",
        ],
    },

    output: {
        filename: '[name].js',
        path: path.resolve(__dirname, dirName)
    },

    module: {
        rules: [
          {
            test: /\.(sa|sc)ss$/,
            use: [
              MiniCssExtractPlugin.loader,
              {
                loader: 'css-loader',
                options: {
                    sourceMap: true
                },
              },
              {
                loader: 'sass-loader',
                options: {
                    sourceMap: true
                },
              },
            ],
          },
          {
            test: /\.m?js$/,
            exclude: /(node_modules|bower_components)/,
            use: {
              loader: 'babel-loader',
              options: {
                presets: ['@babel/preset-env']
              }
            }
          }
        ]
      },
    plugins: [
    new CleanWebpackPlugin(),
    new MiniCssExtractPlugin({
        filename: '[name].css',
    }),
    ]
}