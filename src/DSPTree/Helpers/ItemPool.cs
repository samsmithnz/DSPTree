using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;


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
    }
}
