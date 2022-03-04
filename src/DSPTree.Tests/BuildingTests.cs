using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

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
        DSPGraph graph = new("", ResearchType.WhiteScience, true);
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

    [TestMethod]
    public void GetBuildingMaterialsTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.WhiteScience, true);

        //Act
        List<string> items = new();
        foreach (Item? item in graph.Items)
        {
            if (item.ItemType == ItemType.Building)
            {
                foreach (Recipe recipe in item.Recipes)
                {
                    StringBuilder sb = new();
                    sb.Append(item.Name);
                    foreach (System.Collections.Generic.KeyValuePair<string, int> input in recipe.Inputs)
                    {
                        sb.Append(input.Key);
                        sb.Append(',');
                    }
                    items.Add(sb.ToString());
                }
            }
        }

        //Assert
        Assert.IsNotNull(items);
        Assert.IsTrue(items.Count > 0);
        foreach (string item in items)
        {
            Debug.WriteLine(item);
        }

    }



}