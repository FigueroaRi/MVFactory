using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVFactory.Aplicacion.DTO;//Pacagroup.Ecommerce.Application.DTO;
using MVFactory.Aplicacion.Interface;//Pacagroup.Ecommerce.Application.Interface;
using System.Threading.Tasks;

namespace MVFactory.Services.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Ciudades2Controller : Controller
    {
        // GET: Ciudades2Controller

        private readonly ICiudadesAplicacion _ciudadesAplicion;
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ciudades2Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ciudades2Controller/Create
        public ActionResult Create()
        {
            return View();
        }



        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _ciudadesAplicion.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
    }
}
