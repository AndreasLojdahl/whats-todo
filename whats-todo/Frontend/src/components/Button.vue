<template>
  <button
    @click="onClick()"
    :style="{ background: bgColor, color: textColor }"
    class="btn"
  >
    {{ text }}
  </button>
</template>
<script>
export default {
  name: "Button",
  props: {
    text: String,
    bgColor: String,
    textColor: String,
  },
  methods: {
    onClick() {
      this.$emit("clicked");
    },
  },
};
</script>
