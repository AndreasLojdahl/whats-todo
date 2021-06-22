<template>
  <form @submit="onSubmit" class="add-form">
    <div class="form-control">
      <label for="">Task</label>
      <input v-model="text" type="text" name="text" placeholder="Add Task" />
    </div>
    <div class="form-control">
      <label for="">Day & Time</label>
      <input v-model="day" name="day" placeholder="Add Day & Time" />
    </div>
    <div class="form-control reminder">
      <label for="">Set Reminder</label>
      <input v-model="reminder" type="checkbox" name="reminder" />
    </div>
    <!-- <button @click="onSubmit(e)" type="submit" class="btn btn-block">
      Save Task bt
    </button> -->
    <input type="submit" value="Save Task" class="btn btn-block" />
  </form>
</template>
<script>
export default {
  components: {},
  name: "AddTask",
  data() {
    return {
      text: "",
      day: "",
      reminder: false,
    };
  },
  methods: {
    onSubmit(e) {
      e.preventDefault();
      console.log(e);
      if (!this.text) {
        alert("Please add a task!");
      }

      const newTask = {
        // id: Math.floor(Math.random() * 100000),
        text: this.text,
        day: this.day,
        reminder: this.reminder,
      };
      this.$store.dispatch("addTask", newTask);

      this.text = "";
      this.day = "";
      this.reminder = false;
    },
  },
};
</script>
<style scoped>
.add-form {
  display: flex;
  flex-direction: column;
  padding: 20px;
}

.form-control {
  width: 100%;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  margin: 8px 0px;
}

.form-control input {
  height: 30px;
}
.reminder {
  flex-direction: row;
  align-items: center;
  justify-content: space-between;
}
.form-control label {
  flex: 1;
  font-size: 16px;
  font-weight: 600;
  margin-bottom: 5px;
  text-align: start;
}
</style>
