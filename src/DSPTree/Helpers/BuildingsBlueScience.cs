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
                    new Recipe(1,
                        new()
                        {
                            { "Magnetic Coil", 1 },
                            { "Gear", 1 },
                            { "Iron Ingot", 2 }
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
                            { "Plasma Exciter", 2 }
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

    }
}
