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
        Item startingItem = ItemPoolLevel2.CopperIngot();

        //Act
        Dictionary<string, int> rawMaterials = RawMaterials.CalculateRawMaterials(graph.Items, startingItem);

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
        Item startingItem = ItemPoolLevel3.MagneticCoil();

        //Act
        Dictionary<string, int> rawMaterials = RawMaterials.CalculateRawMaterials(graph.Items, startingItem);

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

    [TestMethod]
    public void QuantumChipRawMaterialsTest()
    {
        //Arrange
        DSPGraph graph = new();
        Item startingItem = ItemPoolLevel8.QuantumChip();

        //Act
        Dictionary<string, int> rawMaterials = RawMaterials.CalculateRawMaterials(graph.Items, startingItem);

        //Assert
        Assert.AreEqual(8, rawMaterials.Count);
        Assert.IsTrue(rawMaterials.ContainsKey("Copper Ore"));
        Assert.AreEqual(8, rawMaterials["Copper Ore"]);
        Assert.IsTrue(rawMaterials.ContainsKey("Iron Ore"));
        Assert.AreEqual(4, rawMaterials["Iron Ore"]);
        Assert.IsTrue(rawMaterials.ContainsKey("Silicon Ore"));
        Assert.AreEqual(16, rawMaterials["Silicon Ore"]);
        Assert.IsTrue(rawMaterials.ContainsKey("Titanium Ore"));
        Assert.AreEqual(28, rawMaterials["Titanium Ore"]);
        Assert.IsTrue(rawMaterials.ContainsKey("Crude Oil"));
        Assert.AreEqual(66, rawMaterials["Crude Oil"]);
        Assert.IsTrue(rawMaterials.ContainsKey("Stone"));
        Assert.AreEqual(24, rawMaterials["Stone"]);
        Assert.IsTrue(rawMaterials.ContainsKey("Water"));
        Assert.AreEqual(14, rawMaterials["Water"]);
        Assert.IsTrue(rawMaterials.ContainsKey("Coal"));
        Assert.AreEqual(16, rawMaterials["Coal"]);
    }
}