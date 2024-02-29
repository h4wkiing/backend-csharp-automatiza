using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace automatizasistemas.Controllers
{
    [Route("api/catalogo")]
    [ApiController]
    public class CatalogoController : ControllerBase
    {
        private readonly HttpClient _client;

        public CatalogoController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://catalogoautomatiza.azurewebsites.net/api/produtos/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: api/Produtos
        [HttpGet("{ean}/imagens")]
        public async Task<dynamic> Getprodutos(string ean)
        {
          try
            {
                HttpResponseMessage response = await _client.GetAsync($"{ean}");
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();

                    var deserializedObject = JsonConvert.DeserializeObject<JObject>(responseString);

                    var imagens = deserializedObject?["imagens"]?.ToObject<List<string>>() ?? new List<string>();

                    return Ok(imagens);
                }
                else
                {
                    return StatusCode((int)response.StatusCode, $"Erro ao buscar imagens do produto: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno: {ex.Message}");
            }
        }
    }
}
