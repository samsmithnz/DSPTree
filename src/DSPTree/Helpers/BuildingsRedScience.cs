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

        public static Item StorageMkII()
        {
            return new Item(8, "Storage Mk.II",
                "Icon_Storage_Mk.II.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Iron Ingot", 8 },
                            { "Stone Brick", 8 }
                        },
                        new()
                        {
                            { "Storage Mk.II", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item ConveyorBeltMkII()
        {
            return new Item(8, "Conveyor Belt Mk.II",
                "Icon_Conveyor_Belt_Mk.II.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Conveyor Belt Mk.I", 3 },
                            { "Electromagnetic Turbine", 1 }
                        },
                        new()
                        {
                            { "Conveyor Belt Mk.II", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
