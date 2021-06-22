<template>
  <div class="container">
    <div class="margin-5" v-for="task in tasks" :key="task.id">
      <Task :task="task" />
    </div>
  </div>
</template>
<script>
import Task from "./Task.vue";
export default {
  components: {
    Task,
  },
  name: "Tasks",
  props: {
    tasks: Array,
  },
  created() {},
};
</script>
<style scoped>
.container {
  background-color: rgb(231, 231, 231);
  padding: 20px;
  border-radius: 10px;
}

.margin-5:not(:last-child) {
  margin-bottom: 15px;
}
</style>
