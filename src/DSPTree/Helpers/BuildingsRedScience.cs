using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsRedScience
    {

        public static Item Accumulator()
        {
            return new Item(8, "Accumulator",
                "Icon_Accumulator.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(5,
                        new()
                        {
                            { "Iron Ingot", 6 },
                            { "Super-Magnetic Ring", 1 },
                            { "Crystal Silicon", 6 }
                        },
                        new()
                        {
                            { "Accumulator", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
