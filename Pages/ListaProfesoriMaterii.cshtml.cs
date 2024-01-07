using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect5.Data;

namespace Proiect5.Pages
{
    public class ListaProfesoriMateriiModel : PageModel
    {
        private readonly Proiect5Context _context;
        public ListaProfesoriMateriiModel(Proiect5Context context)
        {
            _context = context;
        }

        public class ListaProfesoriMaterii
        {
            public int Id { get; set; }
            public string SedintaFizica { get; set; }
            public string SedintaOnline { get; set; }

            // Constructor fără parametri
            public ListaProfesoriMaterii()
            {
            }

            // Metodă de inițializare a listei cu date dintr-un tabel
            public List<ListaProfesoriMaterii> InitializeListFromDatabase()
            {
                List<ListaProfesoriMaterii> listaProfesoriMateriiList = new List<ListaProfesoriMaterii>();

                using (var context = new Proiect5Context(options))
                {
                    // Extrageți datele din tabelul ProfesoriMaterii
                    var profesoriMateriiList = context.MaterieProfesor.ToList();

                    // Inițializați obiectele ListaProfesoriMaterii cu datele extrase
                    foreach (var profesorMaterie in profesoriMateriiList)
                    {
                        var listaProfesoriMaterii = new ListaProfesoriMaterii
                        {
                            Id = profesorMaterie.id,
                            SedintaFizica = profesorMaterie.sedinta_fizica,
                            SedintaOnline = profesorMaterie.sedinta_online
                        };

                        listaProfesoriMateriiList.Add(listaProfesoriMaterii);
                    }
                }

                return listaProfesoriMateriiList;
            }
        }

    }
}
