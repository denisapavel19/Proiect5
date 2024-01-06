using System.ComponentModel;

namespace Proiect5.Models
{
    public class Programare
    {public int id { set; get; }
        public DateTime data { get; set; }
        [DisplayName("Elev")]
        public int? elevmaterieid { set; get; }
        public ElevMaterie? elevmaterie { set; get; }
        [DisplayName("Profesor")]
        public int? materieprofesorid { set; get; }
        public MaterieProfesor? materieprofesor { set; get; }
    }
}
