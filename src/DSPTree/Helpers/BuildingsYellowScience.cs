using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsYellowScience
    {

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

        public static Item FullAccumulator()
        {
            return new Item(7, "Full Accumulator",
                "Icon_Full_Accumulator.png",
                ItemType.Building,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(2,
                        new()
                        {
                            { "Accumulator", 1 },
                        },
                        new()
                        {
                            { "Full Accumulator", 1 }
                        },
                        BuildingType.EnergyExchanger)
                }
            };
        }

        public static Item MiniatureParticleCollider()
        {
            return new Item(7, "Miniature Particle Collider",
                "Icon_Miniature_Particle_Collider.png",
                ItemType.Building,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(15,
                        new()
                        {
                            { "Titanium Alloy", 20 },
                            { "Frame Material", 20 },
                            { "Super-Magnetic Ring", 50 },
                            { "Graphene", 10 },
                            { "Processor", 8 }
                        },
                        new()
                        {
                            { "Miniature Particle Collider", 1 }
                        },
                        BuildingType.EnergyExchanger)
                }
            };
        }

        public static Item InterstellarLogisticsStation()
        {
            return new Item(9, "Interstellar Logistics Station",
                "Icon_Interstellar_Logistics_Station.png",
                ItemType.Building,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(30,
                        new()
                        {
                            { "Planetary Logistics Station", 1 },
                            { "Titanium Alloy", 50 },
                            { "Particle Container", 20 }
                        },
                        new()
                        {
                            { "Interstellar Logistics Station", 1 }
                        },
                        BuildingType.EnergyExchanger)
                }
            };
        }

        public static Item OrbitalCollector()
        {
            return new Item(9, "Orbital Collector",
                "Icon_Orbital_Collector.png",
                ItemType.Building,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(30,
                        new()
                        {
                            { "Interstellar Logistics Station", 1 },
                            { "Super-Magnetic Ring", 50 },
                            { "Reinforced Thruster", 20 },
                            { "Full Accumulator", 20 }
                        },
                        new()
                        {
                            { "Orbital Collector", 1 }
                        },
                        BuildingType.EnergyExchanger)
                }
            };
        }

        public static Item AutomaticPiler()
        {
            return new Item(9, "Automatic Piler",
                "Automatic_Piler.png",
                ItemType.Building,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Steel", 3 },
                            { "Gear", 4 },
                            { "Super-Magnetic Ring", 1 },
                            { "Processor", 2 }
                        },
                        new()
                        {
                            { "Automatic Piler", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item LogisticsVessel()
        {
            return new Item(7, "Logistics Vessel",
                "Icon_Logistics_Vessel.png",
                ItemType.Building,
                ResearchType.YellowScience)
            {
                Recipes =
                {
                    new Recipe(6,
                        new()
                        {
                            { "Titanium Alloy", 10 },
                            { "Processor", 10 },
                            { "Reinforced Thruster", 2 }
                        },
                        new()
                        {
                            { "Logistics Vessel", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

    }
}
