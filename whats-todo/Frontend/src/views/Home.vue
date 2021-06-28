<template>
  <div class="home">
    <AddTask v-if="getShowTaskForm" />
    <Tasks :tasks="getTasks" />
    <div v-if="!getShowTaskForm && getTasks.length <= 0">
      <h4>
        Hi lets write some Tasks!<br />
        <br />
      </h4>
      <p>
        Click the button "Add Task" and fill in the form to create a new Task
        and "Close" to close the section when you're done!
      </p>
      <p>
        To Update and toggle the reminder on a created task just double click
        it!
      </p>
      <p>And click the "Delete" button if you want to delete a task</p>
    </div>
  </div>
</template>

<script>
import Tasks from "../components/Tasks.vue";
import AddTask from "../components/AddTask.vue";
export default {
  name: "Home",
  components: {
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
    this.$store.dispatch("fetchTasks");
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
