using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MVFactory.Aplicacion.DTO;
using MVFactory.Aplicacion.Interface;
using System.Threading.Tasks;


namespace MVFactory.Services.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClimaHistoricoCiudadesController : Controller
    {
        private readonly IClimasHistoricoAplicacion _climasHistoricoAplicacion;

        public ClimaHistoricoCiudadesController(IClimasHistoricoAplicacion climasHistoricoAplicacion)
        {
            _climasHistoricoAplicacion = climasHistoricoAplicacion;
        }




        /// <summary>
        /// Se obtiene los climas historicos registrados
        /// </summary>
        /// <returns></returns>
        [HttpGet("{ciudadId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
   
        public async Task<IActionResult> GetAllAsync(string ciudadId)
        {
            var response = await _climasHistoricoAplicacion.GetByCiudadAsync(ciudadId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }


        /// <summary>
        /// Se persisten los datos consultados 
        /// </summary>
        /// <returns></returns>

        [HttpPost()]
        public async Task<IActionResult> Insert([FromBody] ClimaHistoricoDTO climaHistoricoDTO)
        {
            if (climaHistoricoDTO == null)
                return BadRequest();
            var response = await _climasHistoricoAplicacion.InsertAsync(climaHistoricoDTO);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response);
        }
    }
}
