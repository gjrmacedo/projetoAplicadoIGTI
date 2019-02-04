namespace Empregando.Data
{
    public abstract class BaseRepository
    {
        protected IDbConnection Connection { get; }

        public BaseRepository(IDbConnection connection)
        {
            Connection = connection;
        }
    }
}
