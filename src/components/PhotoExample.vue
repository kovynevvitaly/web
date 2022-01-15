<template>
  <div class="photo-example" :id="id">
    <h3 class="photo-title">{{ photoTitle }}</h3>
    <img :src="imgSrc" :alt="imgAlt" class="photo">
  </div>
</template>

<script>
export default {
  name: "PhotoExample",
  props: ["photoTitle", "imgSrc", "imgAlt", "id"]
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
.photo-example#family {
  max-width: 564px;
}

#family > img {
  width: 564px;
  height: 375px;
}

.photo-example#personal {
  max-width: 450px;
}

#personal > img {
  width: 450px;
  height: 375px;
}
</style>