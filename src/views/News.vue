<template>
  <h1>Новости</h1>
  <NewsItem :article="article"/>
  <NewsItem :article="article"/>
</template>

<script>
import NewsItem from '@/components/NewsItem';

export default {
  name: "News",
  components: {NewsItem},
  data: function() {
    return {
      article: {
        title: "Test title",
        datetime: "16.01.2021",
        content: "Test content"
      }
    }
  }
}
</script>

<style scoped>
h1 {
  text-align: center;
}
</style>