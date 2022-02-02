using DSPTree.Models;

namespace DSPTree
{
    public class DSPGraph
    {
        public List<Item> Items { get; set; }
        public DSPGraph()
        {
            Items = new();

            //Level 1 items (all mined ore)
            Items.Add(new Item()
            {
                Name = "Iron Ore",
                Image = "Icon_Iron_Ore.png",
                ManufactoringMethod = "Arc Smelter",
                Level = 1
            });
            Items.Add(new Item()
            {
                Name = "Copper Ore",
                Image = "Icon_Copper_Ore.png",
                ManufactoringMethod = "Arc Smelter",
                Level = 1
            });
            Items.Add(new Item()
            {
                Name = "Titanium Ore",
                Image = "Icon_Titanium_Ore.png",
                ManufactoringMethod = "Arc Smelter",
                Level = 1
            });
            Items.Add(new Item()
            {
                Name = "Water",
                Image = "Icon_Water.png",
                ManufactoringMethod = "Pump",
                Level = 1
            });
            Items.Add(new Item()
            {
                Name = "Unrefined Oil",
                Image = "Icon_Unrefined_Oil.png",
                ManufactoringMethod = "Oil Extractor",
                Level = 1
            });
            Items.Add(new Item()
            {
                Name = "Stone",
                Image = "Icon_Stone.png",
                ManufactoringMethod = "Arc Smelter",
                Level = 1
            });

            //Level 2 items
            Items.Add(new Item()
            {
                Name = "Iron Ingot",
                Image = "Icon_Iron_Ingot.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Iron Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            Items.Add(new Item()
            {
                Name = "Magnet",
                Image = "Icon_Magnet.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Iron Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            Items.Add(new Item()
            {
                Name = "Copper Ingot",
                Image = "Icon_Copper_Ingot.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Copper Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            Items.Add(new Item()
            {
                Name = "Titanium Ingot",
                Image = "Icon_Titanium_Ingot.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Titanium Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            Items.Add(new Item()
            {
                Name = "Refined Oil",
                Image = "Icon_Refined_Oil.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Unrefined Oil", 1 }
                },
                ManufactoringMethod = "Oil Refinery",
                Level = 2
            });
            Items.Add(new Item()
            {
                Name = "Hydrogen",
                Image = "Icon_Hydrogen.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Unrefined Oil", 1 }
                },
                ManufactoringMethod = "Oil Refinery",
                Level = 2
            });
            Items.Add(new Item()
            {
                Name = "Stone Brick",
                Image = "Icon_Stone_Brick.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Stone", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            Items.Add(new Item()
            {
                Name = "Silicon Ore",
                Image = "Icon_Silicon_Ore.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Stone", 10 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });

            //Level 3 items
            Items.Add(new Item()
            {
                Name = "Magnetic Coil",
                Image = "Icon_Magnetic_Coil.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Copper Ingot", 1 },
                    { "Magnet", 2 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 3
            });
            Items.Add(new Item()
            {
                Name = "Circuit Board",
                Image = "Icon_Circuit_Board.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Copper Ingot", 1 },
                    { "Iron Ingot", 2 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 3
            });
            Items.Add(new Item()
            {
                Name = "Steel",
                Image = "Icon_Steel.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Iron Ingot", 3 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 3
            });
            Items.Add(new Item()
            {
                Name = "Gear",
                Image = "Icon_Gear.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Iron Ingot", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 3
            });
            Items.Add(new Item()
            {
                Name = "Glass",
                Image = "Icon_Glass.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Stone", 2 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 3
            });
            Items.Add(new Item()
            {
                Name = "High-Purity Silicon",
                Image = "High-Purity Silicon.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Silicon Ore", 2 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 3
            });

            //Level 4 items
            Items.Add(new Item()
            {
                Name = "Foundation",
                Image = "Icon_Foundation.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Stone Brick", 3 },
                    { "Steel", 1 },
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 4
            });
            Items.Add(new Item()
            {
                Name = "Solar Panels",
                Image = "Icon_Solar_Panel.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Iron Ingot", 1 },
                    { "Glass", 2 },
                    { "Circuit Board", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 4
            });

            //Sort the items by level
            Items = Items.OrderBy(b => b.Level).ToList();
        }
    }
}
