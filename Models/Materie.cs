using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Proiect5.Models
{
    public class Materie
    {
        public int id { set; get; }
        [Required(ErrorMessage = "Denumirea materiei este obligatorie.")]
        public string denumire { set; get; }
        [Required(ErrorMessage = "Nivelul materiei este obligatoriu.")]
        public string nivel { set; get; }
        [Required(ErrorMessage = "Clasa este obligatorie.")]
        public string clasa { set; get; }
        public ICollection<MaterieProfesor> materieprofesor { get; set; }
        public ICollection<ElevMaterie> elevimaterie { get; set; }
    }
}
