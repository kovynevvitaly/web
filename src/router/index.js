import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'
import Portfolio from "@/views/Portfolio";
import Service from "@/views/Service";

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
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
