<template>
  <form @submit="onSubmit" class="add-form mb-5">
    <div class="form-control form-group">
      <label for="">Task</label>
      <input
        class="form-control"
        v-model="text"
        type="text"
        name="text"
        placeholder="Add Task"
      />
    </div>
    <div class="form-control form-group">
      <label for="">Day & Time</label>
      <input
        v-model="day"
        name="day"
        class="form-control"
        placeholder="Add Day & Time"
      />
    </div>
    <div class="btm-cont">
      <div class="form-control form-check reminder form-group w-50">
        <label class="form-check-label" for="reminder">Set Reminder</label>
        <input
          class="form-check-input"
          v-model="reminder"
          type="checkbox"
          name="reminder"
        />
      </div>

      <button type="submit" value="Save Task" class="btn btn-primary">
        Submit
      </button>
    </div>
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
      if (!this.text || !this.day) {
        alert("Please add text and day to task!");
      } else {
        const newTask = {
          text: this.text,
          day: this.day,
          reminder: this.reminder,
        };
        this.$store.dispatch("addTask", newTask);

        this.text = "";
        this.day = "";
        this.reminder = false;
      }
    },
  },
};
</script>
<style scoped>
.add-form {
  display: flex;
  flex-direction: column;
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

.btm-cont {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
}
</style>
