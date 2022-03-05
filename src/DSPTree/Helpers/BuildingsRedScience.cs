using DSPTree.Models;
using BuildingType = DSPTree.Models.ManufactoringBuildingType;

namespace DSPTree.Helpers
{
    public static class BuildingsRedScience
    {

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

        public static Item StorageMkII()
        {
            return new Item(8, "Storage Mk.II",
                "Icon_Storage_Mk.II.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Iron Ingot", 8 },
                            { "Stone Brick", 8 }
                        },
                        new()
                        {
                            { "Storage Mk.II", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item ConveyorBeltMkII()
        {
            return new Item(8, "Conveyor Belt Mk.II",
                "Icon_Conveyor_Belt_Mk.II.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Conveyor Belt Mk.I", 3 },
                            { "Electromagnetic Turbine", 1 }
                        },
                        new()
                        {
                            { "Conveyor Belt Mk.II", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item AssemblingMachineMkII()
        {
            return new Item(8, "Assembling Machine Mk.II",
                "Icon_Assembling_Machine_Mk.II.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(3,
                        new()
                        {
                            { "Assembling Machine Mk.I", 1 },
                            { "Graphene", 8 },
                            { "Processor", 4 }
                        },
                        new()
                        {
                            { "Assembling Machine Mk.II", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item ConveyorBeltMkIII()
        {
            return new Item(8, "Conveyor Belt Mk.III",
                "Icon_Conveyor_Belt_Mk.III.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Conveyor Belt Mk.II", 3 },
                            { "Super-Magnetic Ring", 1 },
                            { "Graphene", 1 }
                        },
                        new()
                        {
                            { "Conveyor Belt Mk.III", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item SorterMkIII()
        {
            return new Item(8, "Sorter Mk.III",
                "Icon_Sorter_Mk.III.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Sorter Mk.II", 2 },
                            { "Electromagnetic Turbine", 1 }
                        },
                        new()
                        {
                            { "Sorter Mk.III", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item Fractionator()
        {
            return new Item(8, "Fractionator",
                "Icon_Fractionator.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(1,
                        new()
                        {
                            { "Steel", 8 },
                            { "Stone Brick", 4 },
                            { "Glass", 4 },
                            { "Processor", 1 }
                        },
                        new()
                        {
                            { "Fractionator", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item EMRailEjector()
        {
            return new Item(8, "EM-Rail Ejector",
                "Icon_EM-Rail_Ejector.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(6,
                        new()
                        {
                            { "Steel", 20 },
                            { "Gear", 20 },
                            { "Processor", 5 },
                            { "Super-Magnetic Ring", 10 }
                        },
                        new()
                        {
                            { "EM-Rail Ejector", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item RayReceiver()
        {
            return new Item(8, "Ray Receiver",
                "Icon_Ray_Receiver.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(8,
                        new()
                        {
                            { "Steel", 20 },
                            { "High-Purity Silicon", 20 },
                            { "Photon Combiner", 10 },
                            { "Processor", 5 },
                            { "Super-Magnetic Ring", 20 }
                        },
                        new()
                        {
                            { "Ray Receiver", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item PlanetaryLogisticsStation()
        {
            return new Item(8, "Planetary Logistics Station",
                "Icon_Planetary_Logistics_Station.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(20,
                        new()
                        {
                            { "Steel", 40 },
                            { "Titanium Ingot", 40 },
                            { "Processor", 40 },
                            { "Particle Container", 20 }
                        },
                        new()
                        {
                            { "Planetary Logistics Station", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }

        public static Item LogisticsDrone()
        {
            return new Item(6, "Logistics Drone",
                "Icon_Logistics_Drone.png",
                ItemType.Building,
                ResearchType.RedScience)
            {
                Recipes =
                {
                    new Recipe(4,
                        new()
                        {
                            { "Iron Ingot", 5 },
                            { "Processor", 2 },
                            { "Thruster", 2 }
                        },
                        new()
                        {
                            { "Logistics Drone", 1 }
                        },
                        BuildingType.AssemblingMachine)
                }
            };
        }
    }
}
