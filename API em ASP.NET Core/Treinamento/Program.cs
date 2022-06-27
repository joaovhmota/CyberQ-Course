using Treinamentos.Config;
using Microsoft.EntityFrameworkCore;

string stringConnection = "DATA SOURCE = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP) (HOST = 192.168.15.18) (PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = TREINAMENTO))); User Id = aluno14; Password = aluno14;";

// Objeto que tem a classe da aplica��o
var builder = WebApplication.CreateBuilder(args);

// Gera o suporte para o uso de APIs
builder.Services.AddEndpointsApiExplorer();

// Libera o acesso para o banco de dados
builder.Services.AddDbContext<Contexto>(options => options.UseOracle(stringConnection));

// Servio�o que libera o uso de Controllers
builder.Services.AddControllers();
     
// Adicionar o servico Swagger na API
builder.Services.AddSwaggerGen();

// Vari�vel para receber a configura��o de Cors
var ConfigurarCors = "";

// Configurar nosso acesso � API
builder.Services.AddCors( options => {
     options.AddPolicy(name: ConfigurarCors,
          policy => {
               policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
          });
});

// Cria o objeto para termos acesso � API
var app = builder.Build();

// Rota contendo "Hello, World!"
app.MapGet("/", () => "Hello World!");

// Rota para testar a conex�o com o banco de dados
app.MapGet("/conexao", (Contexto obj) => {
     return obj.Treinamento.ToList();
});

// Habilita o uso de CORs
app.UseCors(ConfigurarCors);

// Mapeia o app para buscar os controllers
app.MapControllers();

// Implementa o Swagger na App e gera o HTML/CSS
app.UseSwagger();
app.UseSwaggerUI();

// Executar a aplica��o
app.Run();
