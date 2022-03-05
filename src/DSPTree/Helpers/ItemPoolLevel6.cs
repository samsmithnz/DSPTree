using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel6
    {
        //Level 6
        public static Item SuperMagneticRing()
        {
            return new Item(6, "Super-Magnetic Ring",
                "Icon_Super-Magnetic_Ring.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(3,
                        new()
                        {
                            { "Electromagnetic Turbine", 2 },
                            { "Magnet", 3 },
                            { "Energetic Graphite", 1 }
                        },
                        new()
                        {
                            { "Super-Magnetic Ring", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item StructureMatrix()
        {
            return new Item(6, "Structure Matrix",
                "Icon_Structure_Matrix.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(8,
                        new()
                        {
                            { "Diamond", 1 },
                            { "Titanium Crystal", 1 }
                        },
                        new()
                        {
                            { "Structure Matrix", 1 }
                        },
                        BuildingType.MatrixLab)
                }
            };
        }

        public static Item ParticleBroadband()
        {
            return new Item(6, "Particle Broadband",
                "Icon_Particle_Broadband.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(8,
                        new()
                        {
                            { "Carbon Nanotube", 2 },
                            { "Crystal Silicon", 2 },
                            { "Plastic", 1 }
                        },
                        new()
                        {
                            { "Particle Broadband", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item ParticleContainer()
        {
            return new Item(6, "Particle Container",
                "Icon_Particle_Container.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Electromagnetic Turbine", 2 },
                            { "Graphene", 2 },
                            { "Copper Ingot", 2 }
                        },
                        new()
                        {
                            { "Particle Container", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item CasimirCrystal()
        {
            return new Item(6, "Casimir Crystal",
                "Icon_Casimir_Crystal.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Titanium Crystal", 1 },
                            { "Graphene", 2 },
                            { "Hydrogen", 12 }
                        },
                        new()
                        {
                            { "Casimir Crystal", 1 }
                        },
                        BuildingType.AssemblingMachine),
                    new Recipe(4,
                        new()
                        {
                            { "Optical Grating Crystal", 4 },
                            { "Graphene", 2 },
                            { "Hydrogen", 12 }
                        },
                        new()
                        {
                            { "Casimir Crystal", 1 }
                        },
                        BuildingType.AssemblingMachine,
                        ManufactoringMethodType.Manufactured,
                        false)
                }
            };
        }

        public static Item ReinforcedThruster()
        {
            return new Item(6, "Reinforced Thruster",
                "Icon_Reinforced_Thruster.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(6,
                        new()
                        {
                            { "Titanium Alloy", 5 },
                            { "Electromagnetic Turbine", 5 }
                        },
                        new()
                        {
                            { "Reinforced Thruster", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item SolarSail()
        {
            return new Item(6, "Solar Sail",
                "Icon_Solar_Sail.png",
                ItemType.Item,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Graphene", 1 },
                            { "Photon Combiner", 1 }
                        },
                        new()
                        {
                            { "Solar Sail", 2 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item ProliferatorMkIII()
        {
            return new Item(6, "Proliferator Mk.III",
                "Proliferator_Mk.III.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Proliferator Mk.II", 2 },
                            { "Carbon Nanotube", 1 }
                        },
                        new()
                        {
                            { "Proliferator Mk.III", 2 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }

}
