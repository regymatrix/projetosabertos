// See https://aka.ms/new-console-template for more information
using System;

namespace Aula01

{
    class Program{

        static void Main(string[] args){
            Console.WriteLine("Hello, World!");
            int valor1=0;
         
            Boolean condicao=true;

            while (condicao==true){
                Console.WriteLine("Digite o valor, 0 para sair");
                valor1 =int.Parse(Console.ReadLine());
                    if (valor1==0){
                        Console.WriteLine("Você saiu da aplicação");
                        condicao=false;
                    }

            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(valor1);
                
            }

            int[] listainteiro = {1,2,3,4,5};
            foreach (var item in listainteiro)
            {
                Console.WriteLine(item);
            }

        }
        
    }


}

