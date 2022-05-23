namespace RPGSimple.src.Entities
{
    public class Wizard : Hero,  IPlayBegin
    {
        public Wizard(string Name, int Level, string HeroType)
        {
             this.Name=Name;
             this.Level=Level;
             this.HeroTypes=HeroType;
            
        }
        public Wizard(){}
       

        // public string Attack(int Bonus){
        //     if (Bonus >6){
        //         return this.Name +" Yes. We won 10XP";
        //     } else{
        //         return this.Name +" Yes, We won 5XP";
        //     }            
        // }

        public List<Hero> listPlayers()
        {
            List<Hero> Wizards = new List<Hero>();
            Wizard w1 = new("W1",10,"Adventure");
            Wizard w2 = new("W2",100,"Adventure");
            Wizard w3 = new("W3",200,"Adventure");
            Wizard w4 = new("W4",300,"Adventure");
            
            Wizards.Add(w1);
            Wizards.Add(w2);
            Wizards.Add(w3);
            Wizards.Add(w4);

            return Wizards;
        }

        
        


    }
}