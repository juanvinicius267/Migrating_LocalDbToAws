using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migrating_LocalDbToAws.Dao
{
    class OeaContextLocal : DbContext
    {
        public DbSet<Image> tb_imagens { get; set; }
        //Local
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySQL("server=10.251.16.112;userid=root;password=SenhaSql2019;persistsecurityinfo=True;port=3308;database=db_checklistoea;");
    }
}
