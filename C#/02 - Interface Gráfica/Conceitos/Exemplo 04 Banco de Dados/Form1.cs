namespace Exemplo_04_Banco_de_Dados {
     public partial class Form1 : Form {
          public Form1() {
               InitializeComponent();
          }

          public void UpdateGrid() {
               Database db = new Database();
               db.ListarPessoas();

               dgvPessoas.Rows.Clear();

               dgvPessoas.ColumnCount = 2;

               dgvPessoas.Columns[0].Name = "Nome";
               dgvPessoas.Columns[1].Name = "Idade";

               foreach(Person p in db.PessoasCadastradas) {
                    dgvPessoas.Rows.Add(new object[] {p.Nome, p.Idade});
               }
          }


          private void btnAddPessoa_Click(object sender, EventArgs e) {
               Database db = new Database();
               db.CadastrarPessoa(txtNomePessoa.Text, (int) numIdadePessoa.Value);

               UpdateGrid();
          }

          private void Form1_Load(object sender, EventArgs e) {
              
          }
     }
}