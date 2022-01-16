<template>
  <main>
    <div class="container">
      <section class="content">
        <UpperContent/>
        <BottomPhotos/>
      </section>
    </div>
  </main>
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
</style>
