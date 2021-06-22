<template>
  <div
    @dblclick="onToggleReminder(task.id)"
    :class="['task', task.reminder ? 'reminder' : '']"
  >
    <div class="cont">
      <div class="text">{{ task.text }}</div>
      <i @click="onDelete(task.id)" class="fas fa-times"></i>
    </div>
    <div class="day">{{ task.day }}</div>
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
  background-color: white;
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  border-radius: 10px;
  cursor: pointer;
}
.text {
  font-size: 16px;
  font-weight: 600;
}
.day {
  font-size: 12px;
}
.cont {
  width: 100%;
  display: flex;
  flex-direction: row;
  justify-content: space-between;
}
.fas {
  color: red;
}

.reminder {
  border-left: solid 6px green;
}
</style>
