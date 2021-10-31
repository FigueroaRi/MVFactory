using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MVFactory.Domain.Entity;
using MVFactory.Domain.Interface;
using MVFactory.Infraestructura.Interfaces;

namespace MVFactory.Domain.Core
{
    public class CiudadesDomain : ICiudadesDomain
    {
        private readonly ICiudadesRepository _ciudadesRepository;
        public CiudadesDomain(ICiudadesRepository ciudadesRepository)
        {
            _ciudadesRepository = ciudadesRepository;
        }
        public async Task<IEnumerable<Ciudades>> GetAllAsync()
        {
            return   await _ciudadesRepository.GetAllAsync();
        }
    }
}
