<template>
  <img :src="imgSrc" alt="Фото портфолио" class="photo wide-photo">
</template>

<script>
export default {
  name: "PortfolioPhoto",
  props: ["imgSrc"]
}
</script>

<style scoped>
.wide-photo {
  height: 613px;
  width: 490px;
}
</style>