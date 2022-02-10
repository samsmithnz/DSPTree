using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel9
    {
        //Level 9
        public static Item GravityMatrix()
        {
            return new Item(9, "Gravity Matrix", 
                "Icon_Gravity_Matrix.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(24,
                        new()
                        {
                            { "Graviton Lens", 1 },
                            { "Quantum Chip", 1 }
                        },
                        new()
                        {
                            { "Gravity Matrix", 2 }
                        },
                        BuildingType.MatrixLab)
                }
            };
        }

        public static Item SmallCarrierRocket()
        {
            return new Item(9, "Small Carrier Rocket",
                "Icon_Small_Carrier_Rocket.png",
                ItemType.Item,
                ResearchType.PurpleScience)
            {
                Recipes =
                {
                    new Recipe(6,
                        new()
                        {
                            { "Dyson Sphere Component", 2 },
                            { "Deuteron Fuel Rod", 4 },
                            { "Quantum Chip", 2 }
                        },
                        new()
                        {
                            { "Small Carrier Rocket", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item SpaceWarper()
        {
            return new Item(9, "Space Warper",
                "Icon_Space_Warper.png",
                ItemType.Item,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(10,
                        new()
                        {
                            { "Graviton Lens", 1 }
                        },
                        new()
                        {
                            { "Space Warper", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

    }

}
