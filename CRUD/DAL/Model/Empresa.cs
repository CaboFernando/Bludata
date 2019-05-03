using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Empresa
    {
        public int id { get; set; }
        public string uf { get; set; }
        public string nomeFantasia { get; set; }
        public string cnpj { get; set; }
        public bool removido { get; set; }
    }
}
