using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Proiect5.Models

{
    public class ElevMaterie
    {
        public int id { set; get; }
        [Required(ErrorMessage = "Data înscrierii este obligatorie.")]
        public DateTime data_inscriere { set; get; }
        [Range(1, 10, ErrorMessage = "Nota trebuie să fie între 1 și 10.")]
        public int? nota { set; get; }
        
        public int? elevid { set; get; }
        public Elev? elev { set; get; }
        [Required(ErrorMessage = "Materia este obligatorie.")]
        public int? materieid { set; get; }
        public Materie? materie { set; get; }
        public ICollection<Programare> programare { get; set; }
    }
}
