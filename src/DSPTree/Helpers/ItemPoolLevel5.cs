using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel5
    {
        //Level 5
        public static Item2 PlasmaExciter()
        {
            return new Item2(5, "Plasma Exciter", "Icon_Plasma_Exciter.png")
            {
                Recipes =
                {
                    new Recipe2(2,
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

        public static Item2 PhotonCombiner()
        {
            return new Item2(5, "Photon Combiner", "Icon_Photon_Combiner.png")
            {
                Recipes =
                {
                    new Recipe2(3,
                        new()
                        {
                            { "Circuit Board", 2 },
                            { "Prism", 1 },
                        },
                        new()
                        {
                            { "Photon Combiner", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item2 ElectromagneticTurbine()
        {
            return new Item2(5, "Electromagnetic Turbine", "Icon_Electromagnetic_Turbine.png")
            {
                Recipes =
                {
                    new Recipe2(2,
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

        public static Item2 TitaniumAlloy()
        {
            return new Item2(5, "Titanium Alloy", "Icon_Titanium_Alloy.png")
            {
                Recipes =
                {
                    new Recipe2(12,
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

        public static Item2 Processor()
        {
            return new Item2(5, "Processor", "Icon_Processor.png")
            {
                Recipes =
                {
                    new Recipe2(3,
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

        public static Item2 CarbonNanotube()
        {
            return new Item2(5, "Carbon Nanotube", "Icon_Carbon_Nanotube.png")
            {
                Recipes =
                {
                    new Recipe2(4,
                        new()
                        {
                            { "Titanium Ingot", 1 },
                            { "Graphene", 3 }
                        },
                        new()
                        {
                            { "Carbon Nanotube", 2 }
                        },
                        BuildingType.ChemicalPlant)
                }
            };
        }

        public static Item2 TitaniumCrystal()
        {
            return new Item2(5, "Titanium Crystal", "Icon_Titanium_Crystal.png")
            {
                Recipes =
                {
                    new Recipe2(4,
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
