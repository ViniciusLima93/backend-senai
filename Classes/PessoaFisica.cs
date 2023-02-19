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
     public class PessoaFisica : Client , IPessoaFisica
    {
        public string? cpf { get; set; }
        
        public DateTime dataNasc { get; set; }

        public override float CalcularImposto(float redimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            Console.WriteLine($"{anos}");
            
            if (anos >= 18)
            {
                return true;
            }
            
            return false;        
        }

        
        public bool ValidarDataNasc(string dataNasc){

            DateTime dataConvertida;  

            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                
                Console.WriteLine($"{anos}");

                if (anos >= 18 && anos < 120)
                {
                    return true;
                }
                
                return false;
            }

            return false;          
        }

        bool IPessoaFisica.ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        bool IPessoaFisica.ValidarDataNasc(string dataNasc)
        {
            throw new NotImplementedException();
        }

     
    }

}