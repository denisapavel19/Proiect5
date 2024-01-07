using System.ComponentModel.DataAnnotations;
namespace Proiect5.Models
{
    public class Review
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Feedback-ul este obligatoriu.")]
        public string feedback { get; set; }
        [Range(1, 10, ErrorMessage = "Nota trebuie să fie între 1 și 10.")]
        public int nota { get; set; }
        [Required(ErrorMessage = "Id-ul profesorului este obligatoriu.")]
        public int? profesorid { get; set; }
        public Profesor? profesor { get; set; }
        [Required(ErrorMessage = "Id-ul părintelui este obligatoriu.")]
        public int? parinteid { get; set; }
        public Parinte? parinte { get; set; }
       

        
    }
}
