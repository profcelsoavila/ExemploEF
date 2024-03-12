using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploEF.Models
{
    public class Context : DbContext
    {
        /*o método contrutor usa o objeto options da superclasse
         para buscar as configurações de conexão com o BD */
        public Context(DbContextOptions<Context> options) 
            : base (options)
        {
        }
    /*Para que os modelos sejam mapeados como tabelas no BD,
     declare-os como DbSet*/
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }

    }
}
    

