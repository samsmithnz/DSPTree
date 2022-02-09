using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DSPTree.Tests;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[TestClass]
public class BuildingTests
{
    [TestMethod]
    public void SolarPanelBuildingDoesNotExistTest()
    {
        //Arrange
        DSPGraph graph = new();
        string building = "Solar Panel";

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.IsTrue(graph.Items.Count > 0);
        Item? solarPanel = graph.Items.Where(i => i.Name == building).FirstOrDefault();
        Assert.IsNull(solarPanel);
    }

    [TestMethod]
    public void SolarPanelBuildingDoesExistTest()
    {
        //Arrange
        DSPGraph graph = new("", true);
        string building = "Solar Panel";

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.IsTrue(graph.Items.Count > 0);
        Item? solarPanel = graph.Items.Where(i => i.Name == building).FirstOrDefault();
        Assert.IsNotNull(solarPanel);
        Assert.AreEqual(building, solarPanel?.Name);
        Assert.AreEqual("Icon_Solar_Panel.png", solarPanel?.Image);
        Assert.AreEqual(4, solarPanel?.Level);
    }

}