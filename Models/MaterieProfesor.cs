namespace Proiect5.Models
{
    public class MaterieProfesor
    {
        public int id { set; get; }
        public string sedinta_fizica { set; get; }
        public string sedinta_online { set; get; }
        public decimal tarif { set; get; }
        public int? profesorid { set; get; }
        public Profesor? profesor { set; get; }
        public int? materieid { set; get; }
        public Materie? materie { set; get; }
        public ICollection<Programare> programare { get; set; }
    }
}
