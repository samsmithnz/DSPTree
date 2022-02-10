using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel4
    {
        //Level 4
        public static Item ElectromagneticMatrix()
        {
            return new Item(4, "Electromagnetic Matrix",
                "Icon_Electromagnetic_Matrix.png",
                ItemType.Item,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Magnetic Coil", 10 },
                            { "Circuit Board", 10 }
                        },
                        new()
                        {
                            { "Electromagnetic Matrix", 1 }
                        },
                        BuildingType.MatrixLab)
                }
            };
        }

        public static Item ElectricMotor()
        {
            return new Item(4, "Electric Motor", 
                "Icon_Electric_Motor.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Magnetic Coil", 1 },
                            { "Gear", 1 },
                            { "Iron Ingot", 2 }
                        },
                        new()
                        {
                            { "Electric Motor", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item Foundation()
        {
            return new Item(4, "Foundation",
                "Icon_Foundation.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Iron Ingot", 1 },
                            { "Glass", 2 },
                            { "Circuit Board", 1 }
                        },
                        new()
                        {
                            { "Foundation", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item Prism()
        {
            return new Item(4, "Prism",
                "Icon_Prism.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Glass", 3 }
                        },
                        new()
                        {
                            { "Prism", 2 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item CrystalSilicon()
        {
            return new Item(4, "Crystal Silicon",
                "Icon_Crystal_Silicon.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "High-Purity Silicon", 1 }
                        },
                        new()
                        {
                            { "Crystal Silicon", 2 }
                        },
                        BuildingType.Smelter)
                }
            };
        }

        public static Item MicrocrystallineComponent()
        {
            return new Item(4, "Microcrystalline Component",
                "Icon_Microcrystalline_Component.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "High-Purity Silicon", 2 },
                            { "Copper Ingot", 1 }
                        },
                        new()
                        {
                            { "Microcrystalline Component", 2 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item Graphene()
        {
            return new Item(4, "Graphene",
                "Icon_Graphene.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Energetic Graphite", 3 },
                            { "Sulfuric Acid", 1 }
                        },
                        new()
                        {
                            { "Graphene", 2 }
                        },
                        BuildingType.ChemicalPlant),
                    new Recipe(2,
                        new()
                        {
                            { "Fire Ice", 2 }
                        },
                        new()
                        {
                            { "Graphene", 2 },
                            { "Hydrogen", 1 }
                        },
                        BuildingType.ChemicalPlant)
                }
            };
        }

        public static Item OrganicCrystal()
        {
            return new Item(4, "Organic Crystal",
                "Icon_Organic_Crystal.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Plastic", 2 },
                            { "Refined Oil", 1 },
                            { "Water", 1 }
                        },
                        new()
                        {
                            { "Organic Crystal", 2 }
                        },
                        BuildingType.ChemicalPlant)
                }
            };
        }

        public static Item Thruster()
        {
            return new Item(4, "Thruster",
                "Icon_Thruster.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Steel", 2 },
                            { "Copper Ingot", 3 }
                        },
                        new()
                        {
                            { "Thruster", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item TitaniumGlass()
        {
            return new Item(4, "Titanium Glass",
                "Icon_Titanium_Glass.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(5,
                        new()
                        {
                            { "Glass", 2 },
                            { "Titanium Ingot", 2 },
                            { "Water", 2 }
                        },
                        new()
                        {
                            { "Titanium Glass", 2 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
