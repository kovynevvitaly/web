<template>
  <Header/>
  <router-view/>
  <Footer/>
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

.content {
  display: flex;
  flex-flow: column;
  margin-bottom: 260px;
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

.photo {
  height: 500px;
  border-radius: 25px;
}

.photos {
  display: flex;
  justify-content: space-between;
}
</style>
<script>
import Footer from "@/components/Footer";
import Header from "@/components/Header";
export default {
  components: {
    Header,
    Footer
  }
}
</script>