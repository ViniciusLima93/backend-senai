using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_vet.interfaces;

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
          throw new NotImplementedException();
        }
    }

}