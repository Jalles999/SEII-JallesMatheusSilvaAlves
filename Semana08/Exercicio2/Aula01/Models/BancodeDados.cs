using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud7.Models
{
    public class BancoDeDados : DbContext
    {
        public obset<Cliente> Clientes { get; set; }
        protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"server (localdb)\mssqllocaldb;Database=Crud7; Integrated Security=True");
        }
    }
}