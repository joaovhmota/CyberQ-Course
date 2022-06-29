<template>
  <main class="bigMarginTop">
    <div class="center">
      <form action="./" v-if="this.isLogging" autocomplete="off">
          <img src="../assets/imgs/ah_negao_logo.png" alt="">
          <input type="text" name="" id="txtUsername" v-model="obj.username" class="form-control" placeholder="Usuário">
          <input type="password" name="" id="txtPassword" v-model="obj.password" class="form-control someMarginTop" placeholder="Senha">
          <div class="left">
            <button class="someMarginTop btn btn-outline-success" value="Entrar" v-on:click="executeLogin()"> Entrar </button>
            <input type="button" class="someMarginTop someMarginLeft btn btn-outline-dark" value="Registrar" v-on:click="loginRegisterMenu()">
            <input type="button" class="someMarginTop someMarginLeft btn btn-outline-dark" value="Cancelar" v-on:click="goToHome()">
           
            <div class="someMarginLeft someMarginTop right" style="width: 100%;">
              <div class="form-check">
                <input class="form-check-input" v-on:change="setRememberMe()" type="checkbox" value="" id="">
                <label class="form-check-label" for="flexCheckChecked">
                  Lembrar deste aparelho
                </label>
              </div>

              <div class="someMarginLeft form-check">
                <input class="form-check-input" v-on:change="showHidePassword()" type="checkbox" value="" id="flexCheckChecked">
                <label class="form-check-label" for="flexCheckChecked">
                  Mostrar senha
                </label>
              </div>

            </div>
          </div>
      </form>

      <form v-if="!this.isLogging" autocomplete="off">
          <img src="../assets/imgs/ah_negao_logo.png" alt="">
          <input type="text" name="" id="txtUsername" v-model="obj.username" class="form-control" placeholder="Usuário">
          <input type="password" name="" id="txtPassword" v-model="obj.password" class="form-control someMarginTop" placeholder="Senha">
          <input type="password" name="" id="txtConfirmPassword" class="form-control someMarginTop" placeholder="Confirmar senha">
          <div class="left">
            <input type="button" class="someMarginTop btn btn-outline-success" v-on:click="registerUser()" value="Criar">
            <input type="button" class="someMarginTop someMarginLeft btn btn-outline-dark" value="Cancelar" v-on:click="loginRegisterMenu()">
          </div>
      </form>


    </div>
  </main>
</template>

<script>


export default {
  name: 'LoginPage',
  data() {
    return {
        isLogging: true,
        currentLogged: {},
        obj: {},
        users: [],
        remeberMe: false
    }
  },
  beforeMount() {
     if (JSON.parse(sessionStorage.getItem('userLogged')) != null) window.open('./', '_self');
    this.getUsers();
  },
  methods: {
    async getUsers() {
      const request = await fetch('https://localhost:7251/api/Users');
      const returnJson = await request.json();
      console.table(returnJson);
      this.users = returnJson;
    },
    showHidePassword() {
      try {
        if ( document.getElementById('txtPassword').getAttribute('type') == 'password') {
          document.getElementById('txtPassword').setAttribute('type', 'text');
          this.showPassword = true;
        } else {
           document.getElementById('txtPassword').setAttribute('type', 'password');
         this. showPassword = false;
        }
      } catch (e) { console.error(e); }
    },
    loginRegisterMenu() {
      try {
        this.isLogging = !this.isLogging;
        
        document.getElementById('txtUsername').value = '';
        document.getElementById('txtPassword').value = '';

      } catch (e) { console.error(e); }
    },
    executeLogin() {
      this.users.forEach( user => {
          if (this.obj.username == user.username)
            if (this.obj.password == user.password) {
                console.log("👍");
                if (this.rememberMe) {
                  window.localStorage.setItem('userLogged', JSON.stringify(user));
                  window.sessionStorage.removeItem('userLogged');
                } else {
                  window.localStorage.removeItem('userLogged');
                  window.sessionStorage.setItem('userLogged', JSON.stringify(user));
                }
            }
      });
    },
    async registerUser() {
      try {
        const txtPassword = document.getElementById('txtPassword').value;
        const txtConfirmPassword = document.getElementById('txtConfirmPassword').value;

        if (!(txtPassword === txtConfirmPassword)) return;
  
        const regisUser = {
          username: this.obj.username,
          password: this.obj.password,
          isReader: true,
          isEditor: false,
          isAdmin: false,
          createdAt: new Date().toLocaleDateString()
        }
  
        const request = new Request('https://localhost:7251/api/Users', {
          method: 'post',
          headers: {
            'Accept': 'application/json',
            'Content-type': 'application/json'
          },
          body: JSON.stringify(regisUser, null, 2)
        });
  
        const execRequest = await fetch(request);
        const returnRequest = await execRequest.json();
        this.users.push(returnRequest);

        document.getElementById('txtUsername').value =  '';
        document.getElementById('txtPassword').value =  '';
        document.getElementById('txtConfirmPassword').value =  '';
        
        this.loginRegisterMenu();
      } catch(e) { console.error(e); }
    },
    setRememberMe() {
      this.rememberMe = !this.rememberMe;
    },
    goToHome() {
      window.open('./', '_self');
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

main {
  display: flex;
  justify-content: center;
  align-items: center;
}

form {
  width: 700px;
}

.bigMarginTop {
  margin-top: 30vh;
}

.someMarginTop {
  margin-top: 10px;
}

.someMarginLeft {
  margin-left: 10px;
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
