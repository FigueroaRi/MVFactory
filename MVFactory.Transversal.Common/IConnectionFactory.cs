
using System.Data;

namespace MVFactory.Transversal.Common
{
   public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
