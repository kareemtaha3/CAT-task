using System;

namespace DesignPatterns.BuilderPattern
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GPU { get; set; }

        public void DisplayConfiguration()
        {
            Console.WriteLine("\nComputer Configuration:");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
            Console.WriteLine($"GPU: {GPU}");
        }
    }
}