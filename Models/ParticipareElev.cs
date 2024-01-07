namespace Proiect5.Models
{
    public class ParticipareElev
    {
        public int id { set; get; }
        public string descriere { set; get; }
        public string prezenta { set; get; }
        public string tema { set; get; }
        public int? elevid { set; get; }
        public Elev? elev { set; get; }
        public int? sedintameditatieid { set; get; }
        public SedintaMeditatie? sedintameditatie { set; get; }
    }
}
