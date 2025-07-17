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
        String Rua {  get; set; }

        public Logradouro( int cep, string pais, string estado, string cidade, string bairro, string rua)
        {
            Cep = cep;
            Pais = pais;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
        }
    }
}
