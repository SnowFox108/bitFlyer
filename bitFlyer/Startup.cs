namespace bitFlyer
{
    public class Startup
    {
        private readonly IReadFileService _readFileService;
        private readonly IBlockProcessingService _blockProcessingService;
        private readonly IOutputResult _outputResult;

        public Startup(IReadFileService readFileService, IBlockProcessingService blockProcessingService, IOutputResult outputResult)
        {
            _readFileService = readFileService;
            _blockProcessingService = blockProcessingService;
            _outputResult = outputResult;
        }

        public void Run()
        {
            var input = _readFileService.Read();
            var blocks = _blockProcessingService.BuildBlocks(input);
            _outputResult.Execute(blocks);
        }
        
    }
}
