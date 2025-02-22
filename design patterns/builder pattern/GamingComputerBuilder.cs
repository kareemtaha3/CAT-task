namespace DesignPatterns.BuilderPattern
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void BuildCPU()
        {
            _computer.CPU = "Intel Core i9";
        }

        public void BuildRAM()
        {
            _computer.RAM = "32GB DDR4";
        }

        public void BuildStorage()
        {
            _computer.Storage = "2TB NVMe SSD";
        }

        public void BuildGPU()
        {
            _computer.GPU = "NVIDIA RTX 4080";
        }

        public Computer GetResult()
        {
            return _computer;
        }
    }
}