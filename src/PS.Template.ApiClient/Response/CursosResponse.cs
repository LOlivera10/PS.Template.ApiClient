using System;

namespace PS.Template.ApiClient.Response
{
    public class CursosResponse
    {
        public Guid CursoId { get; set; }
        public string Materia { get; set; }
        public Guid ProfesorId { get; set; }
        public string ProfesorNombre { get; set; }
        public string ProfesorApellido { get; set; }
    }
}
