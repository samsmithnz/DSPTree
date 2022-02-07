using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel8
    {
        //Level 8
        public static Item2 ElectromagneticMatrix()
        {
            return new Item2(8, "Electromagne", "Icon_Electromagnetic_Matrix.png")
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

        //items.Add(new Item()
        //{
        //    Name = "Graviton Lens",
        //    Image = "Icon_Graviton_Lens.png",
        //    Recipe = new()
        //    {
        //        { "Diamond", 4 },
        //        { "Strange Matter", 1 }
        //    },
        //    ManufactoringMethod = "Assembling Machine",
        //    Level = 8
        //});
    }

}
