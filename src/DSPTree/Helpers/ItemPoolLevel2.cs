using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel2
    {
             //Level 2
        public static Item IronIngot()
        {
            return new Item(2, "Iron Ingot", "Icon_Iron_Ingot.png")
            {
                Recipes =
                {
                    new Recipe(1,
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

        public static Item Magnet()
        {
            return new Item(2, "Magnet", "Icon_Magnet.png")
            {
                Recipes =
                {
                    new Recipe(1.5m,
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
        public static Item CopperIngot()
        {
            return new Item(2, "Copper Ingot", "Icon_Copper_Ingot.png")
            {
                Recipes =
                {
                    new Recipe(1,
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
        public static Item RefinedOil()
        {
            return new Item(2, "Refined Oil", "Icon_Refined_Oil.png")
            {
                Recipes =
                {
                    new Recipe(1,
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
        public static Item Hydrogen()
        {
            return new Item(2, "Hydrogen", "Icon_Hydrogen.png")
            {
                Recipes =
                {
                    new Recipe(1,
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

        public static Item EnergeticGraphite()
        {
            return new Item(2, "Energetic Graphite", "Icon_Energetic_Graphite.png")
            {
                Recipes =
                {
                    new Recipe(1,
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

        public static Item TitaniumIngot()
        {
            return new Item(2, "Titanium Ingot", "Icon_Titanium_Ingot.png")
            {
                Recipes =
                {
                    new Recipe(1,
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

        public static Item StoneBrick()
        {
            return new Item(2, "Stone Brick", "Icon_Stone_Brick.png")
            {
                Recipes =
                {
                    new Recipe(1,
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
    }
}
