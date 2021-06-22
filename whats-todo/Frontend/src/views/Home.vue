<template>
  <div class="home">
    <div>TJENA</div>
    <AddTask v-if="getShowTaskForm" />
    <Tasks :tasks="getTasks" />
  </div>
</template>

<script>
// @ is an alias to /src
// import Counter from "../components/Counter.vue";
import Tasks from "../components/Tasks.vue";
import AddTask from "../components/AddTask.vue";
export default {
  name: "Home",
  components: {
    // Counter,
    Tasks,
    AddTask,
  },
  data() {
    return {};
  },
  computed: {
    getTasks() {
      return this.$store.state.tasks;
    },
    getShowTaskForm() {
      return this.$store.state.showTaskForm;
    },
  },
  async created() {
    // this.$store.dispatch("fetchTasksTest");

    const res = await fetch("https://localhost:5001/tasks");
    const data = await res.json();
    console.log(data);
  },
};
</script>

<style lang="css" scoped>
.home {
  display: flex;
  justify-content: center;
  flex-direction: column;
}
</style>
