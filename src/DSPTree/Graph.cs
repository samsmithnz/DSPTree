//using DSPTree.Models;

//namespace DSPTree
//{
//    public class Graph
//    {
//        public List<Item> Nodes { get; set; }
//        public Graph()
//        {
//            Nodes = new();

//            //Level 1 items (all mined ore)
//            Nodes.Add(new Item()
//            {
//                Name = "Iron Ore",
//                Image = "Icon_Iron_Ore.png",
//                ManufactoringMethod = "Arc Smelter"
//            });

//            Nodes.Add(new Item()
//            {
//                Name = "Copper Ore",
//                Image = "Icon_Copper_Ore.png",
//                ManufactoringMethod = "Arc Smelter"
//            });

//            //Level 2 items
//            Nodes.Add(new Item()
//            {
//                Name = "Iron Ingot",
//                Image = "Icon_Iron_Ingot.png",
//                Recipe = new Dictionary<string, int>()
//                {
//                    { "Iron Ore", 1 }
//                },
//                ManufactoringMethod = "Arc Smelter"
//            });
//            Nodes.Add(new Item()
//            {
//                Name = "Magnet",
//                Image = "Icon_Magnet.png",
//                Recipe = new Dictionary<string, int>()
//                {
//                    { "Iron Ore", 1 }
//                },
//                ManufactoringMethod = "Arc Smelter"
//            });
//            Nodes.Add(new Item()
//            {
//                Name = "Copper Ingot",
//                Image = "Icon_Copper_Ingot.png",
//                Recipe = new Dictionary<string, int>()
//                {
//                    { "Copper Ore", 1 }
//                },
//                ManufactoringMethod = "Arc Smelter"
//            });

//            //Level 3 items
//            Nodes.Add(new Item()
//            {
//                Name = "Magnetic Coil",
//                Image = "Icon_Magnetic_Coil.png",
//                Recipe = new Dictionary<string, int>()
//                {
//                    { "Copper Ingot", 1 },
//                    { "Magnet", 2 }
//                },
//                ManufactoringMethod = "Assembling Machine"
//            });
//            Nodes.Add(new Item()
//            {
//                Name = "Circuit Board",
//                Image = "Icon_Circuit_Board.png",
//                Recipe = new Dictionary<string, int>()
//                {
//                    { "Copper Ingot", 1 },
//                    { "Iron Ingot", 2 }
//                },
//                ManufactoringMethod = "Assembling Machine"
//            });


//        }
//    }
//}
