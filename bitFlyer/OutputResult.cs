using System;
using System.Collections.Generic;
using System.Linq;

namespace bitFlyer
{
    public class OutputResult : IOutputResult
    {

        public void Execute(IEnumerable<Block> blocks)
        {
            var result = blocks.First(b => b.TotalFee == blocks.Max(m => m.TotalFee));
            Console.WriteLine($"Answer is {result.TotalFee + result.Reward}");
        }
    }
}
