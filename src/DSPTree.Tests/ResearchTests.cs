using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

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

    [TestMethod]
    public void WhiteScienceAllItemsTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.WhiteScience, true);

        //Act
        StringBuilder sb = new();
        foreach (Item item in graph.Items)
        {
            sb.Append(item.Name + ',');
        }

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(141, graph.Items.Count);
    }

    [TestMethod]
    public void WhiteScienceAllItemsNoBuildingsTest()
    {
        //Arrange
        DSPGraph graph = new("", ResearchType.WhiteScience, false);

        //Act
        StringBuilder sb = new();
        foreach (Item item in graph.Items)
        {
            sb.Append(item.Name + ',');
        }
        
        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(89, graph.Items.Count);
        Assert.AreEqual("Iron Ore Vein,Copper Ore Vein,Crude Oil Vein,Stone Vein,Coal Vein,Titanium Ore Vein,Silicon Ore Vein,Unipolar Magnet Vein,Kimberlite Ore Vein,Fractal Silicon Vein,Optical Grating Rock,Spiniform Stalagmite Crystal Vein,Fire Ice Vein,Log,Plant Fuel,Iron Ore,Copper Ore,Water,Crude Oil,Stone,Coal,Titanium Ore,Silicon Ore,Unipolar Magnet,Kimberlite Ore,Fractal Silicon,Optical Grating Crystal,Spiniform Stalagmite Crystal,Fire Ice,Critical Photon,Iron Ingot,Magnet,Copper Ingot,Refined Oil,Hydrogen,Energetic Graphite,Stone Brick,Titanium Ingot,Antimatter,Proliferator Mk.I,Magnetic Coil,Circuit Board,Gear,Steel,Sulfuric Acid,Energy Matrix,Glass,High-Purity Silicon,Diamond,Hydrogen Fuel Rod,Plastic,Deuterium,Electromagnetic Matrix,Electric Motor,Prism,Crystal Silicon,Microcrystalline Component,Graphene,Organic Crystal,Titanium Glass,Thruster,Proliferator Mk.II,Plasma Exciter,Photon Combiner,Electromagnetic Turbine,Titanium Alloy,Processor,Carbon Nanotube,Titanium Crystal,Super-Magnetic Ring,Structure Matrix,Particle Broadband,Particle Container,Casimir Crystal,Reinforced Thruster,Solar Sail,Proliferator Mk.III,Strange Matter,Information Matrix,Plane Filter,Frame Material,Annihilation Constraint Sphere,Deuteron Fuel Rod,Graviton Lens,Quantum Chip,Dyson Sphere Component,Gravity Matrix,Space Warper,Universe Matrix,", sb.ToString());
    }

}