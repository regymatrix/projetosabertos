namespace RPGSimple.src.Entities
{
    public class Knight : Hero
    {

        public Knight(string Name, int Level, string HeroType)
        {
             this.Name=Name;
             this.Level=Level;
             this.HeroTypes=HeroType;
            
        }
        public override string Attack(){
            return this.Name + "Atacou com K";
        }

        public string Attack(int Bonus){
            return this.Name +" Ganhou K";
        }
        
    }
}