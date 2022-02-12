using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DSPTree.Tests;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[TestClass]
public class DSPGraphTests
{
    [TestMethod]
    public void DSPGraphTest()
    {
        //Arrange
        DSPGraph graph = new();

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.IsTrue(graph.Items.Count > 0);
        Assert.AreEqual("Iron Ore Vein", graph.Items[0].Name);
        Assert.AreEqual("80px-Icon_Iron_Ore_Vein.png", graph.Items[0].Image);
        Assert.AreEqual(0, graph.Items[0].Level);
    }

    [TestMethod]
    public void MatrixTest()
    {
        //Arrange
        DSPGraph graph = new();

        //Act

        //Assert

        foreach (Item item in graph.Items)
        {
            if ((item.Name.ToLower().Contains("matrix") == true &&
                item.Recipes[0].ManufactoringBuilding != ManufactoringBuildingType.MatrixLab) ||
                (item.Name.ToLower().Contains("matrix") == false &&
                item.Recipes[0].ManufactoringBuilding == ManufactoringBuildingType.MatrixLab))
            {
                Assert.AreEqual("", item.Name);
                Assert.IsTrue(false);
            }
        }
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void TreeHasValidParentsAndChildrenTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.WhiteScience, true);

        //Act

        //Assert
        Dictionary<string, int> rawMaterials = new();
        foreach (Item item in graph.Items)
        {
            foreach (Recipe recipe in item.Recipes)
            {
                //Check each input (if it's not gathered)
                foreach (KeyValuePair<string, int> input in recipe.Inputs)
                {
                    if (recipe.ManufactoringMethod != ManufactoringMethodType.Gathered)
                    {
                        if (!rawMaterials.ContainsKey(input.Key) == true)
                        {
                            rawMaterials.Add(input.Key, input.Value);
                        }
                    }
                }
                //Check each output (if it's not gathered)
                foreach (KeyValuePair<string, int> output in recipe.Outputs)
                {
                    if (recipe.ManufactoringMethod != ManufactoringMethodType.Gathered)
                    {
                        if (!rawMaterials.ContainsKey(output.Key) == true)
                        {
                            rawMaterials.Add(output.Key, output.Value);
                        }
                    }
                }
            }
        }
        foreach (KeyValuePair<string, int> item in rawMaterials)
        {
            if (!graph.Items.Where(a => a.Name == item.Key).Any())
            {
                Assert.AreEqual("child not found", item.Key);
            }
        }
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void TreeImageIsUsedOnlyOnceTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.WhiteScience, true);

        //Act

        //Assert
        HashSet<string> images = new();
        foreach (Item item in graph.Items)
        {
            if (images.Contains(item.Image) == true)
            {
                Assert.AreEqual("", item.Image);
            }
            images.Add(item.Image);
        }
    }

    [TestMethod]
    public void FilterBlueScienceTest()
    {
        //Arrange
        string filter = "Electromagnetic Matrix";
        DSPGraph graph = new(filter);

        //Act

        //Assert
        Assert.IsTrue(graph.Items.Count > 1);
        Assert.AreEqual(filter, graph.Items[graph.Items.Count - 1].Name);
    }

    [TestMethod]
    public void FilterRedScienceTest()
    {
        //Arrange
        string filter = "Energy Matrix";
        DSPGraph graph = new(filter);

        //Act

        //Assert
        Assert.IsTrue(graph.Items.Count > 1);
        Assert.AreEqual(filter, graph.Items[graph.Items.Count - 1].Name);
    }

    [TestMethod]
    public void FilterItemThatDoesNotExistTest()
    {
        //Arrange
        string filter = "Widget";

        //Act
        try
        {
            DSPGraph graph = new(filter);
        }
        catch (Exception ex)
        {
            //Assert
            Assert.AreEqual("Widget item not found", ex.Message);
        }

    }
}