using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using backend_vet.interfaces;


// - Pessoa jurídica
// Para Rendimentos até 3000, 3%
// Para rendimentos entre 3000 e 6000, 5%
// Para rendimentos entre 6000 e 10000, 7%
// Para rendimentos acima de 10000, 9%

namespace backend_vet.Classes
{
    public class PessoaJuridica: Client, IPessoaJuridica
    {
        public string? cnpj {get;set;}

        public string? razaoSocial { get;set;}

        public override float CalcularImposto(float rendimento)
        {
          
          if (rendimento <=3000)
            {  
              float resultado;
              return resultado = ((float)(rendimento * 0.03f));
            }else if (rendimento >= 3000 && rendimento <=6000) 
            { 
              float resultado;
              return resultado = ((float)(rendimento * 0.05f));
            }else if (rendimento >= 6000 && rendimento <=10000) 
            { 
              float resultado;
              return resultado = ((float)(rendimento * 0.07f));
            }else {
              float resultado;
              return resultado = ((float)(rendimento * 0.09f));
            }
            
             
        }



        //XX.XXX.XXX/0001-XX  ---  XXXXXXXX0001XX
        public  bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                    
                } else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }
            }

            return false;
   
        }

        bool IPessoaJuridica.ValidateCNPJ(string cnpj)
        {
            throw new NotImplementedException();
        }

       


    }

}