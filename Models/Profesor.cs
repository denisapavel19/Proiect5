using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Proiect5.Models
{
    public class Profesor
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Numele este obligatoriu.")]
        public string nume { get; set; }
        [Required(ErrorMessage = "Prenumele este obligatoriu.")]
        public string prenume { get; set; }
        [Required(ErrorMessage = "Specializarea este obligatorie.")]
        public string specializare { get; set; }
        [Required(ErrorMessage = "Numărul de telefon este obligatoriu.")]
        public string nr_tel { set; get; }
        [Required(ErrorMessage = "Adresa de email este obligatorie.")]
        [EmailAddress(ErrorMessage = "Adresa de email nu este validă.")]
        public string email { set; get; }
        [Required(ErrorMessage = "Adresa de sediu este obligatorie.")]
        public string adresa_sediu { set; get; }
        [Required(ErrorMessage = "Adresa Zoom este obligatorie.")]
        public string adresa_zoom { set; get; }
        public ICollection<MaterieProfesor> materieprofesor { get; set; }
        public ICollection<Review>? review { get; set; }
    }
}
