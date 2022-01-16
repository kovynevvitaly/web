<template>
  <h1>Регистрация</h1>
  <form>
    <label for="email">Электронная почта</label>
    <input type="email" id="email" v-model="email">
    <label for="password">Пароль</label>
    <input type="password" id="password" v-model="password">
    <label for="passwordConfirm">Подтверждение пароля</label>
    <input type="password" id="passwordConfirm" v-model="passwordConfirm">
    <router-link :to="{name: 'Login'}">Войти, если уже зарегистрированы</router-link>
    <button type="submit" v-on:submit="onSubmit">Зарегистрироваться</button>
  </form>
</template>

<script>
export default {
  name: "Register",
  data: function() {
    return {
      email: "",
      password: "",
      passwordConfirm: ""
    }
  }, methods: {
    onSubmit() {

    }
  }
}
</script>

<style>
form {
  width: 500px;
  display: flex;
  flex-direction: column;
}

input {
  display: block;
  box-sizing: border-box;
  margin: 10px 0 30px;
  width: 100%;
  border: 1px solid #c3d9e0;
  border-radius: 7px;
  background: #d5dadb;
  height: 40px;
  color: #333;
  padding: 0 14px;
  font-size: 22px;
}

label {
  font-weight: 700;
}

button {
  width: 100%;
  background-color: #081b4a;
  color: #fff;
  padding: 0;
  height: 48px;
  display: flex;
  align-items: center;
  border-radius: 3px;
  justify-content: center;
  text-align: center;
  font-size: 24px;
  font-weight: 500;
  border: 0;
  box-shadow: none;
  cursor: pointer;

}

button:hover {
  background-color: #173276;
}
a {
  margin-bottom: 15px;
  color: #fff;
}

a:hover {
  color: #999;
}
</style>