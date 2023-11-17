using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prueba_tecnica.Data;
using Prueba_tecnica.Models.Domain;
using Prueba_tecnica.Models.ViewModels;
using System;

namespace Prueba_tecnica.Pages.Encuestas
{
    public class AddModel : PageModel
    {
		private readonly PruebaTecnicaDbContext dbContext;
		private static Random random = new Random();

		public AddModel(PruebaTecnicaDbContext dbContext)
        {
			this.dbContext = dbContext;
		}
        [BindProperty]
        public AddEncuestaViewModel NewEncuestaRequest { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() {

			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string EncuestaID = new (Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
			var EncuestaEncabezadoDomain = new EncuestasEncabezado
            {
                Nombre = NewEncuestaRequest.Nombre,
                Descripcion = NewEncuestaRequest.Descripcion,
                URL = EncuestaID
            };

			dbContext.EncuestasEncabezados.Add(EncuestaEncabezadoDomain);
			dbContext.SaveChanges();

			foreach (var campo in NewEncuestaRequest.ListaCampos)
            {
                var EncuestaCamposDomain = new EncuestaCampos
                {
                    NombreCampo = campo.NombreCampo,
                    Titulo = campo.Titulo,
                    Requerido = campo.Requerido,
                    TipoCampo = campo.TipoCampo,
                    encuestasEncabezadoID = EncuestaEncabezadoDomain
				};

                dbContext.EncuestaCampos.Add(EncuestaCamposDomain);
                dbContext.SaveChanges();
            }




			ViewData["Message"] = "Encuesta creada con exito";
        }
    }
}
