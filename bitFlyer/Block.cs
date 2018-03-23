using System.Collections.Generic;

namespace bitFlyer
{
    public class Block
    {
        public List<Transaction> Transactions { get; }
        public int TotalSize { get; private set; }
        public decimal TotalFee { get; private set; }
        public decimal Reward { get; }
        public Block()
        {
            Transactions = new List<Transaction>();
            Reward = 12.5m;
        }
        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            TotalSize += transaction.Size;
            TotalFee += transaction.Fee;
        }
    }
}
