<template>
  <article>
    <div class="article-datetime">{{ article.datetime }}</div>
    <div class="article-title">{{ article.title }}</div>
    <div class="article-content">{{ article.content }}</div>
  </article>
</template>

<script>
export default {
  name: "NewsItem",
  props: ["article"]
}
</script>

<style scoped>
article {
  margin-left: 45px;
}

.article-datetime {
  font-weight: 700;
  margin-bottom: 10px;
}

.article-title {
  margin-bottom: 20px;
}

.article-content {
  margin-bottom: 60px;
}
</style>