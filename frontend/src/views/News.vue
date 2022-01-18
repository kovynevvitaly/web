<template>
  <h1>Новости</h1>
  <NewsItem :article="article" v-for="(article, key) in articles" :key="key"/>
</template>

<script>
import axios from 'axios';
import NewsItem from '@/components/NewsItem';

export default {
  name: "News",
  components: {NewsItem},
  data: function() {
    return {
      articles: []
    }
  },
  mounted() {
    axios.get("http://localhost:9000/api/News")
      .then((response) => {
        this.articles = response.data;
      });
  }
}
</script>

<style scoped>
h1 {
  text-align: center;
}
</style>