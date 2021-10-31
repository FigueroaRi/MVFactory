
using System;
using AutoMapper;
using MVFactory.Aplicacion.DTO;
using MVFactory.Aplicacion.Interface;
using MVFactory.Domain.Interface;
using MVFactory.Domain.Entity;
using MVFactory.Transversal.Common;
using MVFactory.Aplicacion.Validador;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MVFactory.Aplicacion.Main
{
    public class CiudadesAplicacion : ICiudadesAplicacion
    {

        private readonly ICiudadesDomain _ciudadesDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<CiudadesAplicacion> _logger;

        public CiudadesAplicacion(ICiudadesDomain ciudadesDomaim, IMapper mapper, IAppLogger<CiudadesAplicacion> logger)
        {
            _ciudadesDomain = ciudadesDomaim;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<Response<IEnumerable<CiudadesDTO>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CiudadesDTO>>();
            try
            {
                var ciudades = await _ciudadesDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CiudadesDTO>>(ciudades);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
    }
}
