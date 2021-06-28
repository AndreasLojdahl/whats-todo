<template>
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark mb-5">
    <div class="container">
      <div class="navbar-brand col title-cont">{{ title }}</div>

      <div class="navbar-nav col btn-cont">
        <Button
          @clicked="handleClick()"
          :text="getShowTaskForm ? 'Close' : 'Add Task'"
          :bgColor="getShowTaskForm ? 'red' : 'green'"
          textColor="white"
        />
      </div>
    </div>
  </nav>
</template>
<script>
import Button from "../components/Button.vue";
export default {
  name: "Header",
  props: {
    title: String,
  },
  components: {
    Button,
  },
  methods: {
    handleClick() {
      this.$store.dispatch("toggleTaskForm");
    },
  },
  computed: {
    getShowTaskForm() {
      return this.$store.state.showTaskForm;
    },
  },
};
</script>
<style scoped>
.btn-cont {
  justify-content: flex-end;
}
.title-cont {
  text-align: start;
  font-size: 30px;
}
</style>
