using System.Collections.Generic;

namespace bitFlyer
{
    public interface IReadFileService
    {
        IEnumerable<Transaction> Read();
    }
}
