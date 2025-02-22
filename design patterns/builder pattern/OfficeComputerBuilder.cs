namespace DesignPatterns.BuilderPattern
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void BuildCPU()
        {
            _computer.CPU = "Intel Core i5";
        }

        public void BuildRAM()
        {
            _computer.RAM = "16GB DDR4";
        }

        public void BuildStorage()
        {
            _computer.Storage = "512GB SSD";
        }

        public void BuildGPU()
        {
            _computer.GPU = "Intel Integrated Graphics";
        }

        public Computer GetResult()
        {
            return _computer;
        }
    }
}