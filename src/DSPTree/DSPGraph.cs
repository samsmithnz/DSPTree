using DSPTree.Helpers;
using DSPTree.Models;

namespace DSPTree
{
    public class DSPGraph
    {
        public List<Item> Items { get; set; }
        public DSPGraph(string filter = "",
            ResearchType researchType = ResearchType.WhiteScience,
            bool includeBuildings = false,
            bool showOnlyDirectDependencies = false)
        {
            Items = BuildDSPTree(filter,
                researchType,
                includeBuildings,
                showOnlyDirectDependencies);
        }

        private static List<Item> BuildDSPTree(string nameFilter,
            ResearchType researchType,
            bool includeBuildings,
            bool showOnlyDirectDependencies)
        {
            List<Item> items = new()
            {
                //Level 0 items (Mostly ore veins)
                ItemPoolLevel0.IronOreVein(),
                ItemPoolLevel0.CopperOreVein(),
                ItemPoolLevel0.CrudeOilVein(),
                ItemPoolLevel0.StoneVein(),
                ItemPoolLevel0.CoalVein(),
                ItemPoolLevel0.TitaniumOreVein(),
                ItemPoolLevel0.SiliconOreVein(),
                ItemPoolLevel0.UnipolarMagnetVein(),
                ItemPoolLevel0.KimberliteOreVein(),
                ItemPoolLevel0.FractalSiliconVein(),
                ItemPoolLevel0.OpticalGratingRock(),
                ItemPoolLevel0.SpiniformStalagmiteCrystalVein(),
                ItemPoolLevel0.FireIceVein(),
                ItemPoolLevel0.Log(),
                ItemPoolLevel0.PlantFuel(),

                //Level 1 items (mostly mined ore)
                ItemPoolLevel1.IronOre(),
                ItemPoolLevel1.CopperOre(),
                ItemPoolLevel1.Water(),
                ItemPoolLevel1.CrudeOil(),
                ItemPoolLevel1.Stone(),
                ItemPoolLevel1.Coal(),
                ItemPoolLevel1.TitaniumOre(),
                ItemPoolLevel1.SiliconOre(),
                ItemPoolLevel1.UnipolarMagnet(),
                ItemPoolLevel1.KimberliteOre(),
                ItemPoolLevel1.FractalSilicon(),
                ItemPoolLevel1.OpticalGratingCrystal(),
                ItemPoolLevel1.SpiniformStalagmiteCrystal(),
                ItemPoolLevel1.FireIce(),
                ItemPoolLevel1.CriticalPhoton(),

                //Level 2 items
                ItemPoolLevel2.IronIngot(),
                ItemPoolLevel2.Magnet(),
                ItemPoolLevel2.CopperIngot(),
                ItemPoolLevel2.RefinedOil(),
                ItemPoolLevel2.Hydrogen(),
                ItemPoolLevel2.EnergeticGraphite(),
                ItemPoolLevel2.StoneBrick(),
                ItemPoolLevel2.TitaniumIngot(),
                ItemPoolLevel2.Antimatter(),
                ItemPoolLevel2.ProliferatorMkI(),

                //Level 3 items
                ItemPoolLevel3.MagneticCoil(),
                ItemPoolLevel3.CircuitBoard(),
                ItemPoolLevel3.Gear(),
                ItemPoolLevel3.Steel(),
                ItemPoolLevel3.SulfuricAcid(),
                ItemPoolLevel3.EnergyMatrix(),
                ItemPoolLevel3.Glass(),
                ItemPoolLevel3.HighPuritySilicon(),
                ItemPoolLevel3.Diamond(),
                ItemPoolLevel3.HydrogenFuelRod(),
                ItemPoolLevel3.Plastic(),
                ItemPoolLevel3.Deuterium(),

                //Level 4 items
                ItemPoolLevel4.ElectromagneticMatrix(),
                ItemPoolLevel4.ElectricMotor(),
                ItemPoolLevel4.Prism(),
                ItemPoolLevel4.CrystalSilicon(),
                ItemPoolLevel4.MicrocrystallineComponent(),
                ItemPoolLevel4.Graphene(),
                ItemPoolLevel4.OrganicCrystal(),
                ItemPoolLevel4.TitaniumGlass(),
                ItemPoolLevel4.Thruster(),
                ItemPoolLevel4.ProliferatorMkII(),

                //Level 5 items
                ItemPoolLevel5.PlasmaExciter(),
                ItemPoolLevel5.PhotonCombiner(),
                ItemPoolLevel5.ElectromagneticTurbine(),
                ItemPoolLevel5.TitaniumAlloy(),
                ItemPoolLevel5.Processor(),
                ItemPoolLevel5.CarbonNanotube(),
                ItemPoolLevel5.TitaniumCrystal(),

                //Level 6 items
                ItemPoolLevel6.SuperMagneticRing(),
                ItemPoolLevel6.StructureMatrix(),
                ItemPoolLevel6.ParticleBroadband(),
                ItemPoolLevel6.ParticleContainer(),
                ItemPoolLevel6.CasimirCrystal(),
                ItemPoolLevel6.ReinforcedThruster(),
                ItemPoolLevel6.SolarSail(),
                ItemPoolLevel6.ProliferatorMkIII(),

                //Level 7 items
                ItemPoolLevel7.StrangeMatter(),
                ItemPoolLevel7.InformationMatrix(),
                ItemPoolLevel7.PlaneFilter(),
                ItemPoolLevel7.FrameMaterial(),
                ItemPoolLevel7.AnnihilationConstraintSphere(),
                ItemPoolLevel7.DeuteronFuelRod(),

                //Level 8 items
                ItemPoolLevel8.GravitonLens(),
                ItemPoolLevel8.QuantumChip(),
                ItemPoolLevel8.DysonSphereComponent(),

                //Level 9 items
                ItemPoolLevel9.GravityMatrix(),
                ItemPoolLevel9.SpaceWarper(),

                //Level 10 items
                ItemPoolLevel10.UniverseMatrix()

            };

            //Include buildings
            if (includeBuildings == true)
            {
                List<Item> buildings = new()
                {
                    BuildingsNoScience.ConveyorBeltMkI(),

                    BuildingsPreBlueScience.TeslaTower(),
                    BuildingsPreBlueScience.WindTurbine(),
                    BuildingsPreBlueScience.SorterMkI(),
                    BuildingsPreBlueScience.AssemblingMachineMkI(),
                    BuildingsPreBlueScience.MiningMachine(),
                    BuildingsPreBlueScience.ArcSmelter(),
                    BuildingsPreBlueScience.StorageMkI(),
                    BuildingsPreBlueScience.MatrixLab(),

                    BuildingsBlueScience.WirelessPowerTower(),
                    BuildingsBlueScience.ThermalPowerPlant(),
                    BuildingsBlueScience.SolarPanel(),
                    BuildingsBlueScience.Splitter(),
                    BuildingsBlueScience.OilExtractor(),
                    BuildingsBlueScience.OilRefinery(),
                    BuildingsBlueScience.WaterPump(),
                    BuildingsBlueScience.StorageTank(),
                    BuildingsBlueScience.SorterMkII(),
                    BuildingsBlueScience.TrafficMonitor(),
                    BuildingsBlueScience.ChemicalPlant(),
                    BuildingsBlueScience.SprayCoater(),
                    BuildingsBlueScience.Foundation(),

                    BuildingsRedScience.Accumulator(),
                    BuildingsRedScience.StorageMkII(),
                    BuildingsRedScience.ConveyorBeltMkII(),
                    BuildingsRedScience.AssemblingMachineMkII(),
                    BuildingsRedScience.ConveyorBeltMkIII(),
                    BuildingsRedScience.SorterMkIII(),
                    BuildingsRedScience.Fractionator(),
                    BuildingsRedScience.EMRailEjector(),
                    BuildingsRedScience.RayReceiver(),
                    BuildingsRedScience.PlanetaryLogisticsStation(),
                    BuildingsRedScience.LogisticsDrone(),

                    BuildingsYellowScience.SatelliteSubstation(),
                    BuildingsYellowScience.MiniFusionPowerPlant(),
                    BuildingsYellowScience.EnergyExchanger(),
                    BuildingsYellowScience.FullAccumulator(),
                    BuildingsYellowScience.MiniatureParticleCollider(),
                    BuildingsYellowScience.InterstellarLogisticsStation(),
                    BuildingsYellowScience.OrbitalCollector(),
                    BuildingsYellowScience.AutomaticPiler(),
                    BuildingsYellowScience.LogisticsVessel(),

                    BuildingsPurpleScience.AssemblingMachineMkIII(),
                    BuildingsPurpleScience.PlaneSmelter(),
                    BuildingsPurpleScience.VerticalLaunchingSilo(),
                    BuildingsPurpleScience.SmallCarrierRocket(),

                    BuildingsGreenScience.ArtificialStar(),
                    BuildingsGreenScience.AdvancedMiningMachine(),

                    //BuildingsWhiteScience.(),
                };
                items.AddRange(buildings);
            }

            //Filter by science level
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (items[i].ResearchType > researchType)
                {
                    items.RemoveAt(i);
                }
            }

            //Filter by name
            if (string.IsNullOrEmpty(nameFilter) == false)
            {
                Item? filteredItem = FindItem(items, nameFilter);
                if (filteredItem == null)
                {
                    throw new Exception(nameFilter + " item not found");
                }
                else
                {
                    List<Item> filteredItems = new();
                    //Add the root - this is the final item
                    filteredItems.Add(filteredItem);

                    //Get all of the inputs leading up to it
                    filteredItems.AddRange(GetInputs(items, filteredItem.Recipes));

                    //Sort the items by level
                    filteredItems = filteredItems.OrderBy(b => b.Level).ToList();
                    items = filteredItems;
                }
            }

            //If enabled, only show the direct inputs to product an item
            if (showOnlyDirectDependencies == true)
            {
                Dictionary<string, int> inputs = new();
                List<Item> filteredItems = new();
                foreach (Item? item in items)
                {
                    if (item.ItemType != ItemType.Building)
                    {
                        //If the item is not a building, hide it's recipe
                        item.Recipes = new List<Recipe>();
                    }
                    else
                    {
                        //If it is a building, log all of it's inputs
                        foreach (Recipe? recipe in item.Recipes)
                        {
                            foreach (KeyValuePair<string, int> input in recipe.Inputs)
                            {
                                if (inputs.ContainsKey(input.Key) == false)
                                {
                                    inputs.Add(input.Key, 1);
                                }
                            }
                        }
                    }
                }

                //Add each item to the filter.
                foreach (Item? item in items)
                {
                    if (!filteredItems.Contains(item) &&
                        (item.ItemType == ItemType.Building ||
                        inputs.ContainsKey(item.Name)))
                    {
                        filteredItems.Add(item);
                    }
                }

                items = filteredItems;
            }

            //for (int i = 0; i < items.Count; i++)
            //{
            //    Item? item = items[i];
            //    if (item.Name == "Accumulator")
            //    {
            //        int j = i;
            //    }
            //}

            return items;
        }

        //Get recipe inputs
        private static List<Item> GetInputs(List<Item> items, List<Recipe> recipes)
        {
            List<Item> inputs = new();
            foreach (Recipe recipe in recipes)
            {
                foreach (KeyValuePair<string, int> item in recipe.Inputs)
                {
                    Item? inputItem = FindItem(items, item.Key);
                    if (inputItem != null && inputs.Contains(inputItem) == false)
                    {
                        inputs.Add(inputItem);
                        List<Item> newItems = GetInputs(items, inputItem.Recipes);
                        foreach (Item newItem in newItems)
                        {
                            if (newItem != null && inputs.Contains(newItem) == false)
                            {
                                inputs.Add(newItem);
                            }
                        }
                    }
                }
            }
            return inputs;
        }

        private static Item? FindItem(List<Item> items, string name)
        {
            return items.Where(i => i.Name == name).FirstOrDefault();
        }

    }
}
