﻿namespace Proiect5.Models
{
        public class Parinte
        {
            public int id { set; get; }
            public string nume { set; get; }
            public string prenume { set; get; }
            public string nr_tel { set; get; }
            public string email { set; get; }
        public ICollection<Elev>? elev { get; set; }
        public ICollection<Review>? review { get; set; }
    }
    }

    
