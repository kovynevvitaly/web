<template>
<div class="container">
  <section class="content">
    <UpperContent/>
    <BottomPhotos/>
  </section>
</div>
</template>

<script>
import UpperContent from "@/components/UpperContent";
import BottomPhotos from "@/components/BottomPhotos";

export default {
  name: 'Home',
  components: {
    UpperContent,
    BottomPhotos
  }
}
</script>

<style scoped>
.content {
  display: flex;
  flex-flow: column;
  margin-bottom: 260px;
}
</style>
