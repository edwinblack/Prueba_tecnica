using Prueba_tecnica.Models.Domain;

namespace Prueba_tecnica.Models.ViewModels
{
	public class AddEncuestaViewModel
	{
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public string URL { get; set; }
		public List<AddEncuestaCamposViewModel> ListaCampos { get; set; }
	}
}
