using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_vet.interfaces
{
    public interface IPessoaFisica
    {
         bool ValidarDataNasc(DateTime dataNasc);

        bool ValidarDataNasc(string dataNasc);
       
    }
}