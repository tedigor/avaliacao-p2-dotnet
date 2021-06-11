using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ApiDeGastosMensais.DATA.Model;

namespace ApiDeGastosMensais.DATA
{
    public class DataContext: DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
        public DbSet<Gasto> Gasto { get; set; }
    }

}
