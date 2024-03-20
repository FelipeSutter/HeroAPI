using System.Data;

namespace Repository.Contracts
{
    public interface IConnectionFactory
    {
        IDbConnection Connection();
    }
}
