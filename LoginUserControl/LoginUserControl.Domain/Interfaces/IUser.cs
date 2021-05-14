using System.Collections.Generic;
using System.Security.Claims;

namespace LoginUserControl.Core.Interfaces
{
    public interface IUser
    {
        string Nome { get; }
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
