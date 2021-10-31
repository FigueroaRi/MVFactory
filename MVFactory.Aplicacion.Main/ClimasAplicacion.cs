using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using MVFactory.Aplicacion.DTO;
using MVFactory.Aplicacion.Interface;
using RestSharp;

namespace MVFactory.Aplicacion.Main
{


    public class ClimasAplicacion : IClimasAplicacion
    {
        private readonly IConfiguration _configuration;

        public ClimasAplicacion(IConfiguration configuracion)
        {
            _configuration = configuracion;

        }


        public RootDTO getClimas(string ciudad)
        {


            string url = _configuration.GetSection("configApi:ApiUri").Value;// "https://api.openweathermap.org/data/2.5/";
            string recurso = _configuration.GetSection("configApi:ApiRecurso").Value; //"weather?q=";
            string apiKey = _configuration.GetSection("configApi:ApiKey").Value; //"73a873a355c648017afc004e29bba907";
            recurso = string.Concat(recurso, ciudad, "&appid=", apiKey);
            var client = new RestClient(url);
            var request = new RestRequest(recurso, Method.GET);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute<RootDTO>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK) return response.Data;

            return null;

        }



    }
}
