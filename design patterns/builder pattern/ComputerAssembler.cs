namespace DesignPatterns.BuilderPattern
{
    public class ComputerAssembler
    {
        private IComputerBuilder _builder;

        public void SetBuilder(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructComputer()
        {
            _builder.BuildCPU();
            _builder.BuildRAM();
            _builder.BuildStorage();
            _builder.BuildGPU();
        }

        public Computer GetComputer()
        {
            return _builder.GetResult();
        }
    }
}