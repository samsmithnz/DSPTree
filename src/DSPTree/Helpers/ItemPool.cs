using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

//TODO: Add in the veins (level 0?)
namespace DSPTree.Helpers
{
    public static class ItemPool
    {
        public static Item2 IronOre()
        {
            return new Item2(1, "Iron Ore", "Icon_Iron_Ore.png")
            {
                Recipes =
                {
                    new Recipe2(2,
                        new()
                        {
                            { "Iron Ore Vein", 1 }
                        },
                        new()
                        {
                            { "Iron Ore", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered)
                }
            };
        }

        public static Item2 CopperOre()
        {
            return new Item2(1, "Copper Ore", "Icon_Copper_Ore.png")
            {
                Recipes =
                {
                    new Recipe2(2,
                        new()
                        {
                            { "Copper Ore Vein", 1 }
                        },
                        new()
                        {
                            { "Copper Ore", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }
        public static Item2 Water()
        {
            return new Item2(1, "Water", "Icon_Water.png")
            {
                Recipes =
                {
                    new Recipe2(2,
                        new()
                        {
                            { "Water Source", 1 }
                        },
                        new()
                        {
                            { "Water", 1 }
                        },
                        BuildingType.WaterPump,
                        MethodType.Gathered
                    )
                }
            };
        }
        public static Item2 CrudeOil()
        {
            return new Item2(1, "Crude Oil", "Icon_Crude_Oil.png")
            {
                Recipes =
                {
                    new Recipe2(2,
                        new()
                        {
                            { "Oil Source", 1 }
                        },
                        new()
                        {
                            { "Crude Oil", 1 }
                        },
                        BuildingType.OilExtractor,
                        MethodType.Gathered
                    )
                }
            };
        }
        public static Item2 Stone()
        {
            return new Item2(1, "Stone", "Icon_Stone.png")
            {
                Recipes =
                {
                    new Recipe2(2,
                        new()
                        {
                            { "Stone Vein", 1 }
                        },
                        new()
                        {
                            { "Stone", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }
        public static Item2 Coal()
        {
            return new Item2(1, "Coal", "Icon_Coal.png")
            {
                Recipes =
                {
                    new Recipe2(2,
                        new()
                        {
                            { "Coal Vein", 1 }
                        },
                        new()
                        {
                            { "Coal", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item2 TitaniumOre()
        {
            return new Item2(1, "Titanium Ore", "Icon_Titanium_Ore.png")
            {
                Recipes =
                {
                    new Recipe2(2,
                        new()
                        {
                            { "Titanium Ore Vein", 1 }
                        },
                        new()
                        {
                            { "Titanium Ore", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item2 SiliconOre()
        {
            return new Item2(1, "Silicon Ore", "Icon_Silicon_Ore.png")
            {
                Recipes =
                {
                    new Recipe2(2,
                        new()
                        {
                            { "Silicon Ore Vein", 1 }
                        },
                        new()
                        {
                            { "Silicon Ore", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    ),
                    new Recipe2(2,
                        new()
                        {
                            { "Stone", 10 }
                        },
                        new()
                        {
                            { "Silicon Ore", 1 }
                        },
                        BuildingType.Smelter,
                        MethodType.Manufactured,
                        false
                    )
                }
            };
        }

        //Level 2
        public static Item2 IronIngot()
        {
            return new Item2(2, "Iron Ingot", "Icon_Iron_Ingot.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Iron Ore", 1 }
                        },
                        new()
                        {
                            {"Iron Ingot",1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }

        public static Item2 Magnet()
        {
            return new Item2(2, "Magnet", "Icon_Magnet.png")
            {
                Recipes =
                {
                    new Recipe2(1.5m,
                        new()
                        {
                            { "Iron Ore", 1 }
                        },
                        new()
                        {
                            {"Magnet",1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }
        public static Item2 CopperIngot()
        {
            return new Item2(2, "Copper Ingot", "Icon_Copper_Ingot.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Copper Ore", 1 }
                        },
                        new()
                        {
                            {"Copper Ingot",1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }
        public static Item2 RefinedOil()
        {
            return new Item2(2, "Refined Oil", "Icon_Refined_Oil.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Crude Oil", 1 }
                        },
                        new()
                        {
                            {"Refined Oil",1 }
                        },
                        BuildingType.OilRefinery)
                }
            };
        }
        public static Item2 Hydrogen()
        {
            return new Item2(2, "Hydrogen", "Icon_Hydrogen.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Crude Oil", 2 }
                        },
                        new()
                        {
                            {"Hydrogen",1 }
                        },
                        BuildingType.OilRefinery)
                }
            };
        }

        public static Item2 EnergeticGraphite()
        {
            return new Item2(2, "Energetic Graphite", "Icon_Energetic_Graphite.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Coal", 1 }
                        },
                        new()
                        {
                            {"Energetic Graphite",1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }

        public static Item2 TitaniumIngot()
        {
            return new Item2(2, "Titanium Ingot", "Icon_Energetic_Graphite.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Titanium Ore", 2 }
                        },
                        new()
                        {
                            { "Titanium Ingot",1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }

        public static Item2 StoneBrick()
        {
            return new Item2(2, "Stone Brick", "Icon_Stone_Brick.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Stone", 1 }
                        },
                        new()
                        {
                            { "Stone Brick",1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }

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

        //Level 4
        public static Item2 ElectromagneticMatrix()
        {
            return new Item2(4, "Electromagnetic Matrix", "Icon_Electromagnetic_Matrix.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Magnetic Coil", 10 },
                            { "Circuit Board", 10 }
                        },
                        new()
                        {
                            { "Electromagnetic Matrix", 1 }
                        },
                        BuildingType.MatrixLab)
                }
            };
        }

        public static Item2 ElectricMotor()
        {
            return new Item2(4, "Electric Motor", "Icon_Electric_Motor.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "Magnetic Coil", 1 },
                            { "Gear", 1 },
                            { "Iron Ingot", 2 }
                        },
                        new()
                        {
                            { "Electric Motor", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
