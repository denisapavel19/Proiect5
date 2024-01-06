namespace Proiect5.Models
{
    public class Profesor
    {
        public int id { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string specializare { get; set; }
        public string nr_tel { set; get; }
        public string email { set; get; }
        public string adresa_sediu { set; get; }
        public string adresa_zoom { set; get; }
        public ICollection<ProfesorMaterie> profesormaterie { get; set; }
    }
}
