namespace bitFlyer
{
    public class Transaction
    {
        public int Id { get; }
        public int Size { get; }
        public decimal Fee { get; }
        public decimal Rate { get;}

        public Transaction(int id, int size, decimal fee)
        {
            Id = id;
            Size = size;
            Fee = fee;
            Rate = fee / size;
        }
    }
}
