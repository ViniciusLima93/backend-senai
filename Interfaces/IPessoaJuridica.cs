using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_vet.interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidateCNPJ (string cnpj);
        float CalcularImposto(float rendimento);
    }
}