using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_tecnica.Data;
using Prueba_tecnica.Models.Domain;

namespace Prueba_tecnica.Pages.Encuestas
{
    public class ListModel : PageModel
    {
		private readonly PruebaTecnicaDbContext dbContext;
        public List<Models.Domain.EncuestasEncabezado>  EncuestasEncabezados { get; set; }

		public ListModel(PruebaTecnicaDbContext dbContext)
        {
			this.dbContext = dbContext;
		}
        public void OnGet()
        {
            var encuestas = dbContext.EncuestasEncabezados.ToList();
        }
    }
}
