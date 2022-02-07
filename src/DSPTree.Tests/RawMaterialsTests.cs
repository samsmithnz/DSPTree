using DSPTree.Helpers;
using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DSPTree.Tests;

[TestClass]
public class RawMaterialsTests
{

    [TestMethod]
    public void CopperIngotRawMaterialsTest()
    {
        //Arrange
        DSPGraph graph = new();
        Item2 startingItem = ItemPoolLevel1.CopperIngot();

        //Act
        Dictionary<string, int> rawMaterials = RawMaterials.CalculateRawMaterials(graph.Items2, startingItem);

        //Assert
        //1 Copper Ore -> Copper Ingot
        Assert.AreEqual(1, rawMaterials.Count);
        Assert.IsTrue(rawMaterials.ContainsKey("Copper Ore"));
        Assert.AreEqual(1, rawMaterials["Copper Ore"]);
    }

    [TestMethod]
    public void MagneticCoilRawMaterialsTest()
    {
        //Arrange
        DSPGraph graph = new();
        Item2 startingItem = ItemPoolLevel1.MagneticCoil();

        //Act
        Dictionary<string, int> rawMaterials = RawMaterials.CalculateRawMaterials(graph.Items2, startingItem);

        //Assert
        //2 Iron Ore-> 2 Magnets
        //1 Copper Ore -> Copper Ingot
        //2 Magnets + 1 Copper Ingot -> 2 Magnetic coils
        //Therefore, 2 iron ore + 1 copper ore.
        //Potentially 1 iron ore and 1/2 Copper ore, if we are really just talking about 1 magnetic coil
        Assert.AreEqual(2, rawMaterials.Count);
        Assert.IsTrue(rawMaterials.ContainsKey("Copper Ore"));
        Assert.AreEqual(1, rawMaterials["Copper Ore"]);
        Assert.IsTrue(rawMaterials.ContainsKey("Iron Ore"));
        Assert.AreEqual(2, rawMaterials["Iron Ore"]);
    }
}