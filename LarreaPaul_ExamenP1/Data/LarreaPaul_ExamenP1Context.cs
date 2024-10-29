using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LarreaPaul_ExamenP1.Models;

namespace LarreaPaul_ExamenP1.Data
{
    public class LarreaPaul_ExamenP1Context : DbContext
    {
        public LarreaPaul_ExamenP1Context (DbContextOptions<LarreaPaul_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<LarreaPaul_ExamenP1.Models.PLarrea> PLarrea { get; set; } = default!;
        public DbSet<LarreaPaul_ExamenP1.Models.Celular> Celular { get; set; } = default!;
    }
}
