<template>
  <h1>Вход</h1>
  <form>
    <label for="email">Электронная почта</label>
    <input type="email" id="email" v-model="email">
    <label for="password">Пароль</label>
    <input type="password" id="password" v-model="password">
    <router-link :to="{name: 'Register'}">Зарегистрироваться</router-link>
    <button type="button" v-on:click="onClick">Войти</button>
  </form>
</template>

<script>
import axios from 'axios';

export default {
  name: "Login",
  data: function() {
    return {
      email: "",
      password: "",
    }
  }, methods: {
    onClick() {
      axios.post("http://localhost:9000/api/User/Login", {
        email: this.email,
        password: this.password,
      }).then((response) => {
        sessionStorage.setItem("accessToken", response.data.accessToken);
        sessionStorage.setItem("email", response.data.email);
        sessionStorage.setItem("userId", response.data.userId);
        this.$router.push({ name: "Home" });
      })
    }
  }
}
</script>

<style scoped>

</style>