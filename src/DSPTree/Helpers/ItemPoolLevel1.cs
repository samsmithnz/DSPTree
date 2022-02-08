using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel1
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
                        BuildingType.MiningMachine)
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
                        BuildingType.MiningMachine)
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
                        BuildingType.MiningMachine)
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
                        BuildingType.MiningMachine)
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
                        BuildingType.MiningMachine)
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
                        BuildingType.MiningMachine
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
     
    }
}
