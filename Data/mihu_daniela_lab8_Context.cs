using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mihu_daniela_lab8_.Models;

namespace mihu_daniela_lab8_.Data
{
    public class mihu_daniela_lab8_Context : DbContext
    {
        public mihu_daniela_lab8_Context (DbContextOptions<mihu_daniela_lab8_Context> options)
            : base(options)
        {
        }

        public DbSet<mihu_daniela_lab8_.Models.Book> Book { get; set; }

        public DbSet<mihu_daniela_lab8_.Models.Publisher> Publisher { get; set; }

        public DbSet<mihu_daniela_lab8_.Models.Category> Category { get; set; }
    }
}
