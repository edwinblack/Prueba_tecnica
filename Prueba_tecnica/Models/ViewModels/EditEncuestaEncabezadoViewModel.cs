using Prueba_tecnica.Models.Domain;

namespace Prueba_tecnica.Models.ViewModels
{
	public class EditEncuestaEncabezadoViewModel
	{
		public Guid Id { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public string URL { get; set; }
		public List<EncuestaCampos> ListaCampos { get; set; }
	}
}
