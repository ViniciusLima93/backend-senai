using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_vet.Classes
{
    public abstract class Client
    {
          public string? nome {get;set;}

        public float? rendimento {get; set;}

        public string? endereco {get;set;}

        public abstract float CalcularImposto (float rendimento);
    }
}