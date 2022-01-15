<template>
  <div class="photo-example">
    <h3 class="photo-title">{{ photoTitle }}</h3>
    <img :src="imgSrc" :alt="imgAlt" class="photo">
  </div>
</template>

<script>
export default {
  name: "PhotoExample",
  props: ["photoTitle", "imgSrc", "imgAlt"]
}
</script>

<style scoped>
.photo {
  height: 500px;
  border-radius: 25px;
}

.photo-example {
  display: flex;
  flex-flow: column;
  margin-top: 175px;
  max-width: 350px;
}

.photo-title {
  margin-bottom: 50px;
}
</style>