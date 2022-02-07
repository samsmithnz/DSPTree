using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel9
    {
        //Level 9
        public static Item2 GravityMatrix()
        {
            return new Item2(9, "Gravity Matrix", "Icon_Gravity_Matrix.png")
            {
                Recipes =
                {
                    new Recipe2(24,
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

    }

}
