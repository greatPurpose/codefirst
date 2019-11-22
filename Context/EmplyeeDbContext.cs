using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFristEF.Context
{
    public class EmplyeeDbContext : DbContext
    {
        public EmplyeeDbContext(DbContextOptions option) :  base(option)
        {

        }

        DbSet<Employee> Employees { get; set; }
    }
}
