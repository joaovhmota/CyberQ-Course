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
                <li><a class="dropdown-item" style="text-transform: capitalize;" v-on:click="filterCategoy('')">Todas</a></li>
                <li><hr class="dropdown-divider"></li>
                <li v-for="(category) in allCategories" v-bind:key="category.id"><a class="dropdown-item" style="text-transform: capitalize;" v-on:click="filterCategoy(category.name)">{{category.name}}</a></li>
              </ul>
            </li>
          </ul>
          <form v-if="this.userLogged != null" class="center d-flex" role="search" style="color: #f2f2f2;">
              {{userLogged.username}}
              <button v-if="(userLogged.isAdmin == true)" type="button" class="btn btn-outline-light someMarginLeft" data-bs-toggle="modal" data-bs-target="#adminPanel">
                Painel do Admin
              </button>
              <button type="submit" v-on:click="logOff()" class="someMarginLeft btn btn-danger"> Sair da conta </button>
          </form>
          <form v-if="this.userLogged == null" class="center d-flex" action="#/login">
              <button type="submit" class="someMarginLeft someMarginRight btn btn-outline-light"> Login </button>
          </form>
        </div>
      </div>
    </nav>

    <!-- Painel Admin -->
    <div class="modal fade" id="adminPanel" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true" style="z-index: 10000;">
      <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="staticBackdropLabel"> Configurações do site </h5>
            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
          </div>
          <div class="modal-body">
            
            <div class="accordion accordion-flush" id="accordionFlushExample">
              <!-- Usuários -->
              <div class="accordion-item">
                <h2 class="accordion-header" id="flush-headingOne">
                  <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                    Usuários
                  </button>
                </h2>
                <div id="flush-collapseOne" class="accordion-collapse collapse" aria-labelledby="flush-headingOne" data-bs-parent="#accordionFlushExample">
                  
                  <div class="accordion-body">
                    <form action="./" class="someMarginTop">
                        <div class="input-group mb-3">
                          <span class="input-group-text" id="basic-addon1">👤</span>
                          <input type="text" name="" id="txtUsername" v-model="newEditor.username" class="form-control" placeholder="Usuário (Editor)" autocomplete="off">
                        </div>
  
                        <div class="input-group mb-3 someMarginTop">
                          <span class="input-group-text" id="basic-addon1">🔒</span>
                          <input type="text" name="" id="txtPassword" v-model="newEditor.password" class="form-control" placeholder="Senha (Editor)" autocomplete="off">
                        </div>
  
                        <div class="left someMarginBottom">
                          <button v-if="editingUser == false" type="button" class="btn btn-outline-success" v-on:click="registerNewEditor()"> Cadastrar </button>
                          <button v-if="editingUser == true" type="button" class="btn btn-warning" v-on:click="updateSelectedUser()"> Atualizar </button>
                          <button v-if="editingUser == true" type="button" class="someMarginLeft btn btn-danger" v-on:click="deleteSelectedUser()"> Remover </button>
                          <button v-if="editingUser == true" type="button" class="someMarginLeft btn btn-outline-dark" v-on:click="cancelUserEdit()"> Cancelar </button>
  
                        </div>
                    </form>

                    <table class="table table-striped">
                      <thead>
                        <tr>
                          <th> Usuário </th>
                          <th> Senha </th>
                          <th> Cargo </th>
                          <th> Ação </th>
                        </tr>
                      </thead>
                      <tbody v-for="(user) in allUsers" v-bind:key="user.id">
                          <tr v-if="user.isAdmin == false">
                            <td> {{user.username}} </td>
                            <td> {{user.password}} </td>
                            <td> {{(user.isEditor ? "Editor" : "Leitor")}}</td>
                            <td> <button type="button" class="btn btn-outline-danger" v-on:click="adminSelectUser(user)"> Selecionar </button> </td>
                          </tr>
                      </tbody>
                    </table>
                  </div>

                </div>
              </div>

              <div class="accordion-item">
                <h2 class="accordion-header" id="flush-headingTwo">
                  <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
                    Categorias
                  </button>
                </h2>
                <div id="flush-collapseTwo" class="accordion-collapse collapse" aria-labelledby="flush-headingTwo" data-bs-parent="#accordionFlushExample">
                  <div class="accordion-body">

                    <form action="./" class="someMarginTop">
                      <div class="input-group mb-3">
                        <span class="input-group-text" id="basic-addon1">🔖</span>
                        <input type="text" name="" id="txtUsername" v-model="newCategory.name" class="form-control" placeholder="Nome" autocomplete="off">
                      </div>

                      <div class="left someMarginBottom">
                          <button v-if="editingCategory == false" type="button" class="btn btn-outline-success" v-on:click="registerNewCategory()"> Cadastrar </button>
                          <button v-if="editingCategory == true" type="button" class="btn btn-warning" v-on:click="updateSelectedCategory()"> Atualizar </button>
                          <button v-if="editingCategory == true" type="button" class="someMarginLeft btn btn-danger" v-on:click="deleteSelectedCategory()"> Remover </button>
                          <button v-if="editingCategory == true" type="button" class="someMarginLeft btn btn-outline-dark" v-on:click="cancelCategoryEdit()"> Cancelar </button>
                      </div>

                      <table class="table">
                          <thead>
                            <tr>
                              <th> Nome </th>
                              <th> Ação </th>
                            </tr>
                          </thead>
                          <tbody v-for="category in allCategories" v-bind:key="category.id">
                            <tr>
                              <td> {{category.name}} </td>
                              <td> <button type="button" class="btn btn-outline-danger" v-on:click="adminSelectCategory(category)"> Selecionar </button></td>
                            </tr>
                          </tbody>
                      </table>
                            
                    </form>

                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-outline-dark" data-bs-dismiss="modal"> Concluído </button>
          </div>
        </div>
      </div>
    </div>

    <!-- Fazer post -->
    <div class="aLotOfMarginTop container" style="width: 650px;" v-if="this.userLogged != null && ( this.userLogged.isEditor || this.userLogged.isAdmin)">
      <div v-html="errorMessage"></div>

      <form action="./">
        <div class="input-group mb-3">
          <span class="input-group-text" id="basic-addon1">📌</span>
          <input class="form-control" type="text" v-model="postToUpload.title" placeholder="Título" required>
        </div>

        <div class="input-group someMarginTop">
          <span class="input-group-text">📄</span>
          <textarea class="form-control" rows="10" v-model="postToUpload.content" placeholder="Conteúdo" style="resize: none;"></textarea>
        </div>

        <div class="left">
          <div>
            <select class="form-select someMarginTop" aria-label="Default select example" style="width: max-content;" v-model="postToUpload.categoryId">
              <option v-for="category in allCategories" :key="category.id" :value="category.id">{{category.name}}</option>
  
            </select>
          </div>
          
          <div class="someMarginTop right" style="width: 100%;">
              <button v-if="(this.isEditingPost == false)" class="btn btn-success" type="button" v-on:click="publicPost()"> Publicar </button>
              <button v-if="(this.isEditingPost == true)" class="btn btn-warning" type="button" v-on:click="editPost()"> Atualizar </button>
              <button v-if="(this.isEditingPost == true)" class="btn btn-outline-light someMarginLeft" type="button" v-on:click="cancelEditPost()"> Cancelar </button>
          </div>
        </div>

      </form>
    </div>
    
    <!-- Posts -->
    <div class="aLotOfMarginTop container">

      <form action="./HomePage.vue">
           <div class="input-group mb-3">
              <span class="input-group-text" id="basic-addon1">🔎</span>
              <input type="text" class="form-control" v-model="titleToFind" placeholder="Termo a pesquisar" aria-label="Comentário" aria-describedby="basic-addon1">
            </div>
      </form>

        <div class="accordion" id="accordionExample" v-for="post in allPosts" v-bind:key="post.id">
          <div class="accordion-item someMarginTop" v-if="(post.title.toUpperCase().includes(titleToFind.toUpperCase())) && (allCategories.find( c => c.id == post.categoryId).name.toUpperCase().includes(categoryToFind.toUpperCase()))">
            <h2 class="accordion-header" id="headingOne">
              <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" v-bind:data-bs-target="('#post' + post.id)" aria-expanded="true" v-bind:aria-controls="('post' + post.id)">
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
                  <p style="word-wrap: break-word;">{{post.content}}</p>

                  <p style="display: flex; justify-content: right;" v-if="userLogged != null && (post.userId == userLogged.id || userLogged.isAdmin == true)"> 
                    <button class="btn btn-danger" v-on:click="removePost(post.id)"> 🗑 Excluir post </button>
                    <button v-if="userLogged.isAdmin == true" class=" someMarginLeft btn btn-outline-secondary" v-on:click="getEditPost(post, post.id)"> ✒ Editar post </button>
                  </p>
                </div>

                <hr v-if="userLogged != null">

                <h5> Comentários </h5>
                <div v-if="userLogged != null">
                  <div class="input-group mb-3">
                    <span class="input-group-text" id="basic-addon1">💬</span>
                    <input type="text" class="form-control" v-model="commentToUpload.content" placeholder="Diga o que achou sobre o post =)" aria-label="Comentário" aria-describedby="basic-addon1">
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
      postToUpload: {
        title: '',
        content: ''
      },
      commentToUpload: {},
      titleToFind: '',
      categoryToFind: '',
      errorMessage: '',
      isEditingPost : false,
      editingPost : {},
      newEditor: {
        username: '',
        password: ''
      },
      selectedUserId: 0,
      editingUser: false,
      targetUser: {},
      newCategory: {
        name: ''
      },
      selectedCategoryId: 0,
      editingCategory: false,
      targetCategory: {}
    }
  },
  async beforeMount() {
    await this.getUserLogged();
    await this.loadallCategories();
    await this.loadPosts();
    await this.loadComments();
  },
  methods: {
    async adminSelectCategory(c) {
        this.targetCategory = c;
        console.log(this.targetCategory);
        this.newCategory.name = c.name;
        this.selectedCategoryId = c.id; 
        this.editingCategory = true;
    },
    async cancelCategoryEdit() {
        this.targetCategory = {};
        this.newEditor.name = '';
        this.selectedCategoryId = 0; 
        this.editingCategory = false;
    },
    async deleteSelectedCategory() {
      var hasPost = false;
        this.allPosts.forEach( p => {
          if (p.categoryId == this.selectedCategoryId) { console.error('Categoria ainda contém posts'); hasPost = true; return; }
        });

        if (hasPost) return;

        const request = new Request(`https://localhost:7251/api/Categories/${this.selectedCategoryId}`, {
          method: 'DELETE',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          }
        });
        await fetch(request);
        window.location.reload();
    },
    async updateSelectedCategory() {
      const regisCat = {
          id: this.targetCategory.id,
          name: this.newCategory.name
        };

        console.log(regisCat);

        const request = new Request(`https://localhost:7251/api/Categories/${this.targetCategory.id}`, {
          method: 'PUT',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          },
          body: JSON.stringify(regisCat, null, 2)
        });

        await fetch(request);

        window.location.reload();
    },
    async registerNewCategory() {
        var regisCat = {
          name: this.newCategory.name
        };

        console.log(regisCat);

        const request = new Request(`https://localhost:7251/api/Categories`, {
          method: 'post',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          },
          body: JSON.stringify(regisCat, null, 2)
        });

        await fetch(request);
        await fetch('https://localhost:7251/api/Categories').then(str => str.json()).then(strJson => {
          this.allCategories = strJson;
        });

    },
    async deleteSelectedUser() {
      var hasUser = false;
        this.allPosts.forEach( p => {
          if (p.userId == this.selectedUserId) { console.error('Usuário ainda contém posts'); hasUser = true; return; }
        });
        this.allComments.forEach( c => {
            if (c.userId == this.selectedUserId) { console.error('Usuário ainda contém comentários'); hasUser = true; return; }
        });

        if (hasUser) return;
       const request = new Request(`https://localhost:7251/api/Users/${this.selectedUserId}`, {
          method: 'DELETE',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          }
        });
        await fetch(request);
        window.location.reload();
    },
    async cancelUserEdit() {
        this.newEditor.username = '';
      this.newEditor.password = '';
      this.selectedUserId = 0;
      this.editingUser = false;
    },
    async updateSelectedUser() {
        const regisUser = {
          id: this.targetUser.id,
          username: this.newEditor.username,
          password: this.newEditor.password,
          isReader: this.targetUser.isReader,
          isEditor: this.targetUser.isEditor,
          isAdmin: false,
          createdAt: this.targetUser.createdAt
        };

        console.log(regisUser);

        const request = new Request(`https://localhost:7251/api/Users/${this.selectedUserId}`, {
          method: 'PUT',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          },
          body: JSON.stringify(regisUser, null, 2)
        });

        await fetch(request);

        window.location.reload();
    },
    async adminSelectUser(u) {
      this.targetUser = u;
      this.newEditor.username = u.username;
      this.newEditor.password = u.password;
      this.selectedUserId = u.id;
      this.editingUser = true;
    },
    async registerNewEditor() {
       if (this.allUsers.find( u => u.username == this.newEditor.username) != undefined) { 
          this.newEditor.username = '';
          this.newEditor.password = '';
          this.newEditor.confirmPassword = '';
          return; 
        }
        
        const regisUser = await {
          username: this.newEditor.username,
          password: this.newEditor.password,
          isReader: true,
          isEditor: true,
          isAdmin: false,
          createdAt: new Date().toLocaleDateString()
        }
  
        const request = await new Request('https://localhost:7251/api/Users', {
          method: 'post',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          },
          body: JSON.stringify(regisUser, null, 2)
        });
  
        await fetch(request);
        await fetch('https://localhost:7251/api/Users').then(str => str.json()).then(strJson => {
          this.allUsers = strJson;
        });
        
        this.newEditor.username = '';
        this.newEditor.password = '';
        this.newEditor.confirmPassword = '';
    },
    async cancelEditPost() {
      this.postToUpload.title = '';
      this.postToUpload.content = '';
      this.postToUpload.categoryId = '';
      this.editingPostId = {};
      this.isEditingPost = false;
    },
    async getEditPost(post) {
        this.postToUpload.title = await post.title;
        this.postToUpload.content = await post.content;
        this.postToUpload.categoryId = await post.categoryId;
        this.editingPost = post;
        this.isEditingPost = true;
    },
    async editPost() {
        if (this.postToUpload.title.trim() == '' || this.postToUpload.content.trim() == '') {
          this.showErrorMessage('Favor completar os campos da postagem');
          return;
        }
        if (this.postToUpload.categoryId == undefined) {
          this.showErrorMessage('Por favor, selecione uma categoria');
          return;
        }

        const toPost = {
            id: this.editingPost.id,
            Title: this.postToUpload.title,
            Content: this.postToUpload.content,
            CreationDate: new Date().toLocaleDateString(),
            userId: this.editingPost.userId,
            categoryId: this.postToUpload.categoryId
        }
        
        console.log(toPost);

        const request = new Request(`https://localhost:7251/api/Posts/${this.editingPost.id}`, {
          method: 'PUT',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          },
          body: JSON.stringify(toPost, null, 2)
        });
  
        await fetch(request);

        this.postToUpload.title = '';
        this.postToUpload.content = '';

        window.location.reload();
        this.editingPost = {};
        this.unShowErrorMessage();
    },
    async filterCategoy(c) {
      this.categoryToFind = c;
    },
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

        this.commentToUpload.content = '';
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

        if (this.postToUpload.title.trim() == '' || this.postToUpload.content.trim() == '') {
          this.showErrorMessage('Favor completar os campos da postagem', 'danger');
          return;
        }
        if (this.postToUpload.categoryId == undefined) {
          this.showErrorMessage('Por favor, selecione uma categoria', 'danger');
          return;
        }

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

        this.postToUpload.title = '';
        this.postToUpload.content = '';

        this.unShowErrorMessage();
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
    },
    async showErrorMessage(message, type = 'danger') {
      this.errorMessage =
        `
          <div class="alert alert-${type} alert-dismissible" role="alert">
            <div>${message}</div>
            <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
          </div>
        `;
    },
    async unShowErrorMessage() {
      this.errorMessage = '';
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Noto+Sans+JP:wght@100;300;400;500;700;900&display=swap');

* {
  font-family: 'Noto Sans JP', sans-serif;
  scroll-behavior: smooth;
}


.accordion-button, .accordion-item {
  text-align: left;
  justify-content: left;
}

nav {
  position: sticky;
  top: 0;
  z-index: 9000;
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

.someMarginBottom {
  margin-bottom: 10px;
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
