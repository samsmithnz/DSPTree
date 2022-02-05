using DSPTree.Models;

namespace DSPTree
{
    public class DSPGraph
    {
        public List<Item> Items { get; set; }
        public List<Item2> Items2 { get; set; }
        public DSPGraph()
        {
            Items = BuildDSPTree();
            Items2 = BuildDSPTree2();
        }

        public Dictionary<string, int> CalculateRawMaterials(Item2 item)
        {
            if (Items == null)
            {
                throw new InvalidOperationException("Items list is not initialized - something bad happened given this is initialized in the class constructor");
            }
            Dictionary<string, int> rawMaterials = new();

            //In this recipe, look at the inputs. If the input is not a level 1 input, look at that inputs, inputs, adding together all of the resource totals.
            foreach (Recipe2 recipe in item.Recipes)
            {
                //get each items materials recursively, summing up all of the items
                if (recipe.PrimaryMethodOfManufacture == true)
                {
                    foreach (KeyValuePair<string, int> input in recipe.Inputs)
                    {
                        Item2? inputItem = FindItem(input.Key);
                        if (inputItem != null)
                        {
                            foreach (Recipe2 inputItemRecipe in inputItem.Recipes)
                            {
                                if (inputItemRecipe.PrimaryMethodOfManufacture == true)
                                {
                                    if (inputItemRecipe.ManufactoringMethod == ManufactoringMethodType.Gathered)
                                    {
                                        if (rawMaterials.ContainsKey(input.Key))
                                        {
                                            rawMaterials[input.Key] += input.Value;
                                        }
                                        else
                                        {
                                            rawMaterials.Add(input.Key, input.Value);
                                        }
                                    }
                                    else
                                    {
                                        //We need to dig deeper
                                    }
                                }
                            }
                        }

                    }
                }
            }
            return rawMaterials;
        }

        private Item2? FindItem(string name)
        {
            Item2? item = null;
            if (Items2 != null)
            {
                item = Items2.Where(x => x.Name == name).FirstOrDefault();
            }
            return item;
        }

        private List<Item2> BuildDSPTree2()
        {
            List<Item2> items = new()
            {
                //Level 1 items (mostly mined ore)
                ItemPool.IronOre(),
                ItemPool.CopperOre(),

                //Level 2 items
                ItemPool.IronIngot(),
                ItemPool.Magnet(),
                ItemPool.CopperIngot(),

                //Level 3 items
                ItemPool.MagneticCoil()

            };

            return items;
        }

