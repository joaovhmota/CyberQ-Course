<template>
  <div class="home">
      <form action="">
        <input type="text" v-model = "obj.nome" placeholder="Nome do Curso" class="form-control someMargin">
        <input type="number" v-model = "obj.valor" placeholder="Valor do Curso" min="0" class="form-control someMargin">
        <input type="button" v-on:click = "cadastrar()" value="Cadastrar" v-if="treinamentoSelecionado == false" class="btn btn-outline-primary someMargin">
        <input type="button" value="Alterar" v-on:click = "alterar()" v-if="treinamentoSelecionado == true" class="btn btn-outline-warning someMargin">
        <input type="button" value="Remover" v-on:click = "remover()" v-if="treinamentoSelecionado == true" class="btn btn-outline-danger someMargin">
        <input type="button" value="Cancelar" v-on:click = "cancelar()" v-if="treinamentoSelecionado == true" class="btn btn-outline-dark someMargin">
      </form>

      <table class="table table-striped">
          <thead>
              <tr>
                <th>#</th>
                <th>Treinamento</th>
                <th>Valor</th>
                <th>Selecionar</th>
              </tr>
          </thead>
          <tbody v-for="(treinamento, indice) in treinamentos" v-bind:key="treinamento.id">
              <tr>
                <td>{{indice + 1}}</td>
                <td>{{treinamento.nome}}</td>
                <td>{{treinamento.valor}}</td>
                <td><button class="btn btn-outline-success" v-on:click="selecionar(indice)"> Selecionar </button></td>
              </tr>
          </tbody>
      </table>
  </div>
</template>

<script>
export default {
  name: 'HomePage',
  data() {
      return {
        treinamentos: {},
        obj: {},
        treinamentoSelecionado: false
      }
  },
  beforeMount() {
    this.listar();
  },
  methods: {
    async listar() {
      const requisicao = await fetch('https://localhost:7035/api/Treinamento');
      const retorno = await requisicao.json();
      this.treinamentos = retorno;
    },
    async cadastrar() {
     const requisicao = new Request('https://localhost:7035/api/Treinamento', {
        method: "post",
        headers: {
          "Accept": "application/json",
          "Content-type": "application/json"
        },
        body: JSON.stringify(this.obj, null, 2)
      });
      const executarRequisicao = await fetch(requisicao);
      const retorno = await executarRequisicao.json();
      this.treinamentos.push(retorno);

    },
    selecionar(indice) {
        this.treinamentoSelecionado = true;
        this.obj = this.treinamentos[indice];
    },
    cancelar() {
      this.treinamentoSelecionado = false;
      this.obj = {};
    },
    async alterar() {
        const requisicao = new Request(`https://localhost:7035/api/Treinamento/${this.obj.id}`, {
          method: "PUT",
          headers: {
            "Accept": "application/json",
            "Content-type": "application/json"
          },
          body: JSON.stringify(this.obj, null, 2)
        });

        await fetch(requisicao);

        await this.listar();

        this.cancelar();

    },
    async remover() {
         const requisicao = new Request(`https://localhost:7035/api/Treinamento/${this.obj.id}`, {
          method: "DELETE",
          headers: {
            "Accept": "application/json",
            "Content-type": "application/json"
          }
        });

        await fetch(requisicao);

        await this.listar();

        this.cancelar();
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
form {
  margin: auto;
  width: 500px;
}

.someMargin {
  margin-top: 25px;
}

input[type="button"] {
  margin-right: 10px;
}

</style>
