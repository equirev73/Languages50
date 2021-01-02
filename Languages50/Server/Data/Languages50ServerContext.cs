using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Languages50.Shared;

namespace Languages50.Server.Data
{
    public class Languages50ServerContext : DbContext
    {
        public Languages50ServerContext (DbContextOptions<Languages50ServerContext> options)
            : base(options)
        {
        }

        public DbSet<Languages50.Shared.ProgrammingLanguage> ProgrammingLanguage { get; set; }
    }
}
