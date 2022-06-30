<template>
	<main style="background-color: #561759; height: 100%; width: 100%">
    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg bg-light" style="background-color: #50105A !important;">
      <div class="container-fluid">
        <a class="navbar-brand" href="#"> <img id="logo" src="../assets/imgs/ah_negao_logo.png" alt="Logo"> </a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item">
              <a class="nav-link active" aria-current="page" href="#" style="color: #F2F2F2 !important;">Página Inicial</a>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle active" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false" style="color: #F2F2F2 !important;">
                Categorias
              </a>
              <ul id="allCategoriesList" class="dropdown-menu" aria-labelledby="navbarDropdown">
                <li v-for="(category) in allCategories" v-bind:key="category.id"><a class="dropdown-item" style="text-transform: capitalize;">{{category.name}}</a></li>
              </ul>
            </li>
          </ul>
          <form v-if="this.userLogged != null" class="center d-flex" role="search" style="color: #f2f2f2;">
              {{userLogged.username}}
              <button type="submit" v-on:click="logOff()" class="someMarginLeft btn btn-danger"> Sair da conta </button>
          </form>
          <form v-if="this.userLogged == null" class="center d-flex" action="#/login">
              <button type="submit" class="someMarginLeft someMarginRight btn btn-outline-light"> Login </button>
          </form>
        </div>
      </div>
    </nav>

    <!-- Fazer post -->
    <div class="aLotOfMarginTop container" style="width: 650px;" v-if="this.userLogged != null && ( this.userLogged.isEditor || this.userLogged.isAdmin)">
      <form action="./">
        <input class="form-control" type="text" v-model="postToUpload.title" placeholder="Título" required>
        <textarea class="someMarginTop form-control" rows="10" v-model="postToUpload.content" placeholder="Conteúdo" style="resize: none;"></textarea>

        <div class="left">
          <div>
            <select class="form-select someMarginTop" aria-label="Default select example" v-model="postToUpload.categoryId" style="width: max-content;" >
              <option v-for="category in allCategories" :key="category.id" :value="category.id">{{category.name}}</option>
  
            </select>
          </div>

          <div class="someMarginTop right" style="width: 100%;">
              <button class="btn btn-success" type="button" v-on:click="publicPost()"> Publicar </button>
          </div>
        </div>

      </form>
    </div>
    
    <!-- Posts -->
    <div class="aLotOfMarginTop container">
        <div class="accordion" id="accordionExample">
          <div class="accordion-item" v-for="post in allPosts" v-bind:key="post.id">
            <h2 class="accordion-header" id="headingOne">
              <button class="accordion-button" type="button" data-bs-toggle="collapse" v-bind:data-bs-target="('#post' + post.id)" aria-expanded="true" v-bind:aria-controls="('post' + post.id)">
               <div class="left" style="width: 50%; color: #7B1481;">
                <strong> {{post.title}} </strong>
               </div>
              </button>
            </h2>
            <div v-bind:id="('post' + post.id)" class="accordion-collapse collapse" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
              <div class="accordion-body post">
                <div>
                  <i>Escrito por: </i> <span class="badge bg-primary"> {{allUsers.find( u => u.id == post.userId).username}} </span> <br> 
                  <i>Categoria: </i> <span class="badge bg-primary"> {{allCategories.find( c => c.id == post.categoryId).name}} </span> <br>
                  <i>Publicado em: </i> <span class="badge bg-primary"> {{post.creationDate}} </span>
                </div>

                <hr>

                <div>
                  <p>{{post.content}}</p>

                  <p style="display: flex; justify-content: right;" v-if="userLogged != null && (post.userId == userLogged.id || userLogged.isAdmin == true)"> 
                    <button class="btn btn-danger" v-on:click="removePost(post.id)"> 🗑 Excluir post </button>
                  </p>
                </div>

                <hr v-if="userLogged != null">

                <h5> Comentários </h5>
                <div v-if="userLogged != null">
                  <div class="input-group mb-3">
                    <span class="input-group-text" id="basic-addon1">💬</span>
                    <input type="text" class="form-control" v-model="commentToUpload.content" placeholder="Username" aria-label="Comentário" aria-describedby="basic-addon1">
                    <button class="btn btn-success" v-on:click="publicComment(post.id)"> Publicar </button>
                  </div>
                </div>

                <div v-for="comment in allComments" v-bind:key="comment.id">
                    <div v-if="(comment.postId == post.id)" style="word-wrap: break-word;">
                        <span class="badge bg-primary">{{comment.createdAt}}</span>
                        <span v-if="userLogged != null && (post.userId == userLogged.id || userLogged.isAdmin == true)" v-on:click="removeComment(comment.id)" class="badge bg-danger" style="cursor: pointer;"> 🗑 </span>
                        <p>
                          <strong>{{allUsers.find(u => u.id == comment.userId).username}} </strong> disse: {{comment.content}}
                        </p>
                    </div>
                </div>

              </div>
            </div>
          </div>
        </div>
    </div>
	</main>
