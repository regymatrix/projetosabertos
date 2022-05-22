namespace RPGSimple.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType)
        {
             this.Name=Name;
             this.Level=Level;
             this.HeroTypes=HeroType;
            
        }
        public override string Attack(){
            return this.Name + "Atacou com Magia";
        }

        public string Attack(int Bonus){
            if (Bonus >6){
                return this.Name +" Ganhou Bônus";
            } else{
                return this.Name +" Ganhou MUITO POUCO";
            }
            
        }
        
    }
}