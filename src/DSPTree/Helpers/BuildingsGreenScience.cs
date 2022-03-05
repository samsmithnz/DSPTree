using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsGreenScience
    {

        public static Item ArtificialStar()
        {
            return new Item(8, "Artificial Star",
                "Icon_Artificial_Star.png",
                ItemType.Building,
                ResearchType.GreenScience)
            {
                Recipes =
                {
                    new Recipe(30,
                        new()
                        {
                            { "Titanium Alloy", 20 },
                            { "Frame Material", 20 },
                            { "Annihilation Constraint Sphere", 40 },
                            { "Quantum Chip", 10 },
                        },
                        new()
                        {
                            { "Artificial Star", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item AdvancedMiningMachine()
        {
            return new Item(8, "Advanced Mining Machine",
                "Advanced_Mining_Machine.png",
                ItemType.Building,
                ResearchType.GreenScience)
            {
                Recipes =
                {
                    new Recipe(20,
                        new()
                        {
                            { "Titanium Alloy", 20 },
                            { "Frame Material", 10 },
                            { "Super-Magnetic Ring", 10 },
                            { "Quantum Chip", 4 },
                            { "Optical Grating Crystal", 40 }
                        },
                        new()
                        {
                            { "Advanced Mining Machine", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
