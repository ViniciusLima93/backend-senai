using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_vet.interfaces;


// - Pessoa jurídica
// Para Rendimentos até 3000, 3%
// Para rendimentos entre 3000 e 6000, 5%
// Para rendimentos entre 6000 e 10000, 7%
// Para rendimentos acima de 10000, 9%

namespace backend_vet.Classes
{
    public class PessoaJuridica: Client, interfaces.IPessoaJuridica
    {
        public string? cnpj {get;set;}

        public string? razaoSocial { get;set;}

        public override float CalcularImposto(float rendimento)
        {

            if (rendimento <=3000)
          { 
            float resultado;
            resultado = ((float)(rendimento * 0.03f));
          }else if (rendimento >= 3000 && rendimento <=6000) 
          {
            float resultado;
            resultado = ((float)(rendimento * 0.05f));
          }else if (rendimento >= 6000 && rendimento <=10000) 
          {
            float resultado;
            resultado = ((float)(rendimento * 0.07f));
          }else {
            float resultado;
            resultado = ((float)(rendimento * 0.09f));
          }




            throw new NotImplementedException();
        }

        bool IPessoaJuridica.ValidateCNPJ(string cnpj)
        {
            throw new NotImplementedException();
        }
    }

}