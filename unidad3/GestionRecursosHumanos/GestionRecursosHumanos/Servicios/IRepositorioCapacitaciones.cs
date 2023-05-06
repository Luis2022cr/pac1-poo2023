using GestionRecursosHumanos.Models;

namespace GestionRecursosHumanos.Servicios
{
	public interface IRepositorioCapacitaciones
	{
		Task Actualizar(CapacitacionCreacionViewModel modelo);
		Task Borrar(int id);
		Task Crear(Capacitacion capacitacion);
		Task<IEnumerable<Capacitacion>> ObtenerCapacitaciones(int usuarioId);
		Task<Capacitacion> ObtenerPorId(int id, int usuarioId);
	}
}