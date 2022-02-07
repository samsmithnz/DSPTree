using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel7
    {
        //Level 7
        public static Item2 ElectromagneticMatrix()
        {
            return new Item2(7, "Electromagne", "Icon_Electromagnetic_Matrix.png")
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
            //    Name = "Information Matrix",
            //    Image = "Icon_Information_Matrix.png",
            //    Recipe = new()
            //    {
            //        { "Processor", 2 },
            //        { "Particle Broadband", 1 }
            //    },
            //    ManufactoringMethod = "Matrix Lab",
            //    Level = 7
            //});
            //items.Add(new Item()
            //{
            //    Name = "Strange Matter",
            //    Image = "Icon_Strange_Matter.png",
            //    Recipe = new()
            //    {
            //        { "Particle Container", 1 },
            //        { "Iron Ingot", 1 },
            //        { "Hydrogen", 5 }
            //    },
            //    ManufactoringMethod = "Miniature Particle Collider",
            //    Level = 7
            //});
    }

}
