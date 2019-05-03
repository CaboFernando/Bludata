using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Fornecedor
    {
        public int id { get; set; }
        public int idEmpresa { get; set; }
        public string nome { get; set; }
        public bool isPF { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public DateTime dataNascimento { get; set; }
        public DateTime dataCadastro { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public bool removido { get; set; }
    }
}
