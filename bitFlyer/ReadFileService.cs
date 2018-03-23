using System.Collections.Generic;

namespace bitFlyer
{    
    public class ReadFileService : IReadFileService
    {
        /// <summary>
        /// This can be changed to read from txt file or any other source
        /// </summary>
        /// <returns>IEnumerable Transaction</returns>
        public IEnumerable<Transaction> Read()
        {
            yield return new Transaction(1, 57247, 0.0887m);
            yield return new Transaction(2, 98732, 0.1856m);
            yield return new Transaction(3, 134928, 0.2307m);
            yield return new Transaction(4, 77275, 0.1522m);
            yield return new Transaction(5, 29240, 0.0532m);
            yield return new Transaction(6, 15440, 0.0250m);
            yield return new Transaction(7, 70820, 0.1409m);
            yield return new Transaction(8, 139603, 0.2541m);
            yield return new Transaction(9, 63718, 0.1147m);
            yield return new Transaction(10, 143807, 0.2660m);
            yield return new Transaction(11, 190457, 0.2933m);
            yield return new Transaction(12, 40572, 0.0686m);
        }
    }
}
