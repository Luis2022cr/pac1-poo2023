using ExamenUnidad2.Interfaces;
using ExamenUnidad2.Models;

namespace ExamenUnidad2.Servicios
{
    public class RepositorioAlumnos : IRepositorioAlumnos
    {
		public List<Models.Alumno> Alumnos { get; }

		public RepositorioAlumnos()
		{
			Alumnos = new List<Models.Alumno>();
		}

		public void AgregarAlumno(Models.Alumno alumno)
		{
			Alumnos.Add(alumno);
		}

		public List<Models.Alumno> ObtenerAlumnos()
		{
			return Alumnos;
		}

	}
}

