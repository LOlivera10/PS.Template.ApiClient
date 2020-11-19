using PS.Template.ApiClient.Request;
using PS.Template.ApiClient.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PS.Template.ApiClient.ApiClient.Interfaces
{
    public interface ICursoApiClient
    {
        Task<CreateCursoResponse> Post(CreateCursoRequest request);
        Task<CursoResponse> GetCursoById(string id);
        Task<List<CursosResponse>> GetCursos(string apellido);
    }
}
