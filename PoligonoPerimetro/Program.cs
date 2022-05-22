using System; 

class Problem {

    static void Main(string[] args) { 
//TODO: Complete os espaços em branco com uma possível solução para o desafio
        //string[] v = Console.ReadLine().Split();
      
        //int [] C = A*B;
        //Console.WriteLine(int.Parse(v[1]) * int.Parse(v[1]));
         string[] v = Console.ReadLine().Split();
         
        string phrase = "Reginaldo Reis de Santana";
        string[] words = phrase.Split();

        foreach (var word in words)
        {
            System.Console.WriteLine($"{word}");
        }

    }
}