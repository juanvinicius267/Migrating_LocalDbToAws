using Migrating_LocalDbToAws.Dao;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Migrating_LocalDbToAws
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            using (var db = new OeaContextLocal())
            {
                List<Image> blog = db.tb_imagens.ToList();
                for (int i = 0; i < blog.Count; i++)
                {
                    using (var db2 = new OeaContext())
                    {
                        db2.tb_imagens.Update(blog[i]);
                        db2.SaveChanges();
                    }
                    
                }
            }

        }
    }
}
