namespace Proiect5.Models
{
    public class Review
    {
        public int id { get; set; }
        public string feedback { get; set; }
        public int nota { get; set; }
        public int? profesorid { get; set; }
        public Profesor? profesor { get; set; }
        public int? parinteid { get; set; }
        public Parinte? parinte { get; set; }
       

        
    }
}
