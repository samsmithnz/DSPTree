using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;


namespace DSPTree.Models
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
    }
}
