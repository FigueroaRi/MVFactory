using System;
using Dapper;
using MVFactory.Domain.Entity;
using MVFactory.Transversal.Common;
using MVFactory.Infraestructura.Interfaces;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MVFactory.Infraestructura.Repository
{
     public class CiudadesRepositiry :ICiudadesRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public CiudadesRepositiry(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<Ciudades>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CiudadesGetAll";
         

                var ciudades = await connection.QueryAsync<Ciudades>(query,   commandType: CommandType.StoredProcedure);
                return ciudades;
            }
        }
    }
}
