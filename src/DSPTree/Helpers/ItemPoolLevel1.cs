using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel1
    {
        public static Item IronOre()
        {
            return new Item(1, "Iron Ore",
                "Icon_Iron_Ore.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Iron Ore Vein", 1 }
                        },
                        new()
                        {
                            { "Iron Ore", 1 }
                        },
                        BuildingType.MiningMachine)
                }
            };
        }

        public static Item CopperOre()
        {
            return new Item(1, "Copper Ore",
                "Icon_Copper_Ore.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Copper Ore Vein", 1 }
                        },
                        new()
                        {
                            { "Copper Ore", 1 }
                        },
                        BuildingType.MiningMachine)
                }
            };
        }

        public static Item Water()
        {
            return new Item(1, "Water",
                "Icon_Water.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(2,
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

        public static Item CrudeOil()
        {
            return new Item(1, "Crude Oil",
                "Icon_Crude_Oil.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Crude Oil Vein", 1 }
                        },
                        new()
                        {
                            { "Crude Oil", 1 }
                        },
                        BuildingType.OilExtractor)
                }
            };
        }
        public static Item Stone()
        {
            return new Item(1, "Stone",
                "Icon_Stone.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Stone Vein", 1 }
                        },
                        new()
                        {
                            { "Stone", 1 }
                        },
                        BuildingType.MiningMachine)
                }
            };
        }
        public static Item Coal()
        {
            return new Item(1, "Coal",
                "Icon_Coal.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Coal Vein", 1 }
                        },
                        new()
                        {
                            { "Coal", 1 }
                        },
                        BuildingType.MiningMachine)
                }
            };
        }

        public static Item TitaniumOre()
        {
            return new Item(1, "Titanium Ore",
                "Icon_Titanium_Ore.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Titanium Ore Vein", 1 }
                        },
                        new()
                        {
                            { "Titanium Ore", 1 }
                        },
                        BuildingType.MiningMachine)
                }
            };
        }

        public static Item SiliconOre()
        {
            return new Item(1, "Silicon Ore",
                "Icon_Silicon_Ore.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Silicon Ore Vein", 1 }
                        },
                        new()
                        {
                            { "Silicon Ore", 1 }
                        },
                        BuildingType.MiningMachine
                    ),
                    new Recipe(2,
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

        public static Item UnipolarMagnet()
        {
            return new Item(1, "Unipolar Magnet",
                "Icon_Unipolar_Magnet.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Unipolar Magnet Vein", 1 }
                        },
                        new()
                        {
                            { "Unipolar Magnet", 1 }
                        },
                        BuildingType.MiningMachine
                    )
                }
            };
        }

        public static Item KimberliteOre()
        {
            return new Item(1, "Kimberlite Ore",
                "Icon_Kimberlite_Ore.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Kimberlite Ore Vein", 1 }
                        },
                        new()
                        {
                            { "Kimberlite Ore", 1 }
                        },
                        BuildingType.MiningMachine
                    )
                }
            };
        }

        public static Item FractalSilicon()
        {
            return new Item(1, "Fractal Silicon",
                "Icon_Fractal_Silicon.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Fractal Silicon Vein", 1 }
                        },
                        new()
                        {
                            { "Fractal Silicon", 1 }
                        },
                        BuildingType.MiningMachine
                    )
                }
            };
        }

        public static Item OpticalGratingCrystal()
        {
            return new Item(1, "Optical Grating Crystal",
                "Icon_Optical_Grating_Crystal.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Optical Grating Rock", 1 }
                        },
                        new()
                        {
                            { "Optical Grating Crystal", 1 }
                        },
                        BuildingType.MiningMachine
                    )
                }
            };
        }

        public static Item SpiniformStalagmiteCrystal()
        {
            return new Item(1, "Spiniform Stalagmite Crystal",
                "Icon_Spiniform_Stalagmite_Crystal.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Spiniform Stalagmite Crystal Vein", 1 }
                        },
                        new()
                        {
                            { "Spiniform Stalagmite Crystal", 1 }
                        },
                        BuildingType.MiningMachine
                    )
                }
            };
        }

        public static Item FireIce()
        {
            return new Item(1, "Fire Ice",
                "Icon_Fire_Ice.png",
                ItemType.Item,
                ResearchType.NoScience)
            {
                Recipes =
                {
                    new Recipe(2,
                      new()
                        {
                            { "Fire Ice Vein", 1 }
                        },
                        new()
                        {
                            { "Fire Ice", 1 }
                        },
                        BuildingType.MiningMachine
                    )
                }
            };
        }

        public static Item CriticalPhoton()
        {
            return new Item(1, "Critical Photon",
                "Icon_Critical_Photon.png",
                ItemType.Item,
                ResearchType.GreenScience)
            {
                Recipes =
                {
                    new Recipe(10,
                        new(),
                        new()
                        {
                            { "Critical Photon", 1 }
                        },
                        BuildingType.RayReceiver,
                        MethodType.Manufactured
                    )
                }
            };
        }

    }
}
