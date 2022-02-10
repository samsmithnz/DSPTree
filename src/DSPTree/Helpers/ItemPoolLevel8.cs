using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel8
    {
        //Level 8
        public static Item GravitonLens()
        {
            return new Item(8, "Graviton Lens",
                "Icon_Graviton_Lens.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(6,
                        new()
                        {
                            { "Diamond", 4 },
                            { "Strange Matter", 1 }
                        },
                        new()
                        {
                            { "Graviton Lens", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item QuantumChip()
        {
            return new Item(8, "Quantum Chip", 
                "Icon_Quantum_Chip.png",
                ItemType.Item,
                ResearchType.PurpleScience)
            {
                Recipes =
                {
                    new Recipe(6,
                        new()
                        {
                            { "Processor", 2 },
                            { "Plane Filter", 2 }
                        },
                        new()
                        {
                            { "Quantum Chip", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item DysonSphereComponent()
        {
            return new Item(8, "Dyson Sphere Component",
                "Icon_Dyson_Sphere_Component.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(8,
                        new()
                        {
                            { "Frame Material", 3 },
                            { "Solar Sail", 3 },
                            { "Processor", 3 }
                        },
                        new()
                        {
                            { "Dyson Sphere Component", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

    }

}
