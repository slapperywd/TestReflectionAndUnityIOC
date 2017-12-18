using ConsoleApp.Logic.Interfaces;

namespace ConsoleApp.Logic
{
    public class HouseBuilder
    {
        IHouse house;
        public HouseBuilder(IHouse house)
        {
            this.house = house;
        }

        public void Build()
        {
            house.Build();
        }
    }
}
