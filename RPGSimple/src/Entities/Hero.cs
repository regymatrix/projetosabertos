namespace RPGSimple.src.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public string HeroTypes { get; set; }

         public Hero(string Name, int Level, string HeroType)
         {
             this.Name=Name;
             this.Level=Level;
             this.HeroTypes=HeroType;
        
         }

         public Hero(){}

        
        public override string ToString()
        {


            return "Nome: "+this.Name +" Level: "+Level;
        }

        public virtual string Attack(){
            return this.Name + "Atacou com a espaada";
        }
    }

   
}