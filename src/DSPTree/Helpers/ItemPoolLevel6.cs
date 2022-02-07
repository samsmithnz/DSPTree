using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

namespace DSPTree.Helpers
{
    public static class ItemPoolLevel6
    {
        //Level 6
        public static Item2 ElectromagneticMatrix()
        {
            return new Item2(6, "Electromagne", "Icon_Electromagnetic_Matrix.png")
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
            //    Name = "Super-Magnetic Ring",
            //    Image = "Icon_Super-Magnetic_Ring.png",
            //    Recipe = new()
            //    {
            //        { "Electromagnetic Turbine", 2 },
            //        { "Magnet", 3 },
            //        { "Energetic Graphite", 1 }
            //    },
            //    ManufactoringMethod = "Assembling Machine",
            //    Level = 6
            //});
            //items.Add(new Item()
            //{
            //    Name = "Structure Matrix",
            //    Image = "Icon_Structure_Matrix.png",
            //    Recipe = new()
            //    {
            //        { "Diamond", 1 },
            //        { "Titanium Crystal", 1 }
            //    },
            //    ManufactoringMethod = "Matrix Lab",
            //    Level = 6
            //});
            //items.Add(new Item()
            //{
            //    Name = "Particle Broadband",
            //    Image = "Icon_Structure_Matrix.png",
            //    Recipe = new()
            //    {
            //        { "Carbon Nanotube", 2 },
            //        { "Titanium Crystal", 2 },
            //        { "Plastic", 1 }
            //    },
            //    ManufactoringMethod = "Assembling Machine",
            //    Level = 6
            //});
            //items.Add(new Item()
            //{
            //    Name = "Particle Container",
            //    Image = "Icon_Particle_Container.png",
            //    Recipe = new()
            //    {
            //        { "Electromagnetic Turbine", 2 },
            //        { "Graphene", 2 },
            //        { "Copper Ingot", 2 }
            //    },
            //    ManufactoringMethod = "Matrix Lab",
            //    Level = 6
            //});
    }

}
