using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migrating_LocalDbToAws.Dao
{
    public class OeaContext : DbContext
    {
        
        public DbSet<Image> tb_imagens { get; set; }
        //AWS
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySQL("server=localhost;user id=sa;password=SenhaSql2019;port=3906;database=db_checklistoea;persistsecurityinfo=True");
    }
}
