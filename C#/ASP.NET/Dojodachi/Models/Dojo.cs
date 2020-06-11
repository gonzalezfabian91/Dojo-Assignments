

namespace Dojodachi.Models
{
    public class Dojo
    {
        public string Name{get;set;}
        public int Fullness{get;set;}
        public int Happiness{get;set;}
        public int Meals{get;set;}
        public int Energy{get;set;}
        public string Message{get;set;}
        public string Image{get;set;}

        public Dojo()
        {
            Name = "Dojodachi";
            Fullness = 20;
            Happiness = 20;
            Meals = 3;
            Energy = 50;
            Message = "DOJODACHI!! Hit a button.";
            Image = "/images/Default.jpg";
        }
    }
}