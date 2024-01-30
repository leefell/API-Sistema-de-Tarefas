/* 
 Refit é uma biblioteca para o desenvolvimento de clientes de API em .NET. Ela simplifica  o processo de 
fazer chamadas HTTP para uma API RESTful, permitindo que você defina interfaces no estilo do C# para descrever as chamadas de API.

Com Refit, você pode definir uma interface com métodos que representam os endpoints da sua API, 
e o Refit se encarrega de gerar uma implementação para essa interface, eliminando a necessidade de escrever código repetitivo para criar e configurar 
clientes HTTP manualmente.
 */
using API_SistemaDeTarefas.Integracao.Response;
using Refit;

namespace API_SistemaDeTarefas.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}
