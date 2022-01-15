<template>
    <footer>
    <div class="footer-content">
      <a href="https://www.instagram.com/ph_nik.v/"><img :src="require('@/assets/svg/inst_icon.svg')" alt="инстаграм" class="logo-link"></a>
      <a href="https://vk.com/ph_nik_v"><img :src="require('@/assets/svg/vk_icon.svg')" alt="вконтакте" class="logo-link vk"></a>
      <a href="mailto:nik.vor@yandex.ru"><img :src="require('@/assets/svg/email-icon.svg')" alt="почта" class="logo-link"></a>
    </div>
    <div class="phone">
      +7-800-555-35-35
    </div>
  </footer>
</template>

<script>
export default {
  name: "Footer"
}
</script>

<style scoped>

footer {
  margin: 80px 0;
}

.footer-content {
  width:10%;
  margin: 0 auto;
  display: flex;
  justify-content: space-around;
  align-items: center;
}

.logo-link {
  height: 25px;
  width: 25px;
}

.vk {
  border-radius: 3px;
}

.phone {
  margin-top: 20px;
  display: flex;
  justify-content: space-around;
  align-items: center;
}
</style>