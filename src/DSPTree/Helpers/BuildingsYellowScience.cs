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
        
    }
}
