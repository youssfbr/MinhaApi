using System;
using System.Collections.Generic;
using System.Text;

namespace AlissonDev.MinhaApi.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public decimal Mensalidade { get; set; }
    }
}
