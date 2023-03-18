using ExamenUnidad2.Models;

namespace ExamenUnidad2.Interfaces
{
    public interface IRepositorioAlumnos
    {
		public List<Models.Alumno> ObtenerAlumnos();

		public List<Models.Alumno> Alumnos { get; set; }

		public void AgregarAlumno(Models.Alumno alumno);
	}
}
