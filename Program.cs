// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using backend_vet.Classes;

PessoaFisica novaPF = new PessoaFisica();


novaPF.nome = "Vinicius";
novaPF.cpf = "123456";
novaPF.rendimento = 7000.5f;

// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);


float res = novaPF.CalcularImposto(novaPF.rendimento); 
Console.WriteLine(res);

PessoaJuridica novaPJ = new PessoaJuridica();

float impostoPagar = novaPJ.CalcularImposto(120000.5f);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"R$ {impostoPagar.ToString("C")}");


