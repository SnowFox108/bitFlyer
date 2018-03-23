using System.Collections.Generic;

namespace bitFlyer
{
    public interface IBlockProcessingService
    {
        IEnumerable<Block> BuildBlocks(IEnumerable<Transaction> transactions);
    }
}
