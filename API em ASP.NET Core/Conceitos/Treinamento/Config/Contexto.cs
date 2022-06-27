using Treinamentos.Models;
using Microsoft.EntityFrameworkCore;

namespace Treinamentos.Config {
     public class Contexto : DbContext {

          // Construtor
          public Contexto(DbContextOptions<Contexto> options) : base(options) {
               Database.EnsureCreated();
          }

          // Especificar quais modelos serão usados para gerar tabelas
          public DbSet<Treinamento> Treinamento { get; set; }
     }
}
