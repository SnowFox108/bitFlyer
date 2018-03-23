using System.Collections.Generic;

namespace bitFlyer
{
    public class BlockProcessingService : IBlockProcessingService
    {
        private readonly int _blockSize;

        public BlockProcessingService(int blockSize)
        {
            _blockSize = blockSize;
        }

        public IEnumerable<Block> BuildBlocks(IEnumerable<Transaction> transactions)
        {
            var blocks = new List<Block>();
            foreach (var transaction in transactions)
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
