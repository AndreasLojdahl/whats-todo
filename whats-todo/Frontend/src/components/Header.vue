<template>
  <header class="header">
    <h1>{{ title }}</h1>
    <Button
      @clicked="handleClick()"
      :text="getShowTaskForm ? 'Close' : 'Add Task'"
      :bgColor="getShowTaskForm ? 'red' : 'green'"
      textColor="white"
    />
  </header>
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
      console.log(this.$store.state.showTaskForm);
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
.header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 20px;
}
</style>