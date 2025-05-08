<template>
  <div class="create-post">
    <h2>Tạo bài viết</h2>
    <form @submit.prevent="submitPost">
      <div class="form-group">
        <label for="title">Tiêu đề:</label>
        <input type="text" class="form-control" v-model="title" required />
      </div>
      <div class="form-group">
        <label for="content">Nội dung:</label>
        <!-- Thêm thuộc tính wrap và chỉnh CSS để xuống dòng -->
        <textarea 
          wrap="hard" 
          style="white-space: pre-wrap;" 
          rows="4" 
          cols="50" 
          class="form-control" 
          v-model="content" 
          required>
        </textarea>
      </div>
      <div class="form-group">
        <label for="image">Ảnh:</label>
        <input type="text" class="form-control" v-model="image" />
      </div>
      <button type="submit" class="btn btn-primary mt-3">Đăng</button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: '',
      content: '',
      image: ''
    };
  },
  methods: {
    submitPost() {
      const posts = JSON.parse(localStorage.getItem('posts')) || [];
      const loggedInUser = JSON.parse(localStorage.getItem('loggedInUser'));

      const newPost = {
        id: Date.now(),
        title: this.title,
        content: this.content,
        image: this.image,
        author: loggedInUser.name,
        createdAt: new Date().toISOString()
      };

      posts.push(newPost);
      localStorage.setItem('posts', JSON.stringify(posts));
      alert('Bài viết được tạo thành công!');
      this.$router.push('/');
    }
  }
};
</script>