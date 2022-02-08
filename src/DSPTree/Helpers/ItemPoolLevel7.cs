﻿using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel7
    {
        //Level 7
        public static Item StrangeMatter()
        {
            return new Item(7, "Strange Matter", "Icon_Strange_Matter.png")
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
            return new Item(7, "Information Matrix", "Icon_Information_Matrix.png")
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
            return new Item(7, "Plane Filter", "Icon_Plane_Filter.png")
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

    }

}
