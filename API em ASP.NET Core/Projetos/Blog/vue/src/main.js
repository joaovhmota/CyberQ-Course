import Vue from 'vue';
import VueRouter from 'vue-router';
import App from './App.vue';
import LoginPage from '@/components/LoginPage';
import HomePage from '@/components/HomePage';

Vue.use(VueRouter);

const router = new VueRouter({
  routes: [
    {path: '/login', component: LoginPage},
    {path: '/', component: HomePage}
  ]
});

Vue.config.productionTip = false;

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
