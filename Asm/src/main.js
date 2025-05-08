import { createApp } from 'vue';
import App from './App.vue';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue/dist/bootstrap-vue.css';
import { createRouter, createWebHistory } from 'vue-router';



// Import các component cho các route
import Home from './components/Home.vue';
import Login from './components/Login.vue';
import Register from './components/Register.vue';
import CreatePost from './components/CreatePost.vue';
import Post from './components/Post.vue';
import Profile from './components/Profile.vue';

// Tạo router với các đường dẫn
const routes = [
    { path: '/', component: Home },
    { path: '/login', component: Login },
    { path: '/register', component: Register },
    { path: '/create-post', component: CreatePost, meta: { requiresAuth: true } },
    { path: '/post/:id', component: Post },
    { path: '/profile', component: Profile, meta: { requiresAuth: true } },
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

// Kiểm tra nếu chưa đăng nhập mà cố gắng truy cập các route cần xác thực
router.beforeEach((to, from, next) => {
    const loggedIn = !!localStorage.getItem('loggedInUser');
    if (to.matched.some(record => record.meta.requiresAuth) && !loggedIn) {
        next('/login');
    } else {
        next();
    }
});

// Khởi tạo ứng dụng Vue và gắn router vào
createApp(App).use(router).mount('#app');