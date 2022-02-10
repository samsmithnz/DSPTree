using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel3
    {
        //Level 3
        public static Item MagneticCoil()
        {
            return new Item(3, "Magnetic Coil",
                "Icon_Magnetic_Coil.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Magnet", 2 },
                            { "Copper Ingot", 1 }
                        },
                        new()
                        {
                            { "Magnetic Coil", 2 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
        public static Item CircuitBoard()
        {
            return new Item(3, "Circuit Board",
                "Icon_Circuit_Board.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Iron Ingot", 1 },
                            { "Copper Ingot", 1 }
                        },
                        new()
                        {
                            { "Circuit Board", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
        public static Item Steel()
        {
            return new Item(3, "Steel",
                "Icon_Steel.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Iron Ingot", 1 }
                        },
                        new()
                        {
                            { "Steel", 1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }

        public static Item Gear()
        {
            return new Item(3, "Gear",
                "Icon_Gear.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Iron Ingot", 1 }
                        },
                        new()
                        {
                            { "Gear", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item SulfuricAcid()
        {
            return new Item(3, "Sulfuric Acid",
                "Icon_Sulfuric_Acid.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Water", 1 },
                            { "Stone", 2 },
                            { "Refined Oil", 2 }
                        },
                        new()
                        {
                            { "Sulfuric Acid", 2 }
                        },
                        BuildingType.ChemicalPlant)
                }
            };
        }

        public static Item EnergyMatrix()
        {
            return new Item(3, "Energy Matrix",
                "Icon_Energy_Matrix.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Energetic Graphite", 2 },
                            { "Hydrogen", 2 }
                        },
                        new()
                        {
                            { "Energy Matrix", 1 }
                        },
                        BuildingType.MatrixLab)
                }
            };
        }

        public static Item Glass()
        {
            return new Item(3, "Glass",
                "Icon_Glass.png",
                ItemType.Item,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Stone", 2 }
                        },
                        new()
                        {
                            { "Glass", 1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }

        public static Item HighPuritySilicon()
        {
            return new Item(3, "High-Purity Silicon",
                "Icon_High-Purity_Silicon.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Silicon Ore", 2 }
                        },
                        new()
                        {
                            { "High-Purity Silicon", 1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }


        public static Item HydrogenFuelRod()
        {
            return new Item(3, "Hydrogen Fuel Rod",
                "Icon_Hydrogen_Fuel_Rod.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Titanium Ingot", 1 },
                            { "Hydrogen", 10 }
                        },
                        new()
                        {
                            { "Hydrogen Fuel Rod", 2 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item Diamond()
        {
            return new Item(3, "Diamond",
                "Icon_Diamond.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Energetic Graphite", 1 }
                        },
                        new()
                        {
                            { "Diamond", 1 }
                        },
                        BuildingType.Smelter),
                    new Recipe(1.5m,
                        new()
                        {
                            { "Kimberlite Ore", 1 }
                        },
                        new()
                        {
                            { "Diamond", 2 }
                        },
                        BuildingType.Smelter,
                        ManufactoringMethodType.Manufactured,
                        false)
                }
            };
        }

        public static Item Plastic()
        {
            return new Item(3, "Plastic",
                "Icon_Plastic.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Energetic Graphite", 1 },
                            { "Refined Oil", 2 }
                        },
                        new()
                        {
                            { "Plastic", 1 }
                        },
                        BuildingType.ChemicalPlant)
                }
            };
        }

        public static Item Deuterium()
        {
            return new Item(3, "Deuterium",
                "Icon_Deuterium.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Hydrogen", 100 }
                        },
                        new()
                        {
                            { "Deuterium", 1 },
                            { "Hydrogen", 99 }
                        },
                        BuildingType.Fractionator),
                    new Recipe(2.5m,
                        new()
                        {
                            { "Hydrogen", 10 }
                        },
                        new()
                        {
                            { "Deuterium", 5 }
                        },
                        BuildingType.MiniatureParticleCollider,
                        ManufactoringMethodType.Manufactured,
                        false)
                }
            };
        }

    }
}
