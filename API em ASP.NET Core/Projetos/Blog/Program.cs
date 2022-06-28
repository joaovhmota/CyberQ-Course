using Blog.Config;
using Microsoft.EntityFrameworkCore;

const string connectionString = "DATA SOURCE = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP) (HOST = 192.168.15.18) (PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = treinamento))); User Id = aluno14; Password = aluno14"; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var ConfigCors = "";

builder.Services.AddCors(options => {
     options.AddPolicy(name: ConfigCors, policy => { policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod(); });
});

builder.Services.AddDbContext<ApplicationContext>(options => options.UseOracle(connectionString));

builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/connection", (ApplicationContext obj) => {
     return obj;
});

app.UseCors(ConfigCors);

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
