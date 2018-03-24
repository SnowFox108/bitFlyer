using System.Collections.Generic;

namespace bitFlyer
{
    public interface IOutputResult
    {
        void Execute(List<Block> blocks);
    }
}
