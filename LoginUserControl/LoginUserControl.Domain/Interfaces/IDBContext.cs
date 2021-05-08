using System.Data;

namespace LoginUserControl.Domain.Interfaces
{
    public  interface IDBContext
    {
        IDbConnection Connection { get; }
    }
}
