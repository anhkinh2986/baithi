<template>  
  <div class="container-design">
    <div class="container">  
      <div class="row">  
        <div class="col-sm-4">  
          <div class="profile">  
            <h2 class="text-info mb-3 mt-4">Hồ sơ</h2>  
            <form @submit.prevent="updateProfile">  
              <div class="form-group">  
                <label for="name" class="text-light">Tên:</label>  
                <input type="text" class="form-control" v-model="user.name" required />  
              </div>  
              <div class="form-group mt-3">  
                <label for="email" class="text-light">Email:</label>  
                <input type="email" class="form-control" v-model="user.email" required />  
              </div>  
              <div class="form-group mt-3">  
                <label for="password" class="text-light">Mật khẩu:</label>  
                <input type="password" class="form-control" v-model="user.password" required />  
              </div>  
              <button type="submit" class="btn btn-primary mt-3">Cập nhật</button>  
            </form>  
          </div>  
        </div>  
      </div>  
    </div>  
  </div>
</template>  

<script>  
export default {  
  data() {  
    return {  
      user: JSON.parse(localStorage.getItem('loggedInUser')) || {}  
    };  
  },  
  methods: {  
    updateProfile() {  
      const users = JSON.parse(localStorage.getItem('users')) || [];  
      const updatedUsers = users.map(u => u.email === this.user.email ? this.user : u);  

      localStorage.setItem('users', JSON.stringify(updatedUsers));  
      localStorage.setItem('loggedInUser', JSON.stringify(this.user));  
      alert('Hồ sơ được cập nhật thành công!');  
    }  
  }  
};  
</script>

<style scoped>
  .container-design{
    background-image:url(/src/image/12.jpg);
    background-size: 100%;
    width: 100%;
    height: 100vh;
    background-repeat: no-repeat;
  }
</style>