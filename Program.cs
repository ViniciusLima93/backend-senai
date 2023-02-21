// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using backend_vet.Classes;
using System.IO;

// PessoaFisica novaPF = new PessoaFisica();


// novaPF.nome = "Vinicius";
// novaPF.cpf = "123456";
// novaPF.rendimento = 7000.5f;


// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);


// float res = novaPF.CalcularImposto((float)novaPF.rendimento); 
// Console.WriteLine(res);

// PessoaJuridica novaPJ = new PessoaJuridica();

// float impostoPagar = novaPJ.CalcularImposto(120000.5f);
// Console.WriteLine($"R$ {impostoPagar:0.00}");
// Console.WriteLine($"R$ {impostoPagar.ToString("C")}");

// PessoaJuridica novaPJ = new PessoaJuridica();

// bool res = novaPJ.ValidarCnpj((string)"12.345.678/0001-90");
// Console.WriteLine($"is a {res} as validate CNPJ");

// //Calcular imposto 


//  float imposPagar = novaPJ.CalcularImposto(12000.5f);
//  Console.WriteLine(imposPagar);
string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string filename = Path.Combine(path, "arquivo.txt");
Console.Clear();
Console.WriteLine(@$"
=============================================
|   Bem vindo ao sistema de cadastro de     |
|       Pessoas Físicas e Juridícas         |
=============================================
");

BarraCarregamento("Carregando", 500);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|       Escolha uma das opções abaixo       |
|-------------------------------------------|
|           1 - Pessoa Física               |
|           2 - Pessoa Juridíca             |
|                                           |
|           0 - Sair                        |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodoPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.nome = "Vinicius";
            novaPf.dataNasc = new DateTime(1993, 02, 25);
            novaPf.cpf = "1234567890";
            novaPf.rendimento = 5000.5f;

            novoEnd.logradouro = "Ruas das Araras";
            novoEnd.numero = 539;
            novoEnd.complemento = "Manaus";
            novoEnd.endComercial = true;

            //novaPf.endereco = novoEnd;

          using (StreamWriter writer = new StreamWriter("arquivoPF.txt"))

    {
        writer.WriteLine(@$"Nome: {novaPf.nome}");
        writer.WriteLine(@$"CPF: {novaPf.cpf}");
        writer.WriteLine(@$"Endereço: {novoEnd.logradouro}, {novoEnd.numero}");
    }
             

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.nome}
CPF: {novaPf.cpf}
Endereço: {novoEnd.logradouro}, {novoEnd.numero}
            ");

            Console.WriteLine($"{metodoPf.ValidarDataNasc(novaPf.dataNasc)}");

            //Console.WriteLine($"{metodoPf.ValidarDataNasc("01/0100")}");

            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();


            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco endPj = new Endereco();

            novaPj.nome = "Empresa de Tecnologia do Vinicius";
            novaPj.razaoSocial = "Razão social Pj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.rendimento = 10000.5f;

            endPj.logradouro = "Rua da felicidade";
            endPj.numero = 5;
            endPj.complemento = "Vale do Silicio";
            endPj.endComercial = true;

            //novaPj.endereco = endPj;

        using (StreamWriter writer = new StreamWriter("arquivoPJ.txt"))

    {
        writer.WriteLine(@$"Nome: {novaPj.nome}");
        writer.WriteLine(@$"Razão Social: {novaPj.razaoSocial}");
        writer.WriteLine(@$"CNPJ: {novaPj.cnpj}");
        writer.WriteLine(@$"CNPJ válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");

    }        

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
");

            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");

            BarraCarregamento("Finalizando", 300);

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção!");
            Thread.Sleep(3000);
            break;
    }


} while (opcao != "0");



static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.ForegroundColor = ConsoleColor.DarkRed;

    Console.Write(texto);

    for (var i = 0; i < 6; i++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();
}