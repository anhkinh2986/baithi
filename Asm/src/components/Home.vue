<template>
  <div class="container-fluid">
    <div id="demo" class="carousel slide" data-bs-ride="carousel">
      <!-- Indicators/dots -->
      <div class="carousel-indicators">
        <button type="button" data-bs-target="#demo" data-bs-slide-to="0" class="active"></button>
        <button type="button" data-bs-target="#demo" data-bs-slide-to="1"></button>
        <button type="button" data-bs-target="#demo" data-bs-slide-to="2"></button>
      </div>
      
      <!-- The slideshow/carousel -->
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img src="../image/1.png" alt="Los Angeles" class="d-block" style="width:100%">
        </div>
        <div class="carousel-item">
          <img src="../image/3.png" alt="Chicago" class="d-block" style="width:100%">
        </div>
        <div class="carousel-item">
          <img src="../image/4.png" alt="New York" class="d-block" style="width:100%">
        </div>
      </div>
      
      <!-- Left and right controls/icons -->
      <button class="carousel-control-prev" type="button" data-bs-target="#demo" data-bs-slide="prev">
        <span class="carousel-control-prev-icon"></span>
      </button>
      <button class="carousel-control-next" type="button" data-bs-target="#demo" data-bs-slide="next">
        <span class="carousel-control-next-icon"></span>
      </button>
    </div>
  </div>
  <div class="container">
    <div class="row">
      <div class="col-4"></div>
      <div class="col-12" style="display: flex; flex-wrap: wrap; justify-content: center;">
        <div class="card m-2 card-design" style="width: 18rem;" v-for="post in posts" :key="post.id">
          <img :src="post.image" class="card-img-top" alt="...">
          <div class="card-body">
            <h5 class="card-title">{{ post.title }}</h5>
          </div>
          <router-link :to="'/post/' + post.id" class="btn btn-primary mb-3" style="width: 50%; margin: auto;">Đọc thêm</router-link>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      posts: [],
    };
  },
  created() {
    this.posts = JSON.parse(localStorage.getItem('posts')) || [];
  },
};
</script>

<style scoped>
  .card-design{
    transition: all ease-in-out 0.5s;
    filter: drop-shadow(0px 0px 0px black);
  }
  .card-design:hover{
    filter: drop-shadow(0px 0px 4px black);
  }
</style>