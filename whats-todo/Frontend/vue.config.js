// module.exports = {
//   devServer: {
//     proxy: {
//       "^/api/": {
//         target: "https://localhost:5001",
//         changeOrigin: true,
//         ws: true,
//         logLevel: "debug",
//         pathRewrite: { "^/api": "" },
//       },
//     },
//   },
// };

module.exports = {
  devServer: {
    proxy: {
      "^/api/": {
        target: "http://localhost:5000",
        pathRewrite: { "^/api/": "/" },
        changeOrigin: true,
        logLevel: "debug",
        ws: true,
      },
    },
  },
};
