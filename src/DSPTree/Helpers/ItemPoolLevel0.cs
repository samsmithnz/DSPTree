using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel0
    {
        public static Item2 IronOreVein()
        {
            return new Item2(0, "Iron Ore Vein", "80px-Icon_Iron_Ore_Vein.png")
            {
                Recipes =
                {
                    new Recipe2(2,
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

        public static Item2 CopperOreVein()
        {
            return new Item2(0, "Copper Ore Vein", "79px-Icon_Copper_Vein.png")
            {
                Recipes =
                {
                    new Recipe2(2,
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

        public static Item2 CrudeOilVein()
        {
            return new Item2(0, "Crude Oil Vein", "90px-Icon_Crude_Oil_Vein.png")
            {
                Recipes =
                {
                    new Recipe2(2,
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

        public static Item2 StoneVein()
        {
            return new Item2(0, "Stone Vein", "85px-Icon_Stone_Ore_Vein.png")
            {
                Recipes =
                {
                    new Recipe2(2,
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

        public static Item2 CoalVein()
        {
            return new Item2(0, "Coal Vein", "81px-Icon_Coal_Vein.png")
            {
                Recipes =
                {
                    new Recipe2(2,
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

        public static Item2 TitaniumOreVein()
        {
            return new Item2(0, "Titanium Ore Vein", "80px-Icon_Titanium_Ore_Vein.png")
            {
                Recipes =
                {
                    new Recipe2(2,
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

        public static Item2 SiliconOreVein()
        {
            return new Item2(1, "Silicon Ore Vein", "80px-Icon_Silicon_Ore_Vein.png")
            {
                Recipes =
                {
                    new Recipe2(2,
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

    }
}
