using Proiect5.Models;

namespace Proiect5.Models
{
    public class Elev
    {
        public int id { set; get; }
        public string nume { set; get; }
        public string prenume { set; get; }
        public int varsta { set; get; }
        public string clasa { set; get; }
        public string nr_tel { set; get; }
        public string? email { set; get; }
        public string? scoala { set; get; }
        public int? parinteid { set; get; }
        public Parinte? parinte { set; get; }
        public ICollection<ElevMaterie> elevmaterie { get; set; }

    }
}

