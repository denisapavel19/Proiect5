using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Proiect5.Models
{
        public class Parinte
        {
            public int id { set; get; }
        [Required(ErrorMessage = "Numele este obligatoriu.")]
        public string nume { set; get; }
        [Required(ErrorMessage = "Prenumele este obligatoriu.")]
        public string prenume { set; get; }
        [Required(ErrorMessage = "Numărul de telefon este obligatoriu.")]
        public string nr_tel { set; get; }
        [Required(ErrorMessage = "Adresa de email este obligatorie.")]
        [EmailAddress(ErrorMessage = "Adresa de email nu este validă.")]
        public string email { set; get; }
        public ICollection<Elev>? elev { get; set; }
        public ICollection<Review>? review { get; set; }
    }
    }

    
