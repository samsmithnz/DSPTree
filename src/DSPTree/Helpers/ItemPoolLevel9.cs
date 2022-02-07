using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel9
    {
        //Level 9
        public static Item2 ElectromagneticMatrix()
        {
            return new Item2(9, "Electromagne", "Icon_Electromagnetic_Matrix.png")
            {
                Recipes =
                {
                    new Recipe2(1,
                        new()
                        {
                            { "MagneticCoil", 10 },
                            { "CircuitBoard", 10 }
                        },
                        new()
                        {
                            { "ElectromagneticMatrix", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        ////Level 9
        //items.Add(new Item()
        //{
        //    Name = "Gravity Matrix",
        //    Image = "Icon_Gravity_Matrix.png",
        //    Recipe = new()
        //    {
        //        { "Graviton Lens", 1 },
        //        { "Quantum Chip", 1 }
        //    },
        //    ManufactoringMethod = "Matrix Lab",
        //    Level = 9
        //});
    }

}
