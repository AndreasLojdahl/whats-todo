module.exports = {
  devServer: {
    proxy: {
      "^/api": {
        target: "http://localhost:44387",
        changeOrigin: true,
        logLevel: "debug",
        pathRewrite: { "^/api": "/" },
      },
    },
  },
};
