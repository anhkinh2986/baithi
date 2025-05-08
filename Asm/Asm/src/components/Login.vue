<template>
  <div class="login">
    <h2>Đăng nhập</h2>
    <form @submit.prevent="loginUser">
      <div class="form-group">
        <label for="email">Email:</label>
        <input type="email" class="form-control" v-model="email" required />
      </div>
      <div class="form-group mt-3">
        <label for="password">Mật khẩu:</label>
        <input type="password" class="form-control" v-model="password" required />
      </div>
      <button type="submit" class="btn btn-primary mt-3">Đăng nhập</button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      email: '',
      password: '',
    };
  },
  methods: {
    loginUser() {
      const users = JSON.parse(localStorage.getItem('users')) || [];
      const user = users.find(user => user.email === this.email && user.password === this.password);

      if (user) {
        localStorage.setItem('loggedInUser', JSON.stringify(user));
        alert('Đăng nhập thành công!');
        this.$router.push('/');
      } else {
        alert('Email hoặc mật khẩu không hợp lệ.');
      }
    }
  }
};
</script>

<style>
#login {
  padding: auto;
}
</style>