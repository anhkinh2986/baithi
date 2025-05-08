<template>
  <div class="register">
    <h2>Đăng ký</h2>
    <form @submit.prevent="registerUser">
      <div class="form-group">
        <label for="name">Tên:</label>
        <input type="text" class="form-control" v-model="name" required />
      </div>
      <div class="form-group mt-3">
        <label for="email">Email:</label>
        <input type="email" class="form-control" v-model="email" required />
      </div>
      <div class="form-group mt-3">
        <label for="password">Mật khẩu:</label>
        <input type="password" class="form-control" v-model="password" required />
      </div>
      <button type="submit" class="btn btn-primary mt-3">Đăng ký</button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      name: '',
      email: '',
      password: '',
    };
  },
  methods: {  
    registerUser() {  
      const users = JSON.parse(localStorage.getItem('users')) || [];  
      const userExists = users.some(user => user.email === this.email);  

      if (!this.email.endsWith('@gmail.com')) {  
        alert('Email phải có định dạng @gmail.com.');  
      } else if (userExists) {  
        alert('Email đã được đăng ký.');  
      } else {  
        users.push({ name: this.name, email: this.email, password: this.password });  
        localStorage.setItem('users', JSON.stringify(users));  
        alert('Đăng ký thành công.');  
        this.$router.push('/login');  
      }  
    }
  }
};
</script>