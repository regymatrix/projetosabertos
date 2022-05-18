using System;


public class Sort{

    public int NumberSort { get; set; }

    public void Generate(){
          Random r = new Random();
            this.NumberSort =r.Next(1,10);
    }
}

