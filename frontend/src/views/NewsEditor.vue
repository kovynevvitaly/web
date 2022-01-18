<template>
  <h1>Создание новости</h1>
  <form>
    <label for="title">Заголовок новости</label>
    <input type="text" id="title" v-model="title">
    <label for="content">Содержимое</label>
    <textarea id="content" v-model="content" rows="40" cols="80"></textarea>
    <button type="button" v-on:click="onClick">Создать новость</button>
  </form>
</template>

<script>
import axios from 'axios';

export default {
  name: "NewsEditor",
  data: function() {
    return {
      title: "",
      content: ""
    }
  },
  methods: {
    onClick() {
      axios.post("http://localhost:9000/api/News", {
        title: this.title,
        content: this.content,
      }).then((response) => {
        console.log(response);
        this.$router.push({ name: "Home" });
      })
    }
  }
}
</script>

<style scoped>
textarea {
  display: block;
  box-sizing: border-box;
  margin: 10px 0 30px;
  width: 100%;
  border: 1px solid #c3d9e0;
  border-radius: 7px;
  background: #d5dadb;
  color: #333;
  padding: 0 14px;
  font-size: 22px;
}
</style>