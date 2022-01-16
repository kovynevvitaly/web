<template>
<div class="bottom-photos">
  <PhotoExample :imgSrc="require('@/assets/familyph.jpg')" :imgAlt="'семейный фотосет'" :photoTitle="'Семейный фотосет'" :id="'family'"/>
  <PhotoExample :imgSrc="require('@/assets/personalph.jpg')" :imgAlt="'личный фотосет'" :photoTitle="'Личный фотосет'" :id="'personal'"/>
</div>
</template>

<script>
import PhotoExample from "@/components/PhotoExample";
export default {
  name: "BottomPhotos",
  components: {PhotoExample}

}
</script>

<style scoped>
.bottom-photos {
  display: flex;
  justify-content: space-evenly;
  margin-top: 160px;
}
</style>