﻿using DSPTree.Models;

namespace DSPTree
{
    public static class RawMaterials
    {
        public static Dictionary<string, int> CalculateRawMaterials(List<Item2> items, Item2 item)
        {
            if (items == null)
            {
                throw new InvalidOperationException("Items list is not initialized - something bad happened given this is initialized in the class constructor");
            }

            //For the primary recipe, look at the inputs.
            //If the input is not a gathered input, look at those items inputs,
            //adding together all of the resource totals until we find the gatherer.
            //For the initial raw materials, we always want to use a factor of 1, as it's already part of the outputs calculation
            int count = 1;
            Dictionary<string, int> rawMaterials = GetRawMaterials(items, item, count);

            return rawMaterials;
        }

        private static Dictionary<string, int> GetRawMaterials(List<Item2> items, Item2 item, int count)
        {
            Dictionary<string, int> rawMaterials = new();

            foreach (Recipe2 recipe in item.Recipes)
            {
                //get each items materials recursively, summing up all of the items
                if (recipe.PrimaryMethodOfManufacture == true)
                {
                    foreach (KeyValuePair<string, int> input in recipe.Inputs)
                    {
                        Item2? inputItem = FindItem(items, input.Key);
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
                                        Item2? detailedItem = FindItem(items, input.Key);
                                        if (detailedItem != null)
                                        {
                                            int detailedCount = 0;
                                            foreach (Recipe2 detailedRecipe in detailedItem.Recipes)
                                            {
                                                //get each items materials recursively, summing up all of the items
                                                if (detailedRecipe.PrimaryMethodOfManufacture == true)
                                                {
                                                    detailedCount = recipe.Inputs[detailedItem.Name];
                                                }
                                            }
                                            Dictionary<string, int>? rawMaterialsNextLevel = GetRawMaterials(items, detailedItem, detailedCount);
                                            foreach (KeyValuePair<string, int> rawMaterialNextLevel in rawMaterialsNextLevel)
                                            {
                                                if (rawMaterials.ContainsKey(rawMaterialNextLevel.Key))
                                                {
                                                    rawMaterials[rawMaterialNextLevel.Key] += rawMaterialNextLevel.Value;
                                                }
                                                else
                                                {
                                                    rawMaterials.Add(rawMaterialNextLevel.Key, rawMaterialNextLevel.Value);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Now apply the counts
            foreach (KeyValuePair<string, int> rawMaterial in rawMaterials)
            {
                rawMaterials[rawMaterial.Key] *= count;
            }
            return rawMaterials;
        }

        private static Item2? FindItem(List<Item2> items, string name)
        {
            Item2? item = null;
            if (items != null)
            {
                item = items.Where(x => x.Name == name).FirstOrDefault();
            }
            return item;
        }

    }
}