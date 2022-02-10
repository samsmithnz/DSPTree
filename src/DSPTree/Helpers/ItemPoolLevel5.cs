using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel5
    {
        //Level 5
        public static Item PlasmaExciter()
        {
            return new Item(5, "Plasma Exciter",
                "Icon_Plasma_Exciter.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Magnetic Coil", 4 },
                            { "Prism", 2 },
                        },
                        new()
                        {
                            { "Plasma Exciter", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item PhotonCombiner()
        {
            return new Item(5, "Photon Combiner",
                "Icon_Photon_Combiner.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(3,
                        new()
                        {
                            { "Circuit Board", 2 },
                            { "Prism", 1 },
                        },
                        new()
                        {
                            { "Photon Combiner", 1 }
                        },
                        BuildingType.AssemblingMachine),
                    new Recipe(3,
                        new()
                        {
                            { "Circuit Board", 2 },
                            { "Optical Grating Crystal", 1 },
                        },
                        new()
                        {
                            { "Photon Combiner", 1 }
                        },
                        BuildingType.AssemblingMachine,
                        ManufactoringMethodType.Manufactured,
                        false)
                }
            };
        }

        public static Item ElectromagneticTurbine()
        {
            return new Item(5, "Electromagnetic Turbine",
                "Icon_Electromagnetic_Turbine.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Magnetic Coil", 2 },
                            { "Electric Motor", 2 }
                        },
                        new()
                        {
                            { "Electromagnetic Turbine", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item TitaniumAlloy()
        {
            return new Item(5, "Titanium Alloy",
                "Icon_Titanium_Alloy.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(12,
                        new()
                        {
                            { "Titanium Ingot", 4 },
                            { "Steel", 4 },
                            { "Sulfuric Acid", 8 }                        },
                        new()
                        {
                            { "Titanium Alloy", 4 }
                        },
                        BuildingType.Smelter)
                }
            };
        }

        public static Item Processor()
        {
            return new Item(5, "Processor",
                "Icon_Processor.png",
                ItemType.Item,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(3,
                        new()
                        {
                            { "Circuit Board", 2 },
                            { "Microcrystalline Component", 2 }
                        },
                        new()
                        {
                            { "Processor", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item CarbonNanotube()
        {
            return new Item(5, "Carbon Nanotube",
                "Icon_Carbon_Nanotube.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Titanium Ingot", 1 },
                            { "Graphene", 3 }
                        },
                        new()
                        {
                            { "Carbon Nanotube", 2 }
                        },
                        BuildingType.ChemicalPlant),
                    new Recipe(4,
                        new()
                        {
                            { "Spiniform Stalagmite Crystal", 2 }
                        },
                        new()
                        {
                            { "Carbon Nanotube", 2 }
                        },
                        BuildingType.ChemicalPlant,
                        ManufactoringMethodType.Manufactured,
                        false)
                }
            };
        }

        public static Item TitaniumCrystal()
        {
            return new Item(5, "Titanium Crystal",
                "Icon_Titanium_Crystal.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Titanium Ingot", 3 },
                            { "Organic Crystal", 1 }
                        },
                        new()
                        {
                            { "Titanium Crystal", 1 }
                        },
                        BuildingType.Smelter)
                }
            };
        }
    }
}
