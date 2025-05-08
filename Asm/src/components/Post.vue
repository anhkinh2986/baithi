<template>  
  <div class="post">  
    
    <form v-if="isEditing" @submit.prevent="updatePost">  
      <input type="text" class="form-control" v-model="editedPost.title" required />  
      <textarea class="form-control" v-model="editedPost.content" rows="5" required></textarea>  
      <button type="submit" class="btn btn-primary mt-3">Cập nhật bài viết</button>  
    </form>  

    <div v-else>  
      <h2 class="text-center">{{ isEditing ? 'Chỉnh sửa bài viết' : post.title }}</h2> 
      <p class="text-center" style="color: rgba(0, 0, 0, 0.4);"><strong>Tác giả:</strong> {{ post.author }}</p>  
      <div class="container">
        <div class="row">
          <div class="col-6">
           <img :src="post.image" alt="Post image" width="90%" v-if="post.image">  
          </div>
          <div class="col-6 p-3"> 
            <p>{{ post.content }}</p> 
          </div>
        </div>
      </div>
      <button class="btn btn-secondary m-3" @click="enableEdit">Chỉnh sửa</button>  
      <button class="btn btn-danger m-3" @click="deletePost">Xóa bài viết</button>  
    </div>  

    <div class="row">
      <div class="col-4">
        <div class="card p-3">
          <h3>Bình luận</h3>  
          <ul>  
            <li v-for="comment in comments" :key="comment.id">{{ comment.author }}: {{ comment.content }}</li>  
          </ul>  

          <form @submit.prevent="addComment">  
            <input type="text" class="form-control" v-model="newComment" placeholder="Write a comment..." required />  
            <button type="submit" class="btn btn-primary mt-3">Thêm bình luận</button>  
          </form>
        </div>  
      </div>
    </div>
  </div>  
</template>  

<script>  
export default {  
  data() {  
    return {  
      post: null,  
      comments: [],  
      newComment: '',  
      isEditing: false,  
      editedPost: {  
        title: '',  
        content: ''  
      }  
    };  
  },  
  created() {  
    const postId = this.$route.params.id;  
    const posts = JSON.parse(localStorage.getItem('posts')) || [];  
    this.post = posts.find(post => post.id === Number(postId));  

    const allComments = JSON.parse(localStorage.getItem('comments')) || [];  
    this.comments = allComments.filter(comment => comment.postId === Number(postId));  
    
    // Initialize editedPost with current post data  
    this.editedPost.title = this.post.title;  
    this.editedPost.content = this.post.content;  
  },  
  methods: {  
    addComment() {  
      const loggedInUser = JSON.parse(localStorage.getItem('loggedInUser'));  
      const comments = JSON.parse(localStorage.getItem('comments')) || [];  

      const newComment = {  
        id: Date.now(),  
        postId: this.post.id,  
        content: this.newComment,  
        author: loggedInUser.name  
      };  

      comments.push(newComment);  
      localStorage.setItem('comments', JSON.stringify(comments));  
      this.comments.push(newComment);  
      this.newComment = '';  
    },  
    deletePost() {  
      const posts = JSON.parse(localStorage.getItem('posts')) || [];  
      const updatedPosts = posts.filter(post => post.id !== this.post.id);  
      localStorage.setItem('posts', JSON.stringify(updatedPosts));  

      // Remove comments related to the post  
      const comments = JSON.parse(localStorage.getItem('comments')) || [];  
      const updatedComments = comments.filter(comment => comment.postId !== this.post.id);  
      localStorage.setItem('comments', JSON.stringify(updatedComments));  

      // Redirect to the posts list  
      this.$router.push('/posts');  
    },  
    enableEdit() {  
      this.isEditing = true;  
    },  
    updatePost() {  
      const posts = JSON.parse(localStorage.getItem('posts')) || [];  
      const postIndex = posts.findIndex(post => post.id === this.post.id);  

      // Update post in the array  
      if (postIndex !== -1) {  
        posts[postIndex].title = this.editedPost.title;  
        posts[postIndex].content = this.editedPost.content;  
        localStorage.setItem('posts', JSON.stringify(posts));  

        // Update the current post  
        this.post.title = this.editedPost.title;  
        this.post.content = this.editedPost.content;  

        // Exit editing mode  
        this.isEditing = false;  
      }  
    }  
  }  
};  
</script>