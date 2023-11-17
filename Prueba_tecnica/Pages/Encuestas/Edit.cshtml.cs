using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prueba_tecnica.Data;
using Prueba_tecnica.Models.Domain;
using Prueba_tecnica.Models.ViewModels;

namespace Prueba_tecnica.Pages.Encuestas
{
    public class EditModel : PageModel
    {
		private readonly PruebaTecnicaDbContext dbContext;

        [BindProperty]

        public EditEncuestaEncabezadoViewModel EditEncuestaEncabezadoViewModel { get; set; }
		public EditModel(PruebaTecnicaDbContext dbContext)
        {
			this.dbContext = dbContext;
		}
        public void OnGet(Guid id)
        {
            var EncuestaEncabezado = dbContext.EncuestasEncabezados.Find(id);
            if(EncuestaEncabezado != null)
            {
                var campos = dbContext.EncuestaCampos.Include(e => e.encuestasEncabezadoID).ToList();


                EditEncuestaEncabezadoViewModel = new EditEncuestaEncabezadoViewModel()
                {
                    Nombre = EncuestaEncabezado.Nombre,
                    Descripcion = EncuestaEncabezado.Descripcion,
                    URL = EncuestaEncabezado.URL,
                    ListaCampos = campos
                };
            }
        }
    }
}
