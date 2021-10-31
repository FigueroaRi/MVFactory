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
    public class CiudadesController : ControllerBase
    {
        private readonly ICiudadesAplicacion _ciudadesAplicion;

        public CiudadesController(ICiudadesAplicacion ciudadesAplicion)
        {
            _ciudadesAplicion = ciudadesAplicion;
        }


        /// <summary>
        /// Se obtiene las ciudades para cargar combo
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
      
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _ciudadesAplicion.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

    }
}
