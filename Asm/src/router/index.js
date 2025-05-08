import { createRouter, createWebHistory } from 'vue-router';

// Import các component cần thiết cho từng route
import Home from '../components/Home.vue';
import Login from '../components/Login.vue';
import Register from '../components/Register.vue';
import CreatePost from '../components/CreatePost.vue';
import Post from '../components/Post.vue';
import Profile from '../components/Profile.vue';

// Định nghĩa các route của ứng dụng
const routes = [
    {
        path: '/',
        name: 'Home',
        component: Home,
    },
    {
        path: '/login',
        name: 'Login',
        component: Login,
    },
    {
        path: '/register',
        name: 'Register',
        component: Register,
    },
    {
        path: '/create-post',
        name: 'CreatePost',
        component: CreatePost,
        meta: { requiresAuth: true }, // Bảo vệ route, yêu cầu đăng nhập
    },
    {
        path: '/post/:id',
        name: 'Post',
        component: Post,
    },
    {
        path: '/profile',
        name: 'Profile',
        component: Profile,
        meta: { requiresAuth: true }, // Bảo vệ route, yêu cầu đăng nhập
    },
];

// Khởi tạo router với chế độ lịch sử HTML5
const router = createRouter({
    history: createWebHistory(),
    routes,
});

// Middleware kiểm tra xác thực trước khi truy cập vào các route yêu cầu đăng nhập
router.beforeEach((to, from, next) => {
    const loggedIn = !!localStorage.getItem('loggedInUser');

    if (to.matched.some(record => record.meta.requiresAuth) && !loggedIn) {
        next('/login'); // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
    } else {
        next(); // Nếu đã đăng nhập hoặc không yêu cầu đăng nhập, tiếp tục điều hướng
    }
});

export default router;