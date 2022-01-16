<template>
  <div class="price-badge" :class="{'no-margin': isLastElement}">{{ item }}</div>
</template>

<script>
export default {
  name: "PriceBadge",
  props: ["item", "i"],
  computed: {
    isLastElement: function() {
      return this.i === 3;
    }
  }
}
</script>

<style scoped>
.price-badge {
  background-color: #000;
  border-radius: 10px;
  width: 100px;
  height: 30px;
  margin-right: 30px;
  font-size: 15px;
  display: flex;
  align-items: center;
  justify-content: center;
}

.no-margin {
  margin: 0;
}
</style>