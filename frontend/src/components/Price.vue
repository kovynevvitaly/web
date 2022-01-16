<template>
<article class="price">
  <h2 class="price-title">{{ title }}</h2>
  <div class="price-box">
    <div class="price-row">
      <PriceBadge v-for="(time, i) in times" :item="time" :i="i" :key="i"/>
    </div>
    <div class="price-row bottom-row">
      <PriceBadge v-for="(price, i) in prices" :item="price" :i="i" :key="i" />
    </div>
  </div>
</article>
</template>

<script>
import PriceBadge from "@/components/PriceBadge";
export default {
  name: "Price",
  props: ["title", "prices"],
  data: function() {
    return {
      times: ["30 минут", "1 час", "3 часа", "6 часов"]
    }
  },
  components: {
    PriceBadge
  }
}
</script>

<style scoped>

.price {
  width: 550px;
  margin-top: 100px;
}

.price-title {
  text-align: center;
  margin-bottom: 26px;
  font-size: 25px;
}

.price-box {
  background-color: #333;
  border-radius: 25px;
  padding: 30px;
  display: flex;
  flex-flow: column;
}

.price-row {
  display: flex;
  flex-flow: row;
}

.bottom-row {
  margin-top: 30px;
}
</style>