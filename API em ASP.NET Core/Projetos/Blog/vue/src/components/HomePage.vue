<template>
	<main>
    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg bg-light">
      <div class="container-fluid">
        <a class="navbar-brand" href="#"> <img id="logo" src="../assets/imgs/ah_negao_logo.png" alt="Logo"> </a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item">
              <a class="nav-link active" aria-current="page" href="#">Página Inicial</a>
            </li>
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle active" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                Categorias
              </a>
              <ul id="categoriesList" class="dropdown-menu" aria-labelledby="navbarDropdown">
                <li v-for="(category) in categories" v-bind:key="category.id"><a class="dropdown-item" style="text-transform: capitalize;">{{category.name}}</a></li>
              </ul>
            </li>
          </ul>
          <form v-if="this.userLogged != null" class="center d-flex" role="search">
              {{userLogged.username}}
              <button type="submit" v-on:click="logOff()" class="someMarginLeft btn btn-outline-danger"> Sair da conta </button>
          </form>
          <form v-if="this.userLogged == null" class="center d-flex" action="#/login">
              <button type="submit" class="someMarginLeft someMarginRight btn btn-outline-success"> Login </button>
          </form>
        </div>
      </div>
    </nav>

    <!-- Fazer post -->
    <div class="someMarginTop container" style="width: 650px;" v-if="this.userLogged != null && ( this.userLogged.isEditor || this.userLogged.isAdmin)">
      <form action="./">
        <input class="form-control" type="text" v-model="postToUpload.title" placeholder="Título" required>
        <textarea class="someMarginTop form-control" rows="10" v-model="postToUpload.content" placeholder="Conteúdo" style="resize: none;"></textarea>
        <div class="someMarginTop right">
            <button class="btn btn-outline-success" type="button" v-on:click="publicPost()"> Publicar </button>
        </div>
      </form>
    </div>
    
    <!-- Posts -->
    <div class="aLotOfMarginTop container">
        <div class="accordion" id="accordionExample">
          <div class="accordion-item" v-for="post in allPosts" v-bind:key="post.id">
            <h2 class="accordion-header" id="headingOne">
              <button class="accordion-button" type="button" data-bs-toggle='{{post.id}}' data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                {{post.title}}
              </button>
            </h2>
            <div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
              <div class="accordion-body">
                {{post.content}}
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
      categories: [],
      allPosts: [],
      allUsers: [],
      recentPosts: '',
      postToUpload: {}
    }
  },
  async beforeMount() {
    await this.getUserLogged();
    await this.loadCategories();
    await this.loadPosts();
  },
  methods: {
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
    async loadCategories() {
      var request = await fetch('https://localhost:7251/api/Categories');
      var requestReturn = await request.json();
      this.categories = await requestReturn;
    },
    async publicPost() {
        const toPost = {
          title: this.postToUpload.title,
          content: this.postToUpload.content,
          creationDate: new Date().toLocaleDateString(),
          userId: this.userLogged.id,
          categoryId: 1
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
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

nav {
  position: sticky;
  top: 0;
  z-index: 10000;
}

#logo {
  width: 250px;
}

.post {
  display: flex; justify-content: left; float: left;
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
