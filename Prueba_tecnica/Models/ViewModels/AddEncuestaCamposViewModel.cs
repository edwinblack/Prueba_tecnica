using Prueba_tecnica.Models.Domain;

namespace Prueba_tecnica.Models.ViewModels
{
	public class AddEncuestaCamposViewModel
	{
		public string? NombreCampo { get; set; }
		public string? Titulo { get; set; }
		public bool? Requerido { get; set; }
		public string? TipoCampo { get; set; }
	}
}
