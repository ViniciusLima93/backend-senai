// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using backend_vet.Classes;

PessoaFisica novaPF = new PessoaFisica();


novaPF.nome = "Vinicius";
novaPF.cpf = "123456";

Console.WriteLine(novaPF.nome);
Console.WriteLine(novaPF.cpf);