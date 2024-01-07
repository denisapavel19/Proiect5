using Proiect5.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Proiect5.Models
{
    public class Elev
    {
        public int id { set; get; }
        
        [Required(ErrorMessage = "Numele elevului este obligatoriu.")]
        public string nume { set; get; }
        [Required(ErrorMessage = "Prenumele elevului este obligatoriu.")]
        public string prenume { set; get; }
        [Range(1, 120, ErrorMessage = "Varsta trebuie să fie între 1 și 120 ani.")]
        public int varsta { set; get; }
        [Required(ErrorMessage = "Clasa elevului este obligatorie.")]
        public string clasa { set; get; }
        [Required(ErrorMessage = "Numărul de telefon este obligatoriu.")]
        [Phone(ErrorMessage = "Introduceți un număr de telefon valid.")]
        public string nr_tel { set; get; }
        [EmailAddress(ErrorMessage = "Introduceți o adresă de email validă.")]
        public string? email { set; get; }
        public string? scoala { set; get; }
        public int? parinteid { set; get; }
        public Parinte? parinte { set; get; }
        public ICollection<ElevMaterie> elevmaterie { get; set; }
        public ICollection<ParticipareElev> participareelev { get; set; }

    }
}

