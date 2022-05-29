// See https://aka.ms/new-console-template for more information
using System;
using colecoes.Helper;

namespace Colecoes
{
    class Program{
        static void Main(string[] args){
            //Console.WriteLine("Hello, World!");
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 1;
            arrayInteiros[1] = 2;
            arrayInteiros[2] = 3;

            int[,] matriz = new int[2,2]{

                {8,8},
                {10,20}
            };

            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine(arrayInteiros[i]);
                
            }
            Console.WriteLine("Array Original");

            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6,3,8,1,9};

            op.ImprimirArray(array);
            op.OrdenarBubbleSort(ref array);

            // Console.WriteLine("Array ordenado");
            // op.ImprimirArray(array);

            // Console.WriteLine("Array com Array");
            // op.OrdenarArray(ref array);
            // op.ImprimirArray(array);
            
            Console.WriteLine("FIla Teste");
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("SE");
            fila.Enqueue("SP");
            fila.Enqueue("SC");

            while (fila.Count>0)
            {
                System.Console.WriteLine($"Vez de: {fila.Peek()}");
                System.Console.WriteLine($"{fila.Dequeue()} atendido");
                
            }

            Console.WriteLine("Dicionário");

            Dictionary<string, string> estados = new Dictionary<string, string>();
            estados.Add("01","AM");
            estados.Add("02","AP");
            estados.Add("03","SE");

            foreach (KeyValuePair<string,string> item in estados)
            {
                System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
                
            }
        }

    }   
}



