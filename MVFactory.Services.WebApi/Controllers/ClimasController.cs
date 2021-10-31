using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MVFactory.Aplicacion.DTO;
using MVFactory.Aplicacion.Interface;
using System.Threading.Tasks;

using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

using RestSharp;


namespace MVFactory.Services.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClimasController : Controller
    {

        private readonly IClimasAplicacion _climasAplicacion;

        public ClimasController(IClimasAplicacion climasAplicacion)
        {
            _climasAplicacion = climasAplicacion;
        }




        /// <summary>
        /// Se obtienen los climas por ciudad, se consume api externa 
        /// http://openweathermap.org/
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        //Metodo para cargar combo de ciudades
        public  IActionResult GetAllAsync(string ciudad)
        {

            var response = _climasAplicacion.getClimas(ciudad);
            if (response!=null)
                return Ok(response);

            return BadRequest(response);
        }

       
    }
}
