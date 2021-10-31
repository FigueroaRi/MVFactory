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
    public class ClimasHistoricoAplicacion : IClimasHistoricoAplicacion
    {

        private readonly IClimasHistoricoDomain _climasHistoricoDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<CiudadesAplicacion> _logger;



        public ClimasHistoricoAplicacion(IClimasHistoricoDomain climasHistoricoDomain, IMapper mapper, IAppLogger<CiudadesAplicacion> logger)
        {
            _climasHistoricoDomain = climasHistoricoDomain;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Response<IEnumerable<ClimaHistoricoGrillaDTO>>> GetByCiudadAsync(string  ciudadID)
        {
            var response = new Response<IEnumerable<ClimaHistoricoGrillaDTO>>();
            try
            {
               // var climasHistoricoDomain = _mapper.Map<ClimasHistorico>(pClimasHistoricoDTO);
                var climasHistorico = await _climasHistoricoDomain.GetByCiudadAsync(ciudadID);
                response.Data = _mapper.Map<IEnumerable<ClimaHistoricoGrillaDTO>>(climasHistorico);
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

        public async Task<Response<bool>> InsertAsync(ClimaHistoricoDTO pClimasHistoricoDTO)
        {
            var response = new Response<bool>();
            try
            {
                var climasHistorico = _mapper.Map<ClimasHistorico>(pClimasHistoricoDTO);
                response.Data = await _climasHistoricoDomain.InsertAsync(climasHistorico);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
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
