// See https://aka.ms/new-console-template for more information
using static System.Console;

public class Program{
    public static void Main()
    {
        int a =2;
        a = Adicionar20(a);
        Console.WriteLine($"O Valor da variável é {a}");
        // Sort mysort = new Sort();
        // mysort.Generate();
        // Console.WriteLine("Number sort is "+mysort.NumberSort);
    }
    static int Adicionar20(int a){
        return a + 20;
    }

}

