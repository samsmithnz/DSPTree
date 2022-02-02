using DSPTree.Models;

namespace DSPTree
{
    public class DSPGraph
    {
        public List<Item> Items { get; set; }
        public DSPGraph()
        {
            Items = BuildDSPTree();
        }

        public List<Item> CalculateRawMaterialNeeds(Item item)
        {
            if (Items == null)
            {
                throw new InvalidOperationException("Items list is not initialized - something bad happened given this is initialized in the class constructor");
            }
            List<Item> rawMaterials = new();
            foreach (KeyValuePair<string, decimal> prereqItem in item.Recipe)
            {
                //get each items materials recursively, summing up all of the items
            }

            return null;
        }

        private List<Item> BuildDSPTree()
        {
            List<Item> items = new();

            //Level 1 items (all mined ore)
            items.Add(new Item()
            {
                Name = "Iron Ore",
                Image = "Icon_Iron_Ore.png",
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Copper Ore",
                Image = "Icon_Copper_Ore.png",
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Titanium Ore",
                Image = "Icon_Titanium_Ore.png",
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Water",
                Image = "Icon_Water.png",
                ManufactoringMethod = "Water Pump",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Crude Oil",
                Image = "Icon_Crude_Oil.png",
                ManufactoringMethod = "Oil Extractor",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Stone",
                Image = "Icon_Stone.png",
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Coal",
                Image = "Icon_Coal.png",
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });

            //Level 2 items
            items.Add(new Item()
            {
                Name = "Iron Ingot",
                Image = "Icon_Iron_Ingot.png",
                Recipe = new()
                {
                    { "Iron Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            items.Add(new Item()
            {
                Name = "Magnet",
                Image = "Icon_Magnet.png",
                Recipe = new()
                {
                    { "Iron Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            items.Add(new Item()
            {
                Name = "Copper Ingot",
                Image = "Icon_Copper_Ingot.png",
                Recipe = new()
                {
                    { "Copper Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            items.Add(new Item()
            {
                Name = "Titanium Ingot",
                Image = "Icon_Titanium_Ingot.png",
                Recipe = new()
                {
                    { "Titanium Ore", 2 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            items.Add(new Item()
            {
                Name = "Refined Oil",
                Image = "Icon_Refined_Oil.png",
                Recipe = new()
                {
                    { "Crude Oil", 1 }
                },
                ManufactoringMethod = "Oil Refinery",
                Level = 2
            });
            items.Add(new Item()
            {
                Name = "Hydrogen",
                Image = "Icon_Hydrogen.png",
                Recipe = new()
                {
                    { "Crude Oil", 2 }
                },
                ManufactoringMethod = "Oil Refinery",
                Level = 2
            });
            items.Add(new Item()
            {
                Name = "Stone Brick",
                Image = "Icon_Stone_Brick.png",
                Recipe = new()
                {
                    { "Stone", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            items.Add(new Item()
            {
                Name = "Silicon Ore",
                Image = "Icon_Silicon_Ore.png",
                Recipe = new()
                {
                    { "Stone", 10 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            items.Add(new Item()
            {
                Name = "Energetic Graphite",
                Image = "Icon_Energetic_Graphite.png",
                Recipe = new()
                {
                    { "Coal", 1 } //0.5m }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });

            //Level 3 items
            items.Add(new Item()
            {
                Name = "Magnetic Coil",
                Image = "Icon_Magnetic_Coil.png",
                Recipe = new()
                {
                    { "Copper Ingot", 1 },//0.5m },
                    { "Magnet", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 3
            });
            items.Add(new Item()
            {
                Name = "Circuit Board",
                Image = "Icon_Circuit_Board.png",
                Recipe = new()
                {
                    { "Copper Ingot", 1 },//0.5m },
                    { "Iron Ingot", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 3
            });
            items.Add(new Item()
            {
                Name = "Steel",
                Image = "Icon_Steel.png",
                Recipe = new()
                {
                    { "Iron Ingot", 1 }//0.33m }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 3
            });
            items.Add(new Item()
            {
                Name = "Gear",
                Image = "Icon_Gear.png",
                Recipe = new()
                {
                    { "Iron Ingot", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 3
            });
            items.Add(new Item()
            {
                Name = "Glass",
                Image = "Icon_Glass.png",
                Recipe = new()
                {
                    { "Stone", 2 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 3
            });
            items.Add(new Item()
            {
                Name = "High-Purity Silicon",
                Image = "High-Purity Silicon.png",
                Recipe = new()
                {
                    { "Silicon Ore", 2 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 3
            });
            items.Add(new Item()
            {
                Name = "Sulfuric Acid",
                Image = "Icon_Sulfuric_Acid.png",
                Recipe = new()
                {
                    { "Water", 1 },
                    { "Stone", 2 },
                    { "Refined Oil", 1.5m }
                },
                ManufactoringMethod = "Chemical Plant",
                HasAlternativeRareSource = true,
                Level = 3
            });
            items.Add(new Item()
            {
                Name = "Energy Matrix",
                Image = "Icon_Energy_Matrix.png",
                Recipe = new()
                {
                    { "Energetic Graphite", 2 },
                    { "Hydrogen", 2 }
                },
                ManufactoringMethod = "Matrix Lab",
                Level = 3
            });
            items.Add(new Item()
            {
                Name = "Hydrogen Fuel Rod",
                Image = "Icon_Hydrogen_Fuel_Rod.png",
                Recipe = new()
                {
                    { "Titanium Ingot", 1 }, //0.5m },
                    { "Hydrogen", 5 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 3
            });
            items.Add(new Item()
            {
                Name = "Diamond",
                Image = "Icon_Diamond.png",
                Recipe = new()
                {
                    { "Energetic Graphite", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                HasAlternativeRareSource = true,
                Level = 3
            });

            //Level 4 items
            items.Add(new Item()
            {
                Name = "Foundation",
                Image = "Icon_Foundation.png",
                Recipe = new()
                {
                    { "Stone Brick", 3 },
                    { "Steel", 1 },
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 4
            });
            items.Add(new Item()
            {
                Name = "Solar Panels",
                Image = "Icon_Solar_Panel.png",
                Recipe = new()
                {
                    { "Iron Ingot", 1 },
                    { "Glass", 2 },
                    { "Circuit Board", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 4
            });
            items.Add(new Item()
            {
                Name = "Prism",
                Image = "Icon_Prism.png",
                Recipe = new()
                {
                    { "Glass", 1 }// 0.67m },
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 4
            });
            items.Add(new Item()
            {
                Name = "Electromagnetic Matrix",
                Image = "Icon_Electromagnetic_Matrix.png",
                Recipe = new()
                {
                    { "Magnetic Coil", 1 }, // 0.1m },
                    { "Circuit Board", 1 } // 0.1m }
                },
                ManufactoringMethod = "Matrix Lab",
                Level = 4
            });
            items.Add(new Item()
            {
                Name = "Electric Motor",
                Image = "Icon_Electric_Motor.png",
                Recipe = new()
                {
                    { "Magnetic Coil", 1 },
                    { "Gear", 1 },
                    { "Iron Ingot", 2 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 4
            });

            //Level 5 items
            items.Add(new Item()
            {
                Name = "Plasma Exciter",
                Image = "Icon_Plasma_Exciter.png",
                Recipe = new()
                {
                    { "Magnetic Coil", 4 },
                    { "Prism", 2 },
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 5
            });
            items.Add(new Item()
            {
                Name = "Photon Combiner",
                Image = "Icon_Photon_Combiner.png",
                Recipe = new()
                {
                    { "Circuit Board", 1 }, //0.5m },
                    { "Prism", 1 },
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 5
            });
            items.Add(new Item()
            {
                Name = "Electromagnetic Turbine",
                Image = "Icon_Electromagnetic_Turbine.png",
                Recipe = new()
                {
                    { "Magnetic Coil", 2 },
                    { "Electric Motor", 2 },
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 5
            });

            //Level 6
            items.Add(new Item()
            {
                Name = "Super-Magnetic Ring",
                Image = "Icon_Super-Magnetic_Ring.png",
                Recipe = new()
                {
                    { "Electromagnetic Turbine", 2 },
                    { "Magnet", 3 },
                    { "Energetic Graphite", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 6
            });

            //Sort the items by level
            items = items.OrderBy(b => b.Level).ToList();

            return items;
        }
    }
}
