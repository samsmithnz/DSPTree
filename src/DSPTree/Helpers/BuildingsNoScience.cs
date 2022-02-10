using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsNoScience
    {

        public static Item ConveyorBeltMkI()
        {
            return new Item(1, "Conveyor Belt Mk.I",
                "Icon_Conveyor_Belt_Mk.I.png",
                ItemType.Building,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Iron Ingot", 2 },
                            { "Gear", 1 }
                        },
                        new()
                        {
                            { "Conveyor Belt Mk.I", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

    }
}
