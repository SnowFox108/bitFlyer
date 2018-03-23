using System.Collections.Generic;

namespace bitFlyer
{
    public interface IOutputResult
    {
        void Execute(IEnumerable<Block> blocks);
    }
}
