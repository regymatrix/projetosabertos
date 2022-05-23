using System;
using RPGSimple.src.Entities;

namespace rpg
{
    class Program{
        static void Main(string[] args){
        
           Console.WriteLine("Century Battle");

           Knight knight = new Knight();
            Wizard wizard = new Wizard();

           List<Hero> Team01K = knight.listPlayers();
           List<Hero> Team02W = wizard.listPlayers();
           int Team01kscore = 0;
           int Team02kscore = 0;
           Random rnd = new Random();

           for (int i = 0; i < 4; i++)
           {
                if ((Team01K[rnd.Next(0,3)].Level) >(Team02W[rnd.Next(0,3)].Level)) {
                    Team01kscore = Team01kscore+10;
                } else if ((Team01K[rnd.Next(0,3)].Level) <(Team02W[rnd.Next(0,3)].Level)) {
                    Team02kscore = Team02kscore+10;
                } else{
                    Team01kscore=Team01kscore+5;
                    Team02kscore=Team02kscore+5;
                }               
           }

           string[] listwin = new string[4];

           if (Team01kscore > Team02kscore){
               Console.WriteLine ($"The win is the Team 01 with {Team01kscore} points");
                listwin =Hero.Members(knight.listPlayers());                            
           } else if (Team01kscore < Team02kscore) {
                Console.WriteLine ($"The win is the Team 02 with {Team01kscore} points");
                listwin =Hero.Members(wizard.listPlayers());
               
           } else {
              Console.WriteLine("Nobody won");
           }

            Console.WriteLine("The members are:"); 
            foreach (var item in listwin)
            {
                    Console.WriteLine(item.ToString());
            }
                     
        
        }

    }
    
}

