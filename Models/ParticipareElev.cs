using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proiect5.Models
{
    public class ParticipareElev
    {
        public int id { set; get; }
        [Required(ErrorMessage = "Descrierea este obligatorie.")]
        public string descriere { set; get; }
        [Required(ErrorMessage = "Prezența este obligatorie.")]
        public string prezenta { set; get; }
        [Required(ErrorMessage = "Tema este obligatorie.")]
        public string tema { set; get; }
        public int? elevid { set; get; }
        public Elev? elev { set; get; }
        public int? sedintameditatieid { set; get; }
        public SedintaMeditatie? sedintameditatie { set; get; }
    }
}
