using System;
using Dapper;
using MVFactory.Domain.Entity;
using MVFactory.Transversal.Common;
using MVFactory.Infraestructura.Interfaces;
using System.Data;

namespace MVFactory.Infraestructura.Repository
{
    public class UsersRepository:IUsersRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public UsersRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public Users Authenticate(string userName, string password)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsersGetByUserAndPassword";
                var parameters = new DynamicParameters();
                parameters.Add("UserName", userName);
                parameters.Add("Password", password);

                var user = connection.QuerySingle<Users>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return user;
            }
        }
    }
}
