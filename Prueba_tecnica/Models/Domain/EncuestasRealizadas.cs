namespace Prueba_tecnica.Models.Domain
{
	public class EncuestasRealizadas
	{
		public Guid Id { get; set; }
		public string? respuesta { get; set; }
		public string? Titulo { get; set; }
		public bool? Requerido { get; set; }
		public string? TipoCampo { get; set; }

		public EncuestaCampos? encuestaCamposID { get; set; }
	}
}
