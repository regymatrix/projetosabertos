using System;
using RPGSimple.src.Entities;

namespace rpg
{
    class Program{
        static void Main(string[] args){
           Knight hero = new Knight("Regymatrix",10,"Valente");
           Wizard wi = new Wizard("Jessica",5,"Valente");

           Console.WriteLine(hero.Attack());
           Console.WriteLine(wi.Attack(1));
        }
    }
    
}

