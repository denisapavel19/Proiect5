using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Proiect5.Models
{
    public class SedintaMeditatie
    {
        public int id { set; get; }
        [Required(ErrorMessage = "Data de început a ședinței este obligatorie.")]
        public DateTime inceput { set; get; }
        [Required(ErrorMessage = "Data de sfârșit a ședinței este obligatorie.")]
        public DateTime sfarsit { set; get; }
        public ICollection<ParticipareElev> participareelev { get; set; }
    }
}
