namespace Proiect5.Models
{
    public class ElevMaterie
    {
        public int id { set; get; }
        public DateTime data_inscriere { set; get; }
        public int? nota { set; get; }
        
        public int? elevid { set; get; }
        public Elev? elev { set; get; }
        public int? materieid { set; get; }
        public Materie? materie { set; get; }
    }
}
