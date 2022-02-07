using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

//TODO: Add in the veins (level 0?)
namespace DSPTree.Helpers
{
    public static class ItemPoolLevel5
    {
        //Level 5
        public static Item2 ElectromagneticMatrix()
        {
            return new Item2(5, "Electromagnetic Matrix", "Icon_Electromagnetic_Matrix.png")
            {
                Recipes =
                {
                    new Recipe2(1,
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


    }
}
