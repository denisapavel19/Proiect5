namespace Proiect5.Models
{
    public class Materie
    {
        public int id { set; get; }
        public string denumire { set; get; }
        public string nivel { set; get; }
        public string clasa { set; get; }
        public ICollection<MaterieProfesor> materieprofesor { get; set; }
        public ICollection<ElevMaterie> elevimaterie { get; set; }
    }
}
