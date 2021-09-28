using Api.Lora.Take.Interface;
using Api.Lora.Take.Model;
using RestEase;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Api.Lora.Take.Facade
{
    public class RepositoryFacade : IRepositoryFacade
    {
        private readonly HttpClient _httpClient;

        public RepositoryFacade(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Repository>> GetLastsAsync(RepositoryRequest repositoryRequest)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", $"Request repos for client {repositoryRequest.UserName} report");
            var repos = _httpClient.GetStreamAsync("https://api.github.com/users/" + repositoryRequest.UserName + "/repos");

            var response = await JsonSerializer.DeserializeAsync<IEnumerable<Repository>>(await repos);

            //var r = RestClient.For<IRepositoryFacade>("https://api.github.com/users/" + repositoryRequest.UserName + "/repos");

            return response;
        }
    }
}
