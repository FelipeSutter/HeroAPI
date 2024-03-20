using Repository.Contracts;
using System.Data;
using System.Data.SqlClient;

namespace Repository.Connection
{
    public class DefaultSqlConnectionFactory : IConnectionFactory
    {
        public IDbConnection Connection()
        {
            throw new NotImplementedException();
        }
    }
}
