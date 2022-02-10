using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsPreBlueScience
    {
        public static Item SorterMkI()
        {
            return new Item(4, "Sorter Mk.I",
                "Icon_Sorter_Mk.I.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Iron Ingot", 1 },
                            { "Circuit Board", 1 }
                        },
                        new()
                        {
                            { "Sorter Mk.I", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item AssemblingMachineMkI()
        {
            return new Item(4, "Assembling Machine Mk.I",
                "Icon_Assembling_Machine_Mk.I.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Iron Ingot", 4 },
                            { "Gear", 8 },
                            { "Circuit Board", 4 }
                        },
                        new()
                        {
                            { "Assembling Machine Mk.I", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

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

        public static Item MiningMachine()
        {
            return new Item(4, "Mining Machine",
                "Icon_Mining_Machine.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(3,
                        new()
                        {
                            { "Iron Ingot", 4 },
                            { "Circuit Board", 1 },
                            { "Magnetic Coil", 2 },
                            { "Gear", 2 }
                        },
                        new()
                        {
                            { "Mining Machine", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item ArcSmelter()
        {
            return new Item(4, "Arc Smelter",
                "Icon_Arc_Smelter.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(3,
                        new()
                        {
                            { "Iron Ingot", 4 },
                            { "Stone Brick", 2 },
                            { "Circuit Board", 4 },
                            { "Magnetic Coil", 2 }
                        },
                        new()
                        {
                            { "Arc Smelter", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item StorageMkI()
        {
            return new Item(3, "Storage Mk.I",
                "Icon_Storage_Mk.I.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Iron Ingot", 4 },
                            { "Stone Brick", 4 }
                        },
                        new()
                        {
                            { "Storage Mk.I", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item MatrixLab()
        {
            return new Item(4, "Matrix Lab",
                "Icon_Matrix_Lab.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(3,
                        new()
                        {
                            { "Iron Ingot", 8 },
                            { "Glass", 4 },
                            { "Circuit Board", 4 },
                            { "Magnetic Coil", 4 }
                        },
                        new()
                        {
                            { "Matrix Lab", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

    }
}
