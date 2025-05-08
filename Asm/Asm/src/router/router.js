import { createRouter, createWebHistory } from 'vue-router';
import Home from '../components/Home.vue';
import Register from '../components/Register.vue'
import Login from '../components/Login.vue';
import Profile from '../components/Profile.vue';
import PostForm from '../components/PostForm.vue';
import PostList from '../components/PostList.vue';

const routes = [
    { path: '/', name: 'Home', component: Home },
    { path: '/create-post', name: 'CreatePost', component: PostForm },
    { path: '/posts', name: 'Posts', component: PostList },
    { path: '/login', name: 'Login', component: Login },
    { path: '/register', name: 'Register', component: Register },
];

const router = createRouter({
    history: createWebHistory(),
    routes
});

// Route guard cho authentication
router.beforeEach((to, from, next) => {
    const isAuthenticated = !!localStorage.getItem('authToken');
    if (to.meta.requiresAuth && !isAuthenticated) {
        next('/login');
    } else {
        next();
    }
});

export default router;