using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel3
    {
              //Level 3
        public static Item2 MagneticCoil()
        {
            return new Item2(3, "Magnetic Coil", "Icon_Magnetic_Coil.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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
        public static Item2 CircuitBoard()
        {
            return new Item2(3, "Circuit Board", "Icon_Circuit_Board.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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
        public static Item2 Steel()
        {
            return new Item2(3, "Steel", "Icon_Steel.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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

        public static Item2 Gear()
        {
            return new Item2(3, "Gear", "Icon_Gear.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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

        public static Item2 SulfuricAcid()
        {
            return new Item2(3, "Sulfuric Acid", "Icon_Sulfuric_Acid.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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

        public static Item2 EnergyMatrix()
        {
            return new Item2(3, "Energy Matrix", "Icon_Energy_Matrix.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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

        public static Item2 Glass()
        {
            return new Item2(3, "Glass", "Icon_Glass.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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

        public static Item2 HighPuritySilicon()
        {
            return new Item2(3, "High-Purity Silicon", "Icon_High-Purity_Silicon.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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


        public static Item2 HydrogenFuelRod()
        {
            return new Item2(3, "Hydrogen Fuel Rod", "Icon_Hydrogen_Fuel_Rod.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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

        public static Item2 Diamond()
        {
            return new Item2(3, "Diamond", "Icon_Diamond.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Energetic Graphite", 1 }
                        },
                        new()
                        {
                            { "Diamond", 1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }

        public static Item2 Plastic()
        {
            return new Item2(3, "Plastic", "Icon_Plastic.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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

    }
}
