using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsPurpleScience
    {

        public static Item AssemblingMachineMkIII()
        {
            return new Item(8, "Assembling Machine Mk.III",
                "Icon_Assembling_Machine_Mk.III.png",
                ItemType.Building,
                ResearchType.PurpleScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Assembling Machine Mk.II", 2 },
                            { "Particle Broadband", 8},
                            { "Quantum Chip", 2 },
                        },
                        new()
                        {
                            { "Assembling Machine Mk.III", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item PlaneSmelter()
        {
            return new Item(8, "Plane Smelter",
                "Icon_Plane_Smelter.png",
                ItemType.Building,
                ResearchType.PurpleScience)
            {
                Recipes =
                {
                    new Recipe(5,
                        new()
                        {
                            { "Arc Smelter", 1 },
                            { "Frame Material", 5},
                            { "Plane Filter", 4 },
                            { "Unipolar Magnet", 15 }
                        },
                        new()
                        {
                            { "Plane Smelter", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
