using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel0
    {
        public static Item IronOreVein()
        {
            return new Item(0, 
                "Iron Ore Vein", 
                "80px-Icon_Iron_Ore_Vein.png",
                ItemType.Item, 
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Iron Ore Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered)
                }
            };
        }

        public static Item CopperOreVein()
        {
            return new Item(0, "Copper Ore Vein",
                "79px-Icon_Copper_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Copper Ore Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item CrudeOilVein()
        {
            return new Item(0, "Crude Oil Vein",
                "90px-Icon_Crude_Oil_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Crude Oil Vein", 1 }
                        },
                        BuildingType.OilExtractor,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item StoneVein()
        {
            return new Item(0, "Stone Vein",
                "85px-Icon_Stone_Ore_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Stone Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item CoalVein()
        {
            return new Item(0, "Coal Vein", 
                "81px-Icon_Coal_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Coal Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item TitaniumOreVein()
        {
            return new Item(0, "Titanium Ore Vein",
                "80px-Icon_Titanium_Ore_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Titanium Ore Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item SiliconOreVein()
        {
            return new Item(1, "Silicon Ore Vein",
                "80px-Icon_Silicon_Ore_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Silicon Ore Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item UnipolarMagnetVein()
        {
            return new Item(1, "Unipolar Magnet Vein",
                "90px-Icon_Unipolar_Magnet_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Unipolar Magnet Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item KimberliteOreVein()
        {
            return new Item(1, "Kimberlite Ore Vein",
                "85px-Icon_Kimberlite_Ore_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Kimberlite Ore Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item FractalSiliconVein()
        {
            return new Item(1, "Fractal Silicon Vein",
                "85px-Icon_Fractal_Silicon_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Fractal Silicon Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item OpticalGratingRock()
        {
            return new Item(1, "Optical Grating Rock",
                "90px-Icon_Optical_Grating_Rock.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Optical Grating Rock", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item SpiniformStalagmiteCrystalVein()
        {
            return new Item(1, "Spiniform Stalagmite Crystal Vein",
                "87px-Icon_Spiniform_Stalagmite_Crystal_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Spiniform Stalagmite Crystal Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item FireIceVein()
        {
            return new Item(1, "Fire Ice Vein",
                "85px-Icon_Fire_Ice_Vein.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new(),
                        new()
                        {
                            { "Fire Ice Vein", 1 }
                        },
                        BuildingType.MiningMachine,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item Log()
        {
            return new Item(1, "Log",
                "Icon_Log.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new(),
                        new()
                        {
                            { "Log", 1 }
                        },
                        BuildingType.None,
                        MethodType.Gathered
                    )
                }
            };
        }

        public static Item PlantFuel()
        {
            return new Item(1, "Plant Fuel",
                "Icon_Plant_Fuel.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new(),
                        new()
                        {
                            { "PlantFuel", 1 }
                        },
                        BuildingType.None,
                        MethodType.Gathered
                    )
                }
            };
        }

    }
}
