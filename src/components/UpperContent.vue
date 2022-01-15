<template>
  <div class="upper-content">
    <div class="left-section">
      <h1>Свадебный и семейный фотограф</h1>
      <h2>Никита Воробьёв</h2>
      <div class="photos">
        <PhotoExample :imgSrc="require('@/assets/wedding.jpg')" :imgAlt="'свадебный фотосет'" :photoTitle="'Свадебный фотосет'"/>
        <PhotoExample :imgSrc="require('@/assets/couple.jpg')" :imgAlt="'парный фотосет'" :photoTitle="'Парный фотосет'"/>
      </div>
    </div>
    <img :src="require('@/assets/nik.jpg')" alt="фотограф" class="main-photo">
  </div>
</template>

<script>
import PhotoExample from "@/components/PhotoExample";

export default {
  name: "UpperContent",
  components: {PhotoExample}
}
</script>

<style scoped>

.upper-content {
  display: flex;
  justify-content: space-between;
}

.left-section {
  flex-basis: 900px;
  display: flex;
  flex-flow: column;
}

h1 {
  text-transform: uppercase;
  font-size: 40px;
  margin: 190px 0 26px 0;
}

h2 {
  font-weight: 400;
  font-size: 35px;
  margin: 0;
}

h3 {
  font-weight: 400;
  margin: 0 auto;
}

.photos {
  display: flex;
  justify-content: space-between;
}

.main-photo {
  margin-top: 150px;
  height: 725px;
  flex-basis: 550px;
}
</style>