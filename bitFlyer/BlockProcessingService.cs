using System.Collections.Generic;
using System.Linq;

namespace bitFlyer
{
    public class BlockProcessingService : IBlockProcessingService
    {
        private readonly int _blockSize;

        public BlockProcessingService(int blockSize)
        {
            _blockSize = blockSize;
        }
        /// <summary>
        /// the mechanism of how to build can be always improved
        /// </summary>
        /// <param name="transactions"></param>
        /// <returns></returns>
        public List<Block> BuildBlocks(IEnumerable<Transaction> transactions)
        {
            var blocks = new List<Block>();
            foreach (var transaction in transactions.OrderByDescending(t => t.Rate))
                InsertToBlock(blocks, transaction);
            return blocks;
        }

        private void InsertToBlock(List<Block> blocks, Transaction transaction)
        {
            foreach (var block in blocks)
            {
                if ((block.TotalSize + transaction.Size) < _blockSize)
                {
                    block.AddTransaction(transaction);
                    return;
                }
            }

            var newBlock = new Block();
            newBlock.AddTransaction(transaction);
            blocks.Add(newBlock);
        }
    }
}
