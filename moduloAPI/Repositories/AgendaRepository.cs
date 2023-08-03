using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moduloAPI.Models;

namespace moduloAPI.Repositories
{
    public class AgendaRepository : DbContext
    {
        public AgendaRepository(DbContextOptions<AgendaRepository> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}