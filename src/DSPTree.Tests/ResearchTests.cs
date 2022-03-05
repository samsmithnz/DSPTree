using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSPTree.Tests;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[TestClass]
public class ResearchTests
{
    [TestMethod]
    public void NoScienceTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.NoScience, true);

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(35, graph.Items.Count);
    }

    [TestMethod]
    public void PreBlueScienceTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.PreBlueScience, true);

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(45, graph.Items.Count);
    }

    [TestMethod]
    public void BlueScienceTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.BlueScience, true);

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(75, graph.Items.Count);
    }

}