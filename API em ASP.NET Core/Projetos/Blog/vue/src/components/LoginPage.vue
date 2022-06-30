<template>
  <main class="bigMarginTop" style="background-color: #561759;">
    <div class="center">
      <div v-if="this.isLogging" autocomplete="off">
          <img src="../assets/imgs/ah_negao_logo.png" alt="">
          <div v-html="errorMessage"></div>

          <div class="input-group mb-3">
            <span class="input-group-text" id="basic-addon1">👤</span>
            <input type="text" name="" id="txtUsername" v-model="obj.username" class="form-control" placeholder="Usuário" autocomplete="off">
          </div>

          <div class="input-group mb-3 someMarginTop">
            <span class="input-group-text" id="basic-addon1">🔒</span>
             <input type="text" name="" id="txtPassword" v-model="obj.password" class="form-control" placeholder="Senha" autocomplete="off">
          </div>

          <div class="left">
            <button class="someMarginTop btn btn-success" value="Entrar" v-on:click="executeLogin()"> Entrar </button>
            <input type="button" class="someMarginTop someMarginLeft btn btn-outline-light" value="Registrar" v-on:click="loginRegisterMenu()">
            <input type="button" class="someMarginTop someMarginLeft btn btn-outline-light" value="Cancelar" v-on:click="goToHome()">
           
            <div class="someMarginLeft someMarginTop right" style="width: 100%;">
              <div class="form-check">
                <input class="form-check-input" v-on:change="setRememberMe()" type="checkbox" value="" id="">
                <label class="form-check-label" for="flexCheckChecked" style="color: #fff;">
                  Lembrar deste aparelho
                </label>
              </div>

              <div class="someMarginLeft form-check">
                <input class="form-check-input" v-on:change="showHidePassword()" type="checkbox" value="" id="flexCheckChecked">
                <label class="form-check-label" for="flexCheckChecked" style="color: #fff;">
                  Mostrar senha
                </label>
              </div>

            </div>
          </div>
      </div>

      <div v-if="!this.isLogging" autocomplete="off">
          <img src="../assets/imgs/ah_negao_logo.png" alt="">
          <div class="input-group mb-3">
             <span class="input-group-text" id="basic-addon1">👤</span>
             <input type="text" name="" id="txtUsername" v-model="obj.username" class="form-control" placeholder="Usuário">
          </div>

          <div class="input-group mb-3 someMarginTop">
            
            <span class="input-group-text" id="basic-addon1">🔒</span>
            <input type="password" name="" id="txtPassword" v-model="obj.password" class="form-control" placeholder="Senha">
          </div>

          <div class="input-group mb-3 someMarginTop">
            <span class="input-group-text" id="basic-addon1">🔒</span>
            <input type="password" name="" id="txtConfirmPassword" v-model="obj.confirmPassword" class="form-control" placeholder="Confirmar senha">
          </div>
          <div class="left someMarginTop someMarginTop">
            <input type="button" class="btn btn-outline-success" v-on:click="registerUser()" value="Criar">
            <input type="button" class="someMarginLeft btn btn-outline-dark" value="Cancelar" v-on:click="loginRegisterMenu()">
          </div>
      </div>
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
        remeberMe: false,
        errorMessage: ''
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
          {
            if (this.obj.password == user.password) {
                console.log("👍");
                if (this.rememberMe) {
                  window.localStorage.setItem('userLogged', JSON.stringify(user));
                  window.sessionStorage.removeItem('userLogged');
                  this.goToHome();
                } else {
                  window.localStorage.removeItem('userLogged');
                  window.sessionStorage.setItem('userLogged', JSON.stringify(user));
                  this.goToHome();
                }
            }
            else {
               this.showErrorMessage('Usuário ou senhas estão incorretas', 'danger');
            }
          }
          else {
            this.showErrorMessage('Usuário ou senhas estão incorretas', 'danger');
          }
      });
    },
    async registerUser() {
      try {

        if (this.users.filter( u => u.username == this.obj.username)) { 
          this.showErrorMessage('Usuário já existe', 'danger');
          return; 
        } 
        else if (!(this.obj.password ===  this.obj.confirmPassword)) { 
          this.showErrorMessage('Senhas não conhecidem', 'danger'); 
          return; 
        }
        else {
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
          
          this.obj.username = '';
          this.obj.password = '';
          this.obj.confirmPassword = '';
  
          this.loginRegisterMenu();
        }
      } catch(e) { console.error(e); }
    },
    setRememberMe() {
      this.rememberMe = !this.rememberMe;
    },
    goToHome() {
      this.$router.push('/');
    },
    async showErrorMessage(message, type) {
       this.errorMessage =
        `
          <div class="alert alert-${type} alert-dismissible" role="alert">
            <div>${message}</div>
            <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
          </div>
        `;
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
