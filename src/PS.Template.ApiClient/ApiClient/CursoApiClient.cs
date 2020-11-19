using PS.Template.ApiClient.ApiClient.Interfaces;
using PS.Template.ApiClient.Request;
using PS.Template.ApiClient.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PS.Template.ApiClient.ApiClient
{
    public class CursoApiClient : BaseApiClient,  ICursoApiClient
    {
        private readonly string URLBASE;

        public CursoApiClient(string url)
        {
            URLBASE = url;
        }

        public async Task<CursoResponse> GetCursoById(string id)
        {
            var url = $"{URLBASE}/api/curso/{id}";
            return await GetAsync<CursoResponse>(url);
        }

        public async Task<List<CursosResponse>> GetCursos(string apellido)
        {
            var url = $"{URLBASE}/api/curso";
            return await GetAsync<List<CursosResponse>>(url);
        }

        public async Task<CreateCursoResponse> Post(CreateCursoRequest request)
        {
            var url = $"{URLBASE}/api/curso";
            return await ApiPost<CreateCursoRequest, CreateCursoResponse>(url, request);
        }
    }
}
