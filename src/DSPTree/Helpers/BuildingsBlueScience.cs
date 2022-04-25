using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsBlueScience
    {

        public static Item ThermalPowerPlant()
        {
            return new Item(4, "Thermal Power Plant",
                "Icon_Thermal_Power_Plant.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(5,
                        new()
                        {
                            { "Iron Ingot", 10 },
                            { "Stone Brick", 4 },
                            { "Gear", 4 },
                            { "Magnetic Coil", 4 }
                        },
                        new()
                        {
                            { "Thermal Power Plant", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item SolarPanel()
        {
            return new Item(4, "Solar Panel",
                "Icon_Solar_Panel.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(6,
                        new()
                        {
                            { "Copper Ingot", 10 },
                            { "High-Purity Silicon", 10 },
                            { "Circuit Board", 5 }
                        },
                        new()
                        {
                            { "Solar Panel", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item WirelessPowerTower()
        {
            return new Item(6, "Wireless Power Tower",
                "Icon_Wireless_Power_Tower.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(3,
                        new()
                        {
                            { "Tesla Tower", 1 },
                            { "Plasma Exciter", 3 }
                        },
                        new()
                        {
                            { "Wireless Power Tower", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item Splitter()
        {
            return new Item(4, "Splitter",
                "Icon_Splitter.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Iron Ingot", 3 },
                            { "Gear", 2 },
                            { "Circuit Board", 1 }
                        },
                        new()
                        {
                            { "Splitter", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item OilExtractor()
        {
            return new Item(6, "Oil Extractor",
                "Icon_Oil_Extractor.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(8,
                        new()
                        {
                            { "Steel", 12 },
                            { "Stone Brick", 12 },
                            { "Circuit Board", 6 },
                            { "Plasma Exciter", 4 }
                        },
                        new()
                        {
                            { "Oil Extractor", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item OilRefinery()
        {
            return new Item(6, "Oil Refinery",
                "Icon_Oil_Refinery.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(6,
                        new()
                        {
                            { "Steel", 10 },
                            { "Stone Brick", 10 },
                            { "Circuit Board", 6 },
                            { "Plasma Exciter", 6 }
                        },
                        new()
                        {
                            { "Oil Refinery", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item WaterPump()
        {
            return new Item(5, "Water Pump",
                "Icon_Water_Pump.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Iron Ingot", 8 },
                            { "Stone Brick", 4 },
                            { "Electric Motor", 4 },
                            { "Circuit Board", 2 }
                        },
                        new()
                        {
                            { "Water Pump", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item StorageTank()
        {
            return new Item(5, "Storage Tank",
                "Icon_Storage_Tank.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Iron Ingot", 8 },
                            { "Stone Brick", 4 },
                            { "Glass", 4 }
                        },
                        new()
                        {
                            { "Storage Tank", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item SorterMkII()
        {
            return new Item(5, "Sorter Mk.II",
                "Icon_Sorter_Mk.II.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Sorter Mk.I", 2 },
                            { "Electric Motor", 1 }
                        },
                        new()
                        {
                            { "Sorter Mk.II", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item TrafficMonitor()
        {
            return new Item(5, "Traffic Monitor",
                "Icon_Traffic_Monitor.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Iron Ingot", 3 },
                            { "Gear", 2 },
                            { "Glass", 1 },
                            { "Circuit Board", 2 }
                        },
                        new()
                        {
                            { "Traffic Monitor", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item ChemicalPlant()
        {
            return new Item(5, "Chemical Plant",
                "Icon_Chemical_Plant.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(5,
                        new()
                        {
                            { "Steel", 8 },
                            { "Stone Brick", 8 },
                            { "Glass", 8 },
                            { "Circuit Board", 2 }
                        },
                        new()
                        {
                            { "Chemical Plant", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item SprayCoater()
        {
            return new Item(5, "Spray Coater",
                "Spray_Coater.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(3,
                        new()
                        {
                            { "Steel", 4 },
                            { "Plasma Exciter", 2 },
                            { "Circuit Board", 2 },
                            { "Microcrystalline Component", 2 },
                        },
                        new()
                        {
                            { "Spray Coater", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item Foundation()
        {
            return new Item(4, "Foundation",
                "Icon_Foundation.png",
                ItemType.Building,
                ResearchType.BlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Stone Brick", 3 },
                            { "Steel", 1 }
                        },
                        new()
                        {
                            { "Foundation", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

    }
}
