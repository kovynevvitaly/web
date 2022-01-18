import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'
import Portfolio from "@/views/Portfolio";
import Service from "@/views/Service";
import News from "@/views/News";
import Register from "@/views/Register";
import Login from "@/views/Login";
import NewsEditor from "@/views/NewsEditor";

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/portfolio',
    name: "Portfolio",
    component: Portfolio
  },
  {
    path: '/service',
    name: 'Service',
    component: Service
  },
  {
    path: '/news',
    name: 'News',
    component: News
  },
  {
    path: '/register',
    name: 'Register',
    component: Register
  },
  {
    path: '/login',
    name: 'Login',
    component: Login
  },
  {
    path: '/editor',
    name: 'NewsEditor',
    component: NewsEditor
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