        private List<Item> BuildDSPTree()
        {
            List<Item> items = new();

            //Level 1 items (all mined ore)
            items.Add(new Item()
            {
                Name = "Iron Ore",
                Image = "Icon_Iron_Ore.png",
                Recipes =
                {
                    new Recipe()
                    {
                        ProcessingTimeInSeconds = 2,
                        Inputs = new()
                        {
                            { "Iron Ore Vein", 1 }
                        },
                        Outputs = new()
                        {
                            { "Iron Ore", 1 }
                        },
                        ManufactoringMethod = ManufactoringMethodType.Gathered,
                        PrimaryMethodOfManufacture = true
                    }
                },
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Copper Ore",
                Image = "Icon_Copper_Ore.png",
                ProcessingTimeInSeconds = 2,
                //Inputs = new()
                //{
                //    { "Copper Ore Vein", 1 }
                //},
                //Outputs = new()
                //{
                //    { "Copper Ore", 1 }
                //},
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Titanium Ore",
                Image = "Icon_Titanium_Ore.png",
                ProcessingTimeInSeconds = 2,
                //Inputs = new()
                //{
                //    { "Titanium Ore Vein", 1 }
                //},
                //Outputs = new()
                //{
                //    { "Titanium Ore", 1 }
                //},
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Water",
                Image = "Icon_Water.png",
                ProcessingTimeInSeconds = 1.2m,
                //Outputs = new()
                //{
                //    { "Water", 1 }
                //},
                ManufactoringMethod = "Water Pump",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Crude Oil",
                Image = "Icon_Crude_Oil.png",
                ProcessingTimeInSeconds = 1,
                //Outputs = new()
                //{
                //    { "Crude Oil", 1 }
                //},
                ManufactoringMethod = "Oil Extractor",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Stone",
                Image = "Icon_Stone.png",
                ProcessingTimeInSeconds = 2,
                //Inputs = new()
                //{
                //    { "Stone Vein", 1 }
                //},
                //Outputs = new()
                //{
                //    { "Stone", 1 }
                //},
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Coal",
                Image = "Icon_Coal.png",
                ProcessingTimeInSeconds = 2,
                //Inputs = new()
                //{
                //    { "Coal Vein", 1 }
                //},
                //Outputs = new()
                //{
                //    { "Coal", 1 }
                //},
                ManufactoringMethod = "Mining Machine",
                Level = 1
            });
            items.Add(new Item()
            {
                Name = "Silicon Ore",
                Image = "Icon_Silicon_Ore.png",
                ProcessingTimeInSeconds = 2,
                //Inputs = new()
                //{
                //    { "Silicon Ore Vein", 1}
                //},
                //Outputs = new()
                //{
                //    { "Silicon Ore", 1 }
                //},
                ManufactoringMethod = "Mining Machine",
                Level = 2
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
            items.Add(new Item()
            {
                Name = "Plastic",
                Image = "Icon_Plastic.png",
                Recipe = new()
                {
                    { "Energetic Graphite", 1 },
                    { "Refined Oil", 2 }
                },
                ManufactoringMethod = "Chemical Plant",
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
            items.Add(new Item()
            {
                Name = "Crystal Silicon",
                Image = "Icon_Crystal_Silicon.png",
                Recipe = new()
                {
                    { "High-Purity Silicon", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 4
            });
            items.Add(new Item()
            {
                Name = "Microcrystalline Component",
                Image = "Icon_Microcrystalline_Component.png",
                Recipe = new()
                {
                    { "High-Purity Silicon", 2 },
                    { "Copper Ingot", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 4
            });
            items.Add(new Item()
            {
                Name = "Graphene",
                Image = "Icon_Graphene.png",
                Recipe = new()
                {
                    { "Energetic Graphite", 2 },//1.5m },
                    { "Sulfuric Acid", 1 }//0.5m }
                },
                ManufactoringMethod = "Chemical Plant",
                Level = 4
            });
            items.Add(new Item()
            {
                Name = "Organic Crystal",
                Image = "Icon_Organic_Crystal.png",
                Recipe = new()
                {
                    { "Plastic", 2 },
                    { "Refined Oil", 1 },//0.5m }
                    { "Water", 1 }//0.5m }
                },
                ManufactoringMethod = "Chemical Plant",
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
            items.Add(new Item()
            {
                Name = "Titanium Alloy",
                Image = "Icon_Titanium_Alloy.png",
                Recipe = new()
                {
                    { "Titanium Ingot", 1 },
                    { "Steel", 1 },
                    { "Sulfuric Acid", 2 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 5
            });
            items.Add(new Item()
            {
                Name = "Processor",
                Image = "Icon_Processor.png",
                Recipe = new()
                {
                    { "Circuit Board", 2 },
                    { "Microcrystalline Component", 2 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 5
            });
            items.Add(new Item()
            {
                Name = "Carbon Nanotube",
                Image = "Icon_Carbon_Nanotube.png",
                Recipe = new()
                {
                    { "Titanium Ingot", 1 },//0.5m },
                    { "Graphene", 2 } // 1.5m }
                },
                ManufactoringMethod = "Chemical Plant",
                Level = 5
            });
            items.Add(new Item()
            {
                Name = "Titanium Crystal",
                Image = "Icon_Titanium_Crystal.png",
                Recipe = new()
                {
                    { "Titanium Ingot", 3 },
                    { "Organic Crystal", 1 }
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
            items.Add(new Item()
            {
                Name = "Structure Matrix",
                Image = "Icon_Structure_Matrix.png",
                Recipe = new()
                {
                    { "Diamond", 1 },
                    { "Titanium Crystal", 1 }
                },
                ManufactoringMethod = "Matrix Lab",
                Level = 6
            });
            items.Add(new Item()
            {
                Name = "Particle Broadband",
                Image = "Icon_Structure_Matrix.png",
                Recipe = new()
                {
                    { "Carbon Nanotube", 2 },
                    { "Titanium Crystal", 2 },
                    { "Plastic", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 6
            });
            items.Add(new Item()
            {
                Name = "Particle Container",
                Image = "Icon_Particle_Container.png",
                Recipe = new()
                {
                    { "Electromagnetic Turbine", 2 },
                    { "Graphene", 2 },
                    { "Copper Ingot", 2 }
                },
                ManufactoringMethod = "Matrix Lab",
                Level = 6
            });

            //Level 7
            items.Add(new Item()
            {
                Name = "Information Matrix",
                Image = "Icon_Information_Matrix.png",
                Recipe = new()
                {
                    { "Processor", 2 },
                    { "Particle Broadband", 1 }
                },
                ManufactoringMethod = "Matrix Lab",
                Level = 7
            });
            items.Add(new Item()
            {
                Name = "Strange Matter",
                Image = "Icon_Strange_Matter.png",
                Recipe = new()
                {
                    { "Particle Container", 1 },
                    { "Iron Ingot", 1 },
                    { "Hydrogen", 5 }
                },
                ManufactoringMethod = "Miniature Particle Collider",
                Level = 7
            });

            //Level 8
            items.Add(new Item()
            {
                Name = "Graviton Lens",
                Image = "Icon_Graviton_Lens.png",
                Recipe = new()
                {
                    { "Diamond", 4 },
                    { "Strange Matter", 1 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 8
            });

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

            //Sort the items by level
            items = items.OrderBy(b => b.Level).ToList();

            return items;
        }
    }
}
