using Dapper;
using GestionRecursosHumanos.Models;
using Microsoft.Data.SqlClient;

namespace GestionRecursosHumanos.Servicios
{
	public class RepositorioCapacitaciones : IRepositorioCapacitaciones
	{
		private readonly IConfiguration configuration;
		private readonly string connectionString;

		public RepositorioCapacitaciones(IConfiguration configuration)
		{
			this.configuration = configuration;
			connectionString = configuration.GetConnectionString("DefaultConnection").ToString();
		}

		//public async Task<IEnumerable<Capacitacion>> Obtener(int usuarioId)
		//{
		//	using var connection = new SqlConnection(connectionString);

		//	return await connection.QueryAsync<Capacitacion>
		//		(@"SELECT Id, Nombre, DepartamentoId, Fecha, Duracion, Costo, EmpleadoId, Descripcion
		//		FROM Capacitaciones
		//		WHERE UsuarioId = @UsuarioId", new { usuarioId });
		//}

		public async Task<IEnumerable<Capacitacion>> ObtenerCapacitaciones(int usuarioId)
		{
			using var connection = new SqlConnection(connectionString);
			return await connection.QueryAsync<Capacitacion>
				(@"SELECT
					cp.Id,
					cp.Nombre,
					cp.Fecha,
					cp.Duracion,
					cp.Costo,
					cp.Descripcion,
					de.Nombre AS Departamento,
					em.Nombre AS Empleado
				FROM Capacitaciones cp
				INNER JOIN Departamentos de
				ON de.Id = cp.DepartamentoId
				INNER JOIN Empleados em
				ON em.Id = cp.EmpleadoId
				WHERE de.UsuarioId = @UsuarioId", new { usuarioId });
		}
		public async Task Crear(Capacitacion capacitacion)
		{
			using var connection = new SqlConnection(connectionString);
			var id = await connection.QuerySingleAsync<int>
				($@"INSERT INTO Capacitaciones
                (Nombre, Fecha, Duracion, Costo, Descripcion, DepartamentoId, EmpleadoId, UsuarioId)
                VALUES
                (@Nombre, @Fecha, @Duracion, @Costo, @Descripcion, @DepartamentoId, @EmpleadoId, @UsuarioId);
                SELECT SCOPE_IDENTITY()", capacitacion);
		}

		public async Task Actualizar(CapacitacionCreacionViewModel modelo)
		{
			using var connection = new SqlConnection(connectionString);

			await connection.ExecuteAsync
				(@"UPDATE Capacitaciones
				SET Nombre = @Nombre,
					Fecha = @Fecha,
					Duracion = @Duracion,
					DepartamentoId = @DepartamentoId,
					Costo = @Costo,
					EmpleadoId = @EmpleadoId,
					Descripcion = @Descripcion
				WHERE Id = @Id", modelo);
		}

		public async Task<Capacitacion> ObtenerPorId(int id, int usuarioId)
		{
			using var connection = new SqlConnection(connectionString);
			return await connection.QueryFirstOrDefaultAsync<Capacitacion>
				(@"SELECT 
					cp.Id,
					cp.Nombre,
					cp.Fecha,
					cp.Duracion,
					cp.Costo,
					cp.Descripcion
				FROM Capacitaciones AS cp
				INNER JOIN Departamentos AS de
				ON de.Id = cp.DepartamentoId
				INNER JOIN Empleados em
				ON em.Id = cp.EmpleadoId
				WHERE de.UsuarioId = @UsuarioId AND cp.Id = @Id;", new { id, usuarioId });
		}

		public async Task Borrar(int id)
		{
			using var connection = new SqlConnection(connectionString);
			await connection.ExecuteAsync("DELETE Capacitaciones WHERE Id = @Id", new { id });
		}
	}
}
