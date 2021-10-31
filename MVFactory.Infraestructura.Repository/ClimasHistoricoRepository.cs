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
    public class ClimasHistoricoRepository : IClimasHistoricoRepository
    {


        private readonly IConnectionFactory _connectionFactory;

        public ClimasHistoricoRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }


        public async Task<IEnumerable<ClimaHistoricoGrilla>> GetByCiudadAsync(string ciudadID)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ClimasHistoricoGetByCiudad";

                var parameters = new DynamicParameters();             
                parameters.Add("@idCiudad", ciudadID);
        
                var climasHistorico = await connection.QueryAsync<ClimaHistoricoGrilla>(query, param: parameters, commandType: CommandType.StoredProcedure);

             

                return climasHistorico;
            }
        }


        public async Task<bool> InsertAsync(ClimasHistorico pClimasHistorico)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "ClimasHistoricoInsert";
                var parameters = new DynamicParameters();
                parameters.Add("@idCiudad", pClimasHistorico.Ciudad.IdCiudad);
                parameters.Add("@IdPais", pClimasHistorico.Ciudad.Pais.IdPais);
                parameters.Add("@Clima ", pClimasHistorico.Clima);
                parameters.Add("@SensacionTermica", pClimasHistorico.SenacionTerminca);
                parameters.Add("@FechaAlta ", pClimasHistorico.FechaAlta);


                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }


    }
}
