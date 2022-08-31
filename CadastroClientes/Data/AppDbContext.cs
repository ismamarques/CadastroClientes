using CadastroClientes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Data
{
    public class AppDbContext : DbContext // essa herança mostra ao banco "PAI" o que iremos trabalhar no banco de dados...
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

    // iremos trabalhar com as propriedades abaixo no banco de dados 
    public DbSet<Cliente> Clientes { get; set; }
    }
} //apos criar esse contexto de heraça temos que executar o add-migration inicial , irá dar erro pedidndo appdbontext
  // temos que ir até o Startup e colocar o -> services.AddDbContext<AppDbContext>(OptionsBuilderConfigurationExtensions => OptionsBuilderConfigurationExtensions.UseSqlServer(Configuration.GetConnectionString("MeuDB"));
  // ... para implementar um contexto 
