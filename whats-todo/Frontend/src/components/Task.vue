<template>
  <div
    @dblclick="onToggleReminder(task.id)"
    :class="['task', 'row', task.reminder ? 'reminder' : '']"
  >
    <div class="col-6 cont">
      <div class="text">{{ task.text }}</div>
      <div class="day">{{ task.day }}</div>
    </div>
    <div class="col-6 d-flex justify-content-end">
      <button @click="onDelete(task.id)" class="btn btn-danger hover">
        Delete
      </button>
    </div>
  </div>
</template>

<script>
export default {
  name: "Task",
  props: {
    task: Object,
  },
  methods: {
    onDelete(taskId) {
      console.log(taskId);
      this.$store.dispatch("deleteTask", taskId);
    },
    onToggleReminder(taskId) {
      this.$store.dispatch("toggleReminder", taskId);
    },
  },
  created() {},
};
</script>

<style scoped>
.task {
  padding: 10px 20px;
  align-items: flex-start;
  background-color: white;
  border-radius: 10px;
  cursor: pointer;
  align-items: center;
}
.text {
  font-size: 16px;
  font-weight: 600;
}
.day {
  font-size: 12px;
}
.cont {
  display: flex;
  flex-direction: column;
  align-items: flex-start;
}
.reminder {
  border-left: solid 6px green;
}
</style>
