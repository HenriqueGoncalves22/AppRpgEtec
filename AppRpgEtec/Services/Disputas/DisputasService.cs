using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Models;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace AppRpgEtec.Services.Disputas
{
    public class DisputasService : Request
    {
        private readonly Request _request;
        private string _token;

        private const string apiUrlBase = "http://luizsouza.somee.com/RpgApi/Disputas";

        public DisputasService(string token)
        {
            _token = token;
            _request = new Request();
        }

        public async Task<Disputa> PostDisputaComArmaAsync(Disputa d)
        {
            string urlComplementar = "/Arma";
            return await _request.PostAsync(apiUrlBase + urlComplementar, d, _token);
        }

        public async Task<Disputa> PostDisputaComHabilidadesAsync(Disputa d)
        {
            string urlComplementar = "/Habilidade";
            return await _request.PostAsync(apiUrlBase + urlComplementar, d, _token);
        }

        public async Task<Disputa> PostDisputaGeralAsync(Disputa d)
        {
            string urlComplementar = "/DisputaEmGrupo";
            return await _request.PostAsync(apiUrlBase + urlComplementar, d, _token);
        }

      


    }
}