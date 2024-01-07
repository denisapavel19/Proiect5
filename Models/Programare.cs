using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Proiect5.Models
{
    public class Programare
    {public int id { set; get; }
        [Required(ErrorMessage = "Data programării este obligatorie.")]
        [DisplayName("Data Programării")]
        public DateTime data { get; set; }
        [Required(ErrorMessage = "Elevul este obligatoriu.")]
        [DisplayName("Elev")]
        public int? elevmaterieid { set; get; }
        public ElevMaterie? elevmaterie { set; get; }
        [Required(ErrorMessage = "Profesorul este obligatoriu.")]
        [DisplayName("Profesor")]
        public int? materieprofesorid { set; get; }
        public MaterieProfesor? materieprofesor { set; get; }
    }
}
