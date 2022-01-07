using Engine.Models;

namespace Engine.Factories;

internal class WorldFactory
{
    internal World CreateWorld()
    {
        World newWorld = new World();
        
        newWorld.AddLocation(-2, -1, "Farmer's Field",
            "There are two rows of corn growing here, with giant rats hiding behind them.",
            "/Images/Locations/FarmFields.png");
        newWorld.AddLocation(-1, -1, "Farmer's House",
            "This is the house of your neighbor, Farmer Ted.",
            "/Images/Locations/Farmhouse.png");
        newWorld.AddLocation(0, -1, "Home",
            "This is your home",
            "/Images/Locations/Home.png");
        
        return newWorld;
    }
}