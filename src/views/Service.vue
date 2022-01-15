<template>
  <main>
    <div class="container">
    <section class="content flex-row space-evenly no-margin">
      <Price :title="'Личная фотосессия'" :prices="prices"/>
      <Price :title="'Свадебная фотосессия'" :prices="prices"/>
    </section>
      <section class="content flex-row space-evenly">
        <Price :title="'Семейная фотосессия'" :prices="prices"/>
      </section>
    </div>
  </main>
</template>

<script>
import Price from "@/components/Price";

export default {
  name: "Service",
  data: function() {
    return {
      prices: [1000, 2000, 4500, 7500]
    }
  },
  components: {Price}

}
</script>

<style scoped>


.flex-row {
  flex-flow: row;
}

.no-margin {
  margin: 0;
}

.space-evenly {
  justify-content: space-evenly;
}
</style>