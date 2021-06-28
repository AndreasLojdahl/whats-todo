<template>
  <div class="" id="app">
    <div id="nav">
      <Header title="Whats Todo?" />
    </div>
    <router-view class="container" />
  </div>
</template>
<script>
import Header from "./components/Header.vue";

export default {
  name: "App",
  components: {
    Header,
  },
};
</script>

<style>
/* *************Global css********* */
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  display: flex;
  justify-content: center;
  flex-direction: column;
}

.btn-block {
  width: 100%;
  background-color: black;
  color: white;
  font-size: 16px;
  font-weight: 500;
}

.row {
  display: flex;
  flex-direction: row;
}

.white {
  color: white;
}
.w-100 {
  width: 100%;
}
.w-50 {
  width: 50%;
}

.hover:hover {
  cursor: pointer;
  transform: scale(1.01);
}
</style>
