﻿using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsNoScience
    {

        public static Item TeslaTower()
        {
            return new Item(4, "Tesla Tower",
                "Icon_Tesla_Tower.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Magnetic Coil", 1 },
                            { "Iron Ingot", 2 }
                        },
                        new()
                        {
                            { "Tesla Tower", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item WindTurbine()
        {
            return new Item(4, "Wind Turbine",
                "Icon_Wind_Turbine.png",
                ItemType.Building,
                ResearchType.PreBlueScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Iron Ingot", 6 },
                            { "Gear", 1 },
                            { "Magnetic Coil", 3 }
                        },
                        new()
                        {
                            { "Wind Turbine", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

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

        public static Item Accumulator()
        {
            return new Item(8, "Accumulator",
                "Icon_Accumulator.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(5,
                        new()
                        {
                            { "Iron Ingot", 6 },
                            { "Super-Magnetic Ring", 1 },
                            { "Crystal Silicon", 6 }
                        },
                        new()
                        {
                            { "Accumulator", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item SatelliteSubstation()
        {
            return new Item(8, "Satellite Substation",
                "Icon_Satellite_Substation.png",
                ItemType.Building,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(5,
                        new()
                        {
                            { "Wireless Power Tower", 1 },
                            { "Super-Magnetic Ring", 10 },
                            { "Frame Material", 2 }
                        },
                        new()
                        {
                            { "Satellite Substation", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
        
        public static Item MiniFusionPowerPlant()
        {
            return new Item(7, "Mini Fusion Power Plant",
                "Icon_Mini_Fusion_Power_Plant.png",
                ItemType.Building,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(10,
                        new()
                        {
                            { "Titanium Alloy", 12 },
                            { "Super-Magnetic Ring", 10 },
                            { "Carbon Nanotube", 8 },
                            { "Processor", 4 }
                        },
                        new()
                        {
                            { "Mini Fusion Power Plant", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
        
        public static Item EnergyExchanger()
        {
            return new Item(7, "Energy Exchanger",
                "Icon_Energy_Exchanger.png",
                ItemType.Building,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(15,
                        new()
                        {
                            { "Titanium Alloy", 40 },
                            { "Steel", 40 },
                            { "Processor", 40 },
                            { "Particle Container", 8 },
                        },
                        new()
                        {
                            { "Energy Exchanger", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
        
        public static Item ArtificialStar()
        {
            return new Item(8, "Artificial Star",
                "Icon_Artificial_Star.png",
                ItemType.Building,
                ResearchType.GreenScience)
            {
                Recipes =
                {
                    new Recipe(30,
                        new()
                        {
                            { "Titanium Alloy", 20 },
                            { "Frame Material", 20 },
                            { "Annihilation Constraint Sphere", 40 },
                            { "Quantum Chip", 10 },
                        },
                        new()
                        {
                            { "Artificial Star", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
