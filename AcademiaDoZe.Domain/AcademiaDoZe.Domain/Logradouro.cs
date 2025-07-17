using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoZe.Domain
{
    public class Logradouro
    {
        int Cep {  get; set; }
        string Pais { get; set; }
        string Estado {  get; set; }
        string Cidade {  get; set; }
        string Bairro { get; set; }
        String NomeLogradouro {  get; set; }

        public Logradouro( int cep, string pais, string estado, string cidade, string bairro, string nomelogradouro)
        {
            Cep = cep;
            Pais = pais;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            NomeLogradouro = nomelogradouro;
        }
    }
}
