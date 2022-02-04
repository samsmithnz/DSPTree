using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;


namespace DSPTree.Models
{
    public static class ItemPool
    {
        public static Item2 IronOre()
        {
            return new Item2("Iron Ore", "Icon_Iron_Ore.png", 1)
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
            return new Item2("Copper Ore", "Icon_Copper_Ore.png", 1)
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


        public static Item2 IronIngot()
        {
            return new Item2("Iron Ingot", "Icon_Iron_Ingot.png", 2)
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
            return new Item2("Magnet", "Icon_Magnet.png", 2)
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
    }
}
