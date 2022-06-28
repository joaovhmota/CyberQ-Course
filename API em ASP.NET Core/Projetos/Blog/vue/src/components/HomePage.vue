<template>
	<main>
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
              <a class="nav-link active someMarginRight" aria-current="page">{{this.userLogged.username}}</a>
              <button type="submit" v-on:click="logOff()" class="someMarginLeft btn btn-outline-danger"> Sair da conta </button>
          </form>
          <form v-if="this.userLogged == null" class="center d-flex" action="#/login">
              <button type="submit" class="someMarginLeft btn btn-outline-success"> Login </button>
          </form>
        </div>
      </div>
    </nav>
	</main>
</template>

<script>
export default {
  name: 'HomePage',
  data() {
    return {
      userLogged : null,
      categories: []
    }
  },
  beforeMount() {
    this.getUserLogged();
    this.loadCategories();
  },
  methods: {
    getUserLogged() {
      var userLogged = JSON.parse(sessionStorage.getItem('userLogged'));
      if (userLogged == null) userLogged = JSON.parse(localStorage.getItem('userLogged'));
      this.userLogged = userLogged;
    },
    logOff() {
      sessionStorage.removeItem('userLogged');
      this.userLogged = null;
    },
    async loadCategories() {
      var request = await fetch('https://localhost:7251/api/Categories');
      var requestReturn = await request.json();
      this.categories = await requestReturn;
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

.someMarginTop {
  margin-top: 10px;
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
