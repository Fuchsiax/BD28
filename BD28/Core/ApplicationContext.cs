using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using BD28.MVVM.Model;

namespace BD28.Core
{
    internal class ApplicationContext:DbContext
    {
        //public DbSet<Arhive> Arhives { get; set; }
        //public DbSet<Client> Clients { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Filial> Filials { get; set; }
        //public DbSet<Haircut> Haircuts { get; set; }
        //public DbSet<Position> Positions { get; set; }
        //public DbSet<Prices> Prices { get; set; }
        //public DbSet<Work> Works { get; set; }
    }
}
