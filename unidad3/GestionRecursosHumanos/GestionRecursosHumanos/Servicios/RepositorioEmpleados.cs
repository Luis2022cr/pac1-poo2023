﻿using Dapper;
using GestionRecursosHumanos.Models;
using Microsoft.Data.SqlClient;

namespace GestionRecursosHumanos.Servicios
{
	public class RepositorioEmpleados : IRepositorioEmpleados
	{
		private readonly string connectionString;

		public RepositorioEmpleados(IConfiguration configuration)
		{ 
			connectionString = configuration.GetConnectionString("DefaultConnection").ToString();
		}

		public async Task Crear(Empleado empleado)
		{
			using var connection = new SqlConnection(connectionString);
			var id = await connection.QuerySingleAsync<int>
				($@"INSERT INTO Empleados
                (Nombre, FechaNacimiento, CargoId, Genero, Email, Telefono, FechaIngreso, Salario, Estado, Descripcion, UsuarioId, DepartamentoId)
                VALUES
                (@Nombre, @FechaNacimiento, @CargoId, @Genero, @Email, @Telefono, @FechaIngreso, @Salario, @Estado, @Descripcion, @UsuarioId, @DepartamentoId);
                SELECT SCOPE_IDENTITY()", empleado);
		}

		public async Task<IEnumerable<Empleado>> ObtenerEmpleados(int usuarioId)
		{
			using var connection = new SqlConnection(connectionString);
			return await connection.QueryAsync<Empleado>
				(@"SELECT
					em.Id,
					em.Nombre,
					em.FechaNacimiento,
					em.Genero,
					em.Email,
					em.Telefono,
					em.FechaIngreso,
					em.Salario,
					em.Estado,
					em.Descripcion,
					ca.Nombre AS Cargo,
					de.Nombre AS Departamento
				FROM Empleados em
				INNER JOIN Cargos ca 
					ON ca.Id = em.CargoId
				INNER JOIN Departamentos de
					ON de.Id = em.DepartamentoId
				WHERE ca.UsuarioId = @UsuarioId", new {usuarioId});
		}

		public async Task<Empleado> ObtenerPorId(int id, int usuarioId)
		{
			using var connection = new SqlConnection(connectionString);
			return await connection.QueryFirstOrDefaultAsync<Empleado>
				(@"SELECT 
					em.Id,
					em.Nombre,
					em.FechaIngreso,
					em.FechaNacimiento,
					em.Genero,
					em.Email,
					em.Telefono,
					em.Estado,
					em.Salario,
					em.Descripcion
				FROM Empleados AS em
				INNER JOIN Cargos AS ca
				ON ca.Id = em.CargoId
				WHERE ca.UsuarioId = @UsuarioId AND em.Id = @Id;", new { id, usuarioId });
		}

		public async Task Actualizar(EmpleadoCreacionViewModel modelo)
		{
			using var connection = new SqlConnection(connectionString);

			await connection.ExecuteAsync
				(@"UPDATE Empleados
				SET Nombre = @Nombre,
					FechaNacimiento = @FechaNacimiento,
					CargoId = @CargoId,
					DepartamentoId = @DepartamentoId,
					Genero = @Genero,
					Email = @Email,
					Telefono = @Telefono,
					Salario = @Salario,
					Estado = @Estado,
					FechaIngreso = @FechaIngreso,
					Descripcion = @Descripcion
				WHERE Id = @Id", modelo);
		}

		public async Task Borrar(int id)
		{
			using var connection = new SqlConnection(connectionString);
			await connection.ExecuteAsync("DELETE Empleados WHERE Id = @Id", new { id });
		}
	}
}
