using System;
using System.Collections.Generic;

namespace PS.Template.ApiClient.Response
{
    public class CursoResponse
    {
        public Guid CursoId { get; set; }
        public string Materia { get; set; }
        public ProfesorResponse Profesor { get; set; }
        public List<AlumnoResponse> Alumnos { get; set; }
    }
    public class ProfesorResponse
    {
        public Guid ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
    public class AlumnoResponse
    {
        public Guid AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
    }
}
