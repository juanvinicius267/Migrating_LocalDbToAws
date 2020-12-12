using System;
using System.Collections.Generic;
using System.Text;

namespace Migrating_LocalDbToAws
{
    public class Image
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public byte[] Dados { get; set; }
        public string ContentType { get; set; }
    }
}
