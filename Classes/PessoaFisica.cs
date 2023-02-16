using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_vet.interfaces;


// - Pessoa física
// Para rendimentos até 1500, isento
// Para rendimentos entre 1500 e 3500, 2%
// Para rendimentos entre 3500 e 6000, 3,5%
// para rendimentos acima de 6000, 5%



namespace backend_vet.Classes
{
    public abstract class PessoaFisica : Client,IPessoaFisica

    {
      public string? cpf {get;set;}

      public DateTime dataNasc {get;set;}

        bool IPessoaFisica.ValidateDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        float IPessoaFisica.CalcularImposto(float rendimento)
        {

          if (rendimento <=1500)
          { 
            return 0;
          }else if (rendimento >= 1500 && rendimento <=3500) 
          {
            float resultado;
            resultado = ((float)(rendimento * 0.02));
          }else if (rendimento >= 3500 && rendimento <=6000) 
          {
            float resultado;
            resultado = ((float)(rendimento * 0.035));
          }else {
            float resultado;
            resultado = ((float)(rendimento * 0.05));
          }


          throw new NotImplementedException();
        }

        internal float CalcularImposto(float? rendimento)
        {
            throw new NotImplementedException();
        }
    }

}