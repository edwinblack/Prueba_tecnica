namespace Prueba_tecnica.Models.Domain
{
	public class EncuestaCampos
	{
		public Guid Id { get; set; }
		public string? NombreCampo { get; set; }
		public string? Titulo { get; set; }
		public bool? Requerido { get; set; }
		public string? TipoCampo { get; set; }

		public EncuestasEncabezado? encuestasEncabezadoID { get; set; }
	}
}
