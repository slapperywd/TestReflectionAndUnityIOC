using ConsoleApp.Logic.Interfaces;

namespace ConsoleApp.Logic
{
    class ModernHouse : IHouse
    {
        public void Build()
        {
            System.Console.WriteLine("Modern house is being built");
        }
    }
}
