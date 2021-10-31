using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MVFactory.Domain.Entity;
using MVFactory.Domain.Interface;
using MVFactory.Infraestructura.Interfaces;

namespace MVFactory.Domain.Core
{
    public class ClimasHistoricoDomain : IClimasHistoricoDomain
    {
        private readonly IClimasHistoricoRepository _climasHistoricoRepository;
        public ClimasHistoricoDomain(IClimasHistoricoRepository climasHistoricoRepository)
        {

            _climasHistoricoRepository = climasHistoricoRepository;
        }

        public async Task<IEnumerable<ClimaHistoricoGrilla>> GetByCiudadAsync(string ciudadID)
        {
            return await _climasHistoricoRepository.GetByCiudadAsync(ciudadID);
        }

        public async Task<bool> InsertAsync(ClimasHistorico pClimasHistorico)
        {
            return await _climasHistoricoRepository.InsertAsync(pClimasHistorico);
        }
    }
}
