using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Microsoft.EntityFrameworkCore
{
    internal class ServerVersion
    {
        internal static Action<MySqlDbContextOptionsBuilder> Parse(string v)
        {
            throw new NotImplementedException();
        }
    }
}