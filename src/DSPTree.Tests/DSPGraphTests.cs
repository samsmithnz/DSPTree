using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        Assert.AreEqual("Iron Ore", graph.Items[0].Name  );
        Assert.AreEqual("Icon_Iron_Ore.png", graph.Items[0].Image);
        Assert.AreEqual("Arc Smelter", graph.Items[0].ManufactoringMethod);
        Assert.AreEqual(1, graph.Items[0].Level);
    }

    [TestMethod]
    public void RawMaterialsTest()
    {
        //Arrange
        DSPGraph graph = new();

        //Act

        //Assert
        
        foreach (Item item in graph.Items)
        {
            if (item.Level == 1 && 
                item.ManufactoringMethod != "Arc Smelter" &&
                item.ManufactoringMethod != "Oil Extractor" &&
                item.ManufactoringMethod != "Water Pump")
            {
                Assert.AreEqual("", item.Name);
                Assert.IsTrue(false);
            }
        }
    }
}