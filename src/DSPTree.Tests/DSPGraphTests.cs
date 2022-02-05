using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DSPTree.Tests;

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
    public void RawMaterialsTest()
    {
        //Arrange
        DSPGraph graph = new();
        Item2 startingItem = ItemPool.MagneticCoil();

        //Act
        Dictionary<string, int> rawMaterials = graph.CalculateRawMaterials(startingItem);

        //Assert
        Assert.AreEqual(2, rawMaterials.Count);
        foreach (KeyValuePair<string, int> item in rawMaterials)
        {
            if (item.Key == "Copper Ore")
            {
                Assert.AreEqual("Copper Ore", item.Key);
                Assert.AreEqual(1, item.Value);
            }
            //Assert.IsTrue(false);
            else
            {
                Assert.AreEqual("", item.Key);
            }
        }
        //Assert.IsTrue(true);

        //2 Iron Ore-> 2 Magnets
        //1 Copper Ore -> Copper Ingot
        //2 Magnets + 1 Copper Ingot -> 2 Magnetic coils
        //Therefore, 2 iron ore + 1 copper ore. Potentially 1 iron ore and 1/2 Copper ore, if we are really just talking about 1 magnetic coil

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
            if (item.Name.Contains("matrix") == true &&
                item.ManufactoringMethod != "Matrix Lab")
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
                if (graph.Items.Where(a => a.Name == itemChild.Key).Count() == 0)
                {
                    Assert.AreEqual("child not found", itemChild.Key);
                }
            }
        }
        Assert.IsTrue(true);
    }
}