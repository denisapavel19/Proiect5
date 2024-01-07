using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Proiect5.Models
{
    public class MaterieProfesor
    {
        public int id { set; get; }
        [Required(ErrorMessage = "Sedinta fizica este obligatorie.")]
        public string sedinta_fizica { set; get; }
        [Required(ErrorMessage = "Sedinta online este obligatorie.")]
        public string sedinta_online { set; get; }
        [Required(ErrorMessage = "Tariful este obligatoriu.")]
        [Range(0, double.MaxValue, ErrorMessage = "Tariful trebuie să fie un număr pozitiv.")]
        public decimal tarif { set; get; }
        [Required(ErrorMessage = "Profesorul este obligatoriu.")]
        public int? profesorid { set; get; }
        public Profesor? profesor { set; get; }
        [Required(ErrorMessage = "Materia este obligatorie.")]

        public int? materieid { set; get; }
        public Materie? materie { set; get; }
        public ICollection<Programare> programare { get; set; }
    }
}
