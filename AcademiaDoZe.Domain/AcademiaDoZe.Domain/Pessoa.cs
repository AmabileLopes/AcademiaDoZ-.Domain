using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoZe.Domain
{
    public class Pessoa : Logradouro

    {
        string NomeCompleto { get; set; }
        String Cpf { get; set; }
        DateTime DataNascimento { get; set; }
        int Telefone { get; set; }
        int NumeroCasa { get; set; }
        String Complemento {  get; set; }

        public Pessoa( string nomecompleto, string cpf, DateTime datanascimento, int telefone, int numerocasa, string complemento, int cep, string pais, string estado, string cidade, string bairro, string nomelogradouro) : base(cep, pais, estado, cidade, bairro, nomelogradouro)
        {
            NomeCompleto = nomecompleto;
            Cpf = cpf;
            DataNascimento = datanascimento;
            Telefone = telefone;
            NumeroCasa = numerocasa;
            Complemento = complemento;
        }

    }
}
