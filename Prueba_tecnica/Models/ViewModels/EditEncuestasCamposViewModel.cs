namespace Prueba_tecnica.Models.ViewModels
{
	public class EditEncuestasCamposViewModel
	{
		public Guid Id { get; set; }
		public string? NombreCampo { get; set; }
		public string? Titulo { get; set; }
		public bool? Requerido { get; set; }
		public string? TipoCampo { get; set; }
	}
}
