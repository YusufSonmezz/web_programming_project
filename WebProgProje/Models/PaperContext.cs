using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebProgProje.Models
{
    public class PaperContext : DbContext 
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public PaperContext(DbContextOptions<PaperContext> options) : base(options)
        {

        }
    }
}
