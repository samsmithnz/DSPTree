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

    }
}
