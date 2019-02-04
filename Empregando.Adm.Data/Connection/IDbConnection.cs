using System.Data.Common;

namespace Empregando.Data
{
    public class IDbConnection
    {
        public DbConnection Conn { get; }
    }
}