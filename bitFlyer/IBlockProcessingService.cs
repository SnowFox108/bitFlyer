using System.Collections.Generic;

namespace bitFlyer
{
    public interface IBlockProcessingService
    {
        List<Block> BuildBlocks(IEnumerable<Transaction> transactions);
    }
}
