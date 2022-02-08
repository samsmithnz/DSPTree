﻿using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel6
    {
        //Level 6
        public static Item SuperMagneticRing()
        {
            return new Item(6, "Super-Magnetic Ring", "Icon_Super-Magnetic_Ring.png")
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
            return new Item(6, "Structure Matrix", "Icon_Structure_Matrix.png")
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
            return new Item(6, "Particle Broadband", "Icon_Particle_Broadband.png")
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
            return new Item(6, "Particle Container", "Icon_Particle_Container.png")
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
            return new Item(6, "Casimir Crystal", "Icon_Casimir_Crystal.png")
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
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }

}