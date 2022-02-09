using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsPreBlueScience
    {

        public static Item TeslaTower()
        {
            return new Item(4, "Tesla Tower",
                "Icon_Tesla_Tower.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Magnetic Coil", 1 },
                            { "Iron Ingot", 2 }
                        },
                        new()
                        {
                            { "Tesla Tower", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item WindTurbine()
        {
            return new Item(4, "Wind Turbine",
                "Icon_Wind_Turbine.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Iron Ingot", 6 },
                            { "Gear", 1 },
                            { "Magnetic Coil", 3 }
                        },
                        new()
                        {
                            { "Wind Turbine", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

    }
}
