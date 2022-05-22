// See https://aka.ms/new-console-template for more information
using static System.Console;


public class Program{

static void TrocarNome(Pessoa p1, string nomeNovo){
    p1.Nome=nomeNovo;
}

static int EncontrarNumero(int[] numeros, int numero){
    for (int i=0; i<numeros.Length;i++)
    {
        if (numeros[i] = numero)
        return 1;
    }
    return -1;
}

static bool EncontrarPessoa (List<Pessoa> pessoas, Pessoa pessoa){
    foreach (var item in pessoas)
    {
        if (item = pessoa){
            return true;
        } 
        
    }
    return false;    
}


public static void Main(){    
        Pessoa  p1 = new Pessoa();
        p1.Nome="Reginaldo";
        p1.Idade =32;
        p1.Documento="Word";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1,"Maria");

        WriteLine($"O novo nome é: {p1.Nome}");
}

}



