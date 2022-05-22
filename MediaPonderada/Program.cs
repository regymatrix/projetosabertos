using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
//TODO: Complete os espaços em branco com uma possível solução para o desafio
            double MEDIA = ((A*2)+(B*3)+(C*5))/10.0;
            Console.WriteLine("A média final é = " + Math.Round(MEDIA,1)  );
            Console.ReadKey();
        }
    }
}