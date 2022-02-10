using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
//using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel10
    {
        //Level 10
        public static Item UniverseMatrix()
        {
            return new Item(10, "Universe Matrix",
                "Icon_Universe_Matrix.png",
                ItemType.Item,
                ResearchType.GreenScience)
            {
                Recipes =
                {
                    new Recipe(15,
                        new()
                        {
                            { "Electromagnetic Matrix", 1 },
                            { "Energy Matrix", 1 },
                            { "Structure Matrix", 1 },
                            { "Information Matrix", 1 },
                            { "Gravity Matrix", 1 },
                            { "Antimatter", 1 }
                        },
                        new()
                        {
                            { "Universe Matrix", 2 }
                        },
                        BuildingType.MatrixLab)
                }
            };
        }

    }

}
