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
            return new Item(2, "Iron Ingot",
                "Icon_Iron_Ingot.png",
                ItemType.Item,
                ResearchType.NoScience)
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
            return new Item(2, "Magnet",
                "Icon_Magnet.png",
                ItemType.Item,
                ResearchType.NoScience)
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
            return new Item(2, "Copper Ingot",
                "Icon_Copper_Ingot.png",
                ItemType.Item,
                ResearchType.NoScience)
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
            return new Item(2, "Refined Oil",
                "Icon_Refined_Oil.png",
                ItemType.Item,
                ResearchType.BlueScience)
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
            return new Item(2, "Hydrogen",
                "Icon_Hydrogen.png",
                ItemType.Item,
                ResearchType.BlueScience)
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
            return new Item(2, "Energetic Graphite",
                "Icon_Energetic_Graphite.png",
                ItemType.Item,
                ResearchType.BlueScience)
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
            return new Item(2, "Titanium Ingot",
                "Icon_Titanium_Ingot.png",
                ItemType.Item,
                ResearchType.RedScience)
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
            return new Item(2, "Stone Brick",
                "Icon_Stone_Brick.png",
                ItemType.Item,
                ResearchType.NoScience)
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

        public static Item Antimatter()
        {
            return new Item(2, "Antimatter",
                "Icon_Antimatter.png",
                ItemType.Item,
                ResearchType.GreenScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Critical Photon", 2 }
                        },
                        new()
                        {
                            { "Antimatter", 2 },
                            { "Hydrogen", 2 }
                        },
                        BuildingType.MiniatureParticleCollider)
                }
            };
        }

        public static Item ProliferatorMkI()
        {
            return new Item(2, "Proliferator Mk.I",
                "Proliferator_Mk.I.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(0.5m,
                        new()
                        {
                            { "Coal", 1 }
                        },
                        new()
                        {
                            { "Proliferator Mk.I", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
