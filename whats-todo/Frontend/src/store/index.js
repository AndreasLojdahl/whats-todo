import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    tasks: null,
    showTaskForm: false,
    fetchedTask: null,
  },
  mutations: {
    setTasks(state, data) {
      state.tasks = data;
    },
    setShowTaskForm(state, data) {
      state.showTaskForm = data;
    },
  },
  actions: {
    async fetchTasks({ commit }) {
      const res = await fetch("api/todotasks");
      const data = await res.json();
      commit("setTasks", data);
    },

    async fetchTask({ commit }, taskId) {
      if (commit) {
        console.log();
      }
      const res = await fetch(`api/todotasks/${taskId}`);
      const data = await res.json();
      return data;
    },

    async addTask({ commit }, newTask) {
      const res = await fetch("api/todotasks", {
        method: "POST",
        headers: {
          "Content-type": "application/json",
        },
        body: JSON.stringify(newTask),
      });
      const data = await res.json();
      console.log(data, "CREATED TASK");
      let tasks = this.state.tasks;
      tasks = [...tasks, data];
      commit("setTasks", tasks);
    },

    async deleteTask({ commit }, taskId) {
      if (confirm("Are you sure you want to delete?")) {
        const res = await fetch(`api/tasks/${taskId}`, {
          method: "DELETE",
        });
        if (res.status === 200) {
          let tasks = this.state.tasks;
          let filteredTasks = tasks.filter((task) => {
            return task.id !== taskId;
          });
          commit("setTasks", filteredTasks);
        } else {
          alert("Error deleting task");
        }
      }
    },

    async toggleReminder({ commit }, taskId) {
      console.log("Before fetchTask");
      const taskToToggle = await this.dispatch("fetchTask", taskId);
      const updatedTask = { ...taskToToggle, reminder: !taskToToggle.reminder };
      console.log("after fetch , fetched task from db ", taskToToggle);

      await fetch(`api/todotasks/${taskId}`, {
        method: "PUT",
        headers: {
          "Content-type": "application/json",
        },
        body: JSON.stringify(updatedTask),
      });

      const updatedTaskFromDb = await this.dispatch("fetchTask", taskId);
      // const data = await res.json();

      console.log("after update");
      let tasks = this.state.tasks;
      tasks = tasks.map((task) =>
        task.id === taskId
          ? { ...task, reminder: updatedTaskFromDb.reminder }
          : task
      );
      commit("setTasks", tasks);
    },

    toggleTaskForm({ commit }) {
      let showTaskForm = this.state.showTaskForm;
      commit("setShowTaskForm", !showTaskForm);
    },
  },
  modules: {},
});
