using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSAMemeAPI.Models
{
    public class MSAMemeAPIContext : DbContext
    {
        public MSAMemeAPIContext (DbContextOptions<MSAMemeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MSAMemeAPI.Models.MemeItem> MemeItem { get; set; }
    }
}
