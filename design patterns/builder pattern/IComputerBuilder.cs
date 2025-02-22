namespace DesignPatterns.BuilderPattern
{
    public interface IComputerBuilder
    {
        void BuildCPU();
        void BuildRAM();
        void BuildStorage();
        void BuildGPU();
        Computer GetResult();
    }
}