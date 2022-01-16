<template>
  <main>
    <div class="container">
      <div class="photos top-photos">
        <PortfolioPhoto :imgSrc="require('@/assets/2.jpg')"/>
        <PortfolioPhoto :imgSrc="require('@/assets/3.jpg')"/>
        <PortfolioPhoto :imgSrc="require('@/assets/4.jpg')"/>
      </div>
      <div class="photos bottom-photos">
        <PortfolioPhoto :imgSrc="require('@/assets/5.jpg')"/>
        <PortfolioPhoto :imgSrc="require('@/assets/6.jpg')"/>
        <PortfolioPhoto :imgSrc="require('@/assets/7.jpg')"/>
      </div>
    </div>
  </main>
</template>

<script>
import PortfolioPhoto from "@/components/PortfolioPhoto";

export default {
  name: "Portfolio",
  components: {PortfolioPhoto}

}
</script>

<style scoped>

.bottom-photos {
  display: flex;
  justify-content: space-evenly;
}

.top-photos {
  margin-top: 150px;
}
</style>