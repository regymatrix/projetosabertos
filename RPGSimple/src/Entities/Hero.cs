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
            return "Nome: "+this.Name +" Level: "+Level ;
        }
        
        static public string[] Members(List<Hero> Heroes){
            int i =Heroes.Count();
            string[] namesmembers = new string[Heroes.Count()];            
            foreach (var item in Heroes)
            {
                namesmembers[Heroes.Count()-i] = item.Name + " | ";
                i = i-1;
                
            }
            return  namesmembers;

        }
             
    }

   
}