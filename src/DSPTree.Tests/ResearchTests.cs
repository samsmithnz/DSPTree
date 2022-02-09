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
        DSPGraph graph = new("", ResearchType.NoScience);

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(17, graph.Items.Count);
    }

    [TestMethod]
    public void PreBlueScienceTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.PreBlueScience);

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(21, graph.Items.Count);
    }

    [TestMethod]
    public void BlueScienceTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.BlueScience);

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(39, graph.Items.Count);
    }

}