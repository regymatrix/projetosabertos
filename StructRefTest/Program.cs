// See https://aka.ms/new-console-template for more information
using static System.Console;

Pessoa p1 = new Pessoa();
p1.Nome = "Ricardo";
p1.Idade = 30;
p1.EnderecoPessoa = new Endereco(){
    Cidade="Estância",
    Logradouro="Rua B",
    Numero=300
};

WriteLine("Fim");

