using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsEarlyGame
    {
        public static Item SolarPanel()
        {
            return new Item(4, "Solar Panel", "Icon_Solar_Panel.png",
                ItemType.Building)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Magnetic Coil", 1 },
                            { "Gear", 1 },
                            { "Iron Ingot", 2 }
                        },
                        new()
                        {
                            { "Solar Panel", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
