<template>
  <h1>Вход</h1>
  <form>
    <label for="email">Электронная почта</label>
    <input type="email" id="email" v-model="email">
    <label for="password">Пароль</label>
    <input type="password" id="password" v-model="password">
    <router-link :to="{name: 'Register'}">Зарегистрироваться</router-link>
    <button type="submit" v-on:submit="onSubmit">Войти</button>
  </form>
</template>

<script>
export default {
  name: "Login",
  data: function() {
    return {
      email: "",
      password: "",
    }
  }, methods: {
    onSubmit() {

    }
  }
}
</script>

<style scoped>

</style>