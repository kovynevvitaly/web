<template>
  <Header/>
  <router-view/>
</template>

<style>
.container {
  max-width: 1530px;
  margin: 0 auto;
}

body {
  background-color: #000;
}

#app {
  font-family: 'Montserrat', sans-serif;
  font-size: 25px;
  color: #fff;
  margin: 0;
  padding: 0;
}

a {
  text-decoration: none;
}
</style>
<script>
import Header from "@/components/Header";
export default {
  components: {
    Header
  }
}
</script>