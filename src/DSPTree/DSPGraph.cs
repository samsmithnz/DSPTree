using DSPTree.Helpers;
using DSPTree.Models;

namespace DSPTree
{
    public class DSPGraph
    {
        public List<Item> Items { get; set; }
        public DSPGraph(string filter = "")
        {
            Items = BuildDSPTree(filter);
        }

        private static List<Item> BuildDSPTree(string filter)
        {
            List<Item> items = new()
            {
                ItemPoolLevel0.IronOreVein(),
                ItemPoolLevel0.CopperOreVein(),
                ItemPoolLevel0.CrudeOilVein(),
                ItemPoolLevel0.StoneVein(),
                ItemPoolLevel0.CoalVein(),
                ItemPoolLevel0.TitaniumOreVein(),
                ItemPoolLevel0.SiliconOreVein(),

                //Level 1 items (mostly mined ore)
                ItemPoolLevel1.IronOre(),
                ItemPoolLevel1.CopperOre(),
                ItemPoolLevel1.Water(),
                ItemPoolLevel1.CrudeOil(),
                ItemPoolLevel1.Stone(),
                ItemPoolLevel1.Coal(),
                ItemPoolLevel1.TitaniumOre(),
                ItemPoolLevel1.SiliconOre(),

                //Level 2 items
                ItemPoolLevel2.IronIngot(),
                ItemPoolLevel2.Magnet(),
                ItemPoolLevel2.CopperIngot(),
                ItemPoolLevel2.RefinedOil(),
                ItemPoolLevel2.Hydrogen(),
                ItemPoolLevel2.EnergeticGraphite(),
                ItemPoolLevel2.StoneBrick(),
                ItemPoolLevel2.TitaniumIngot(),

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

                //Level 4 items
                ItemPoolLevel4.ElectromagneticMatrix(),
                ItemPoolLevel4.ElectricMotor(),
                ItemPoolLevel4.Foundation(),
                ItemPoolLevel4.SolarPanels(),
                ItemPoolLevel4.Prism(),
                ItemPoolLevel4.CrystalSilicon(),
                ItemPoolLevel4.MicrocrystallineComponent(),
                ItemPoolLevel4.Graphene(),
                ItemPoolLevel4.OrganicCrystal(),
                ItemPoolLevel4.TitaniumGlass(),

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

                //Level 7 items
                ItemPoolLevel7.StrangeMatter(),
                ItemPoolLevel7.InformationMatrix(),
                ItemPoolLevel7.PlaneFilter(),

                //Level 8 items
                ItemPoolLevel8.GravitonLens(),
                ItemPoolLevel8.QuantumChip(),

                //Level 9 items
                ItemPoolLevel9.GravityMatrix()
            };

            //Filter by
            if (string.IsNullOrEmpty(filter) == false)
            {
                Item? filteredItem = FindItem(items, filter);
                if (filteredItem == null)
                {
                    throw new Exception(filter + " item not found");
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

            return items;
        }

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
