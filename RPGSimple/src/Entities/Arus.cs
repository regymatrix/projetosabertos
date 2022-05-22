namespace RPGSimple.src.Entities
{
    public class Arus
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public string HeroTypes { get; set; }

         public Arus(string Name, int Level, string HeroType)
         {
             this.Name=Name;
             this.Level=Level;
             this.HeroTypes=HeroType;
        
         }

        
        public override string ToString()
        {


            return "Nome: "+this.Name +" Level: "+Level;
        }

        public string Attack(){
            return this.Name + "Atacou com a espaada";
        }
    }

   
}