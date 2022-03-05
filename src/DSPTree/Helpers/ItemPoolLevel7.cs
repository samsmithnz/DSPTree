using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel7
    {
        //Level 7
        public static Item StrangeMatter()
        {
            return new Item(7, "Strange Matter",
                "Icon_Strange_Matter.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(8,
                        new()
                        {
                            { "Particle Container", 2 },
                            { "Iron Ingot", 2 },
                            { "Hydrogen", 10 }
                        },
                        new()
                        {
                            { "Strange Matter", 1 }
                        },
                        BuildingType.MiniatureParticleCollider)
                }
            };
        }

        public static Item InformationMatrix()
        {
            return new Item(7, "Information Matrix",
                "Icon_Information_Matrix.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(10,
                        new()
                        {
                            { "Processor", 2 },
                            { "Particle Broadband", 1 }
                        },
                        new()
                        {
                            { "Information Matrix", 1 }
                        },
                        BuildingType.MatrixLab)
                }
            };
        }

        public static Item PlaneFilter()
        {
            return new Item(7, "Plane Filter",
                "Icon_Plane_Filter.png",
                ItemType.Item,
                ResearchType.PurpleScience)
            {
                Recipes =
                {
                    new Recipe(12,
                        new()
                        {
                            { "Casimir Crystal", 1 },
                            { "Titanium Glass", 2 }
                        },
                        new()
                        {
                            { "Plane Filter", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item FrameMaterial()
        {
            return new Item(7, "Frame Material",
                "Icon_Frame_Material.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(6,
                        new()
                        {
                            { "Carbon Nanotube", 4 },
                            { "Titanium Alloy", 1 },
                            { "High-Purity Silicon", 1 }
                        },
                        new()
                        {
                            { "Frame Material", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item AnnihilationConstraintSphere()
        {
            return new Item(7, "Annihilation Constraint Sphere",
                "Icon_Annihilation_Constraint_Sphere.png",
                ItemType.Item,
                ResearchType.GreenScience)
            {
                Recipes =
                {
                    new Recipe(20,
                        new()
                        {
                            { "Particle Container", 1 },
                            { "Processor", 1 }
                        },
                        new()
                        {
                            { "Annihilation Constraint Sphere", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item DeuteronFuelRod()
        {
            return new Item(7, "Deuteron Fuel Rod",
                "Icon_Deuteron_Fuel_Rod.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(12,
                        new()
                        {
                            { "Titanium Alloy", 1 },
                            { "Deuterium", 20 },
                            { "Super-Magnetic Ring", 1 }
                        },
                        new()
                        {
                            { "Deuteron Fuel Rod", 2 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

    }

}
