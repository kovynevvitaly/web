<template>
<div class="container">
  <section class="content">
    <UpperContent/>
  </section>
</div>
</template>

<script>
import UpperContent from "@/components/UpperContent";

export default {
  name: 'Home',
  components: {
    UpperContent
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
