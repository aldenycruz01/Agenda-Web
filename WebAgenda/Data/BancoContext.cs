using Microsoft.EntityFrameworkCore;
using WebAgenda.Models;

namespace WebAgenda.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext>options) : base(options)  
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }
            
    }
}
