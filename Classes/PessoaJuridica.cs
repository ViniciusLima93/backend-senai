using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_vet.Classes
{
    public class PessoaJuridica: Client, IPessoaJuridica
    {
        public string? cnpj {get;set;}

        public string? razaoSocial { get;set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IPessoaJuridica
    {
    }
}