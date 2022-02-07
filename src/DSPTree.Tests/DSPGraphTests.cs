using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        Assert.AreEqual("Iron Ore", graph.Items[0].Name);
        Assert.AreEqual("Icon_Iron_Ore.png", graph.Items[0].Image);
        Assert.AreEqual("Mining Machine", graph.Items[0].ManufactoringMethod);
        Assert.AreEqual(1, graph.Items[0].Level);
    }

    [TestMethod]
    public void MatrixTest()
    {
        //Arrange
        DSPGraph graph = new();

        //Act

        //Assert

        foreach (Item2 item in graph.Items2)
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
        DSPGraph graph = new();

        //Act

        //Assert

        foreach (Item item in graph.Items)
        {
            foreach (KeyValuePair<string, decimal> itemChild in item.Recipe)
            {
                if (!graph.Items.Where(a => a.Name == itemChild.Key).Any())
                {
                    Assert.AreEqual("child not found", itemChild.Key);
                }
            }
        }
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void Tree2HasValidParentsAndChildrenTest()
    {
        //Arrange
        DSPGraph graph = new();

        //Act

        //Assert
        Dictionary<string, int> rawMaterials = new();
        foreach (Item2 item in graph.Items2)
        {
            foreach (Recipe2 recipe in item.Recipes)
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
            if (!graph.Items2.Where(a => a.Name == item.Key).Any())
            {
                Assert.AreEqual("child not found", item.Key);
            }
        }
        Assert.IsTrue(true);
    }
}