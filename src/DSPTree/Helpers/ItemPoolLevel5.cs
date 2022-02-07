using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;
using MethodType = DSPTree.Models.ManufactoringMethodType;

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

            //items.Add(new Item()
            //{
            //    Name = "Plasma Exciter",
            //    Image = "Icon_Plasma_Exciter.png",
            //    Recipe = new()
            //    {
            //        { "Magnetic Coil", 4 },
            //        { "Prism", 2 },
            //    },
            //    ManufactoringMethod = "Assembling Machine",
            //    Level = 5
            //});
            //items.Add(new Item()
            //{
            //    Name = "Photon Combiner",
            //    Image = "Icon_Photon_Combiner.png",
            //    Recipe = new()
            //    {
            //        { "Circuit Board", 1 }, //0.5m },
            //        { "Prism", 1 },
            //    },
            //    ManufactoringMethod = "Assembling Machine",
            //    Level = 5
            //});
            //items.Add(new Item()
            //{
            //    Name = "Electromagnetic Turbine",
            //    Image = "Icon_Electromagnetic_Turbine.png",
            //    Recipe = new()
            //    {
            //        { "Magnetic Coil", 2 },
            //        { "Electric Motor", 2 },
            //    },
            //    ManufactoringMethod = "Assembling Machine",
            //    Level = 5
            //});
            //items.Add(new Item()
            //{
            //    Name = "Titanium Alloy",
            //    Image = "Icon_Titanium_Alloy.png",
            //    Recipe = new()
            //    {
            //        { "Titanium Ingot", 1 },
            //        { "Steel", 1 },
            //        { "Sulfuric Acid", 2 }
            //    },
            //    ManufactoringMethod = "Arc Smelter",
            //    Level = 5
            //});
            //items.Add(new Item()
            //{
            //    Name = "Processor",
            //    Image = "Icon_Processor.png",
            //    Recipe = new()
            //    {
            //        { "Circuit Board", 2 },
            //        { "Microcrystalline Component", 2 }
            //    },
            //    ManufactoringMethod = "Assembling Machine",
            //    Level = 5
            //});
            //items.Add(new Item()
            //{
            //    Name = "Carbon Nanotube",
            //    Image = "Icon_Carbon_Nanotube.png",
            //    Recipe = new()
            //    {
            //        { "Titanium Ingot", 1 },//0.5m },
            //        { "Graphene", 2 } // 1.5m }
            //    },
            //    ManufactoringMethod = "Chemical Plant",
            //    Level = 5
            //});
            //items.Add(new Item()
            //{
            //    Name = "Titanium Crystal",
            //    Image = "Icon_Titanium_Crystal.png",
            //    Recipe = new()
            //    {
            //        { "Titanium Ingot", 3 },
            //        { "Organic Crystal", 1 }
            //    },
            //    ManufactoringMethod = "Assembling Machine",
            //    Level = 5
            //});
}
