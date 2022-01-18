<template>
  <header>
    <div class="container top-nav">
      <nav class="link-list">
        <router-link :to="{name: 'Home'}" class="logo">PhotoNik</router-link>
        <router-link :to="{name: 'Home'}" class="nav-link" active-class="link-active">Главная</router-link>
        <router-link :to="{name: 'Service'}" class="nav-link" active-class="link-active">Услуги</router-link>
        <router-link :to="{name: 'Portfolio'}" class="nav-link" active-class="link-active">Портфолио</router-link>
        <router-link :to="{name: 'News'}" class="nav-link" active-class="link-active">Новости</router-link>
        <router-link :to="{name: 'Register'}" class="nav-link" active-class="link-active" v-if="!isAuthorized()">Регистрация</router-link>
        <a href="/" v-on:click="logOut" v-if="isAuthorized()">{{ email }}</a>
        <a href="/" v-on:click="logOut" v-if="isAuthorized()">Выйти</a>
      </nav>
    </div>
  </header>
</template>

<script>
export default {
  name: "Header",
  data: function() {
    return {
      email: "",
    }
  },
  methods: {
    isAuthorized() {
      console.log("IsAuthorized: " + sessionStorage.getItem("accessToken"));
      return sessionStorage.getItem("accessToken") !== null;
    },
    logOut() {
      sessionStorage.removeItem("accessToken");
      sessionStorage.removeItem("email");
    }
  },
  mounted() {
    this.email = sessionStorage.getItem("email");
  }
}
</script>

<style scoped>
header {
  margin-top: 50px;
}

.top-nav {
  display: flex;
}

.logo {
  font-family: 'Playfair Display', serif;
  font-size: 64px;
  color: #fff;
}

.link-list {
  display: flex;
  justify-content: space-between;
  align-items: baseline;
  width: 100%;
}

.nav-link {
  color: #fff;
}

.nav-link:hover {
  color: #999;
}

.link-active {
  font-weight: 700;
}
</style>