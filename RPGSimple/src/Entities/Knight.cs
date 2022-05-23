namespace RPGSimple.src.Entities
{
    public class Knight : Hero,  IPlayBegin
    {
        

        public Knight(string Name, int Level, string HeroType)
        {
             this.Name=Name;
             this.Level=Level;
             this.HeroTypes=HeroType;
            
        }

        public Knight(){}
        // public override string Attack(){
        //     return this.Name + " Atacou com K";
        // }

        // public string Attack(int Bonus){
        //     return this.Name +" Ganhou K";
        // }

        public  List<Hero> listPlayers()
        {
            List<Hero> Knights = new List<Hero>();
            Knight k1 = new("K1",5,"Adventure");
            Knight k2 = new("K2",50,"Adventure");
            Knight k3 = new("K3",250,"Adventure");
            Knight k4 = new("K4",400,"Adventure");
            
            Knights.Add(k1);
            Knights.Add(k2);
            Knights.Add(k3);
            Knights.Add(k4);

            return Knights;
        }

       

        

        
    }
}