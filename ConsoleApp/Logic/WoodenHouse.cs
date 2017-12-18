using ConsoleApp.Logic.Interfaces;

namespace ConsoleApp.Logic
{
    class WoodenHouse : IHouse
    {
        public void Build()
        {
            System.Console.WriteLine("Wooden house is being built");
        }
    }
}