</template>

<script>
export default {
  name: 'HomePage',
  data() {
    return {
      userLogged : null,
      allCategories: [],
      allPosts: [],
      allUsers: [],
      allComments: [],
      recentPosts: '',
      postToUpload: {},
      commentToUpload: {}
    }
  },
  async beforeMount() {
    await this.getUserLogged();
    await this.loadallCategories();
    await this.loadPosts();
    await this.loadComments();
  },
  methods: {
    async currentUserCategories() {
      return this.userLogged.allowedCategories.replace('$', '').split(';');
    },
    async publicComment(i) {
        const toComment = {
            content: this.commentToUpload.content,
            createdAt: new Date().toLocaleDateString(),
            userId: this.userLogged.id,
            postId: i
        };

        const request = new Request('https://localhost:7251/api/Comments', {
            method: 'post',
            headers: {
              'Accept': 'application/json',
              'Content-type': 'application/json'
            },
            body: JSON.stringify(toComment, null, 2)
        });

        const execRequest = await fetch(request);
        const returnRequest = await execRequest.json();
        this.allComments.push(returnRequest);
    },
    async loadComments() {
      await fetch('https://localhost:7251/api/Comments').then(str => str.json()).then(comments => {
        this.allComments = comments;
      });
    },
    async loadPosts() {
      await fetch('https://localhost:7251/api/Posts').then( str => str.json()).then(posts => {
        this.allPosts = posts;
      });
    },
    async getUserLogged() {
      await fetch('https://localhost:7251/api/Users').then(str => str.json()).then(strJson => {
        this.allUsers = strJson;
      });
  
      var userLogged = await JSON.parse(sessionStorage.getItem('userLogged'));
      if (userLogged == null) userLogged = await JSON.parse(localStorage.getItem('userLogged'));
      this.userLogged = await userLogged;
    },
    logOff() {
      sessionStorage.removeItem('userLogged');
      localStorage.removeItem('userLogged');
      this.userLogged = null;
    },
    async loadallCategories() {
      var request = await fetch('https://localhost:7251/api/Categories');
      var requestReturn = await request.json();
      this.allCategories = await requestReturn;
      console.log(this.allCategories);
    },
    async publicPost() {
        const toPost = {
          title: this.postToUpload.title,
          content: this.postToUpload.content,
          creationDate: new Date().toLocaleDateString(),
          userId: this.userLogged.id,
          categoryId: this.postToUpload.categoryId
        }

        const request = new Request('https://localhost:7251/api/Posts', {
          method: 'post',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          },
          body: JSON.stringify(toPost, null, 2)
        });
  
        const execRequest = await fetch(request);
        const returnRequest = await execRequest.json();
        this.allPosts.push(returnRequest);

        console.log(toPost);
    },
    async removePost(i) {
        const request = new Request(`https://localhost:7251/api/Posts/${i}`, {
          method: 'DELETE',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          }
        });
  
        await fetch(request);
        window.location.reload();
    },
    async removeComment(i) {
      const request = new Request(`https://localhost:7251/api/Comments/${i}`, {
          method: 'DELETE',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          }
        });
  
        await fetch(request);
        window.location.reload();
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Noto+Sans+JP:wght@100;300;400;500;700;900&display=swap');

* {
  font-family: 'Noto Sans JP', sans-serif;
}

.accordion-button, .accordion-item {
  text-align: left;
  justify-content: left;
}

nav {
  position: sticky;
  top: 0;
  z-index: 10000;
}

#logo {
  width: 250px;
}

.post {
  display: flex !important;
  justify-content: left !important; 
  flex-direction: column;
}
.someMarginTop {
  margin-top: 10px;
}

.aLotOfMarginTop {
  margin-top: 50px;
}

.someMarginLeft {
  margin-left: 10px;
}

.someMarginRight {
  margin-right: 10px;
}

.center {
  display: flex;
  align-items: center;
  justify-content: center;
}

.left {
  display: flex;
  justify-content: left;
}

.right {
  display: flex;
  justify-content: right;
}
</style>
