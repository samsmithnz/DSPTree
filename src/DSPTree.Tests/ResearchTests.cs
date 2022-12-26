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
        Assert.AreEqual(137, graph.Items.Count);
        Assert.AreEqual("Iron Ore Vein,Copper Ore Vein,Crude Oil Vein,Stone Vein,Coal Vein,Titanium Ore Vein,Silicon Ore Vein,Unipolar Magnet Vein,Kimberlite Ore Vein,Fractal Silicon Vein,Optical Grating Rock,Spiniform Stalagmite Crystal Vein,Fire Ice Vein,Log,Plant Fuel,Iron Ore,Copper Ore,Water,Crude Oil,Stone,Coal,Titanium Ore,Silicon Ore,Unipolar Magnet,Kimberlite Ore,Fractal Silicon,Optical Grating Crystal,Spiniform Stalagmite Crystal,Fire Ice,Critical Photon,Iron Ingot,Magnet,Copper Ingot,Refined Oil,Hydrogen,Energetic Graphite,Stone Brick,Titanium Ingot,Antimatter,Proliferator Mk.I,Magnetic Coil,Circuit Board,Gear,Steel,Sulfuric Acid,Energy Matrix,Glass,High-Purity Silicon,Diamond,Hydrogen Fuel Rod,Plastic,Deuterium,Electromagnetic Matrix,Electric Motor,Prism,Crystal Silicon,Microcrystalline Component,Graphene,Organic Crystal,Titanium Glass,Thruster,Proliferator Mk.II,Plasma Exciter,Photon Combiner,Electromagnetic Turbine,Titanium Alloy,Processor,Carbon Nanotube,Titanium Crystal,Super-Magnetic Ring,Structure Matrix,Particle Broadband,Particle Container,Casimir Crystal,Reinforced Thruster,Solar Sail,Proliferator Mk.III,Strange Matter,Information Matrix,Plane Filter,Frame Material,Annihilation Constraint Sphere,Deuteron Fuel Rod,Graviton Lens,Quantum Chip,Dyson Sphere Component,Gravity Matrix,Space Warper,Universe Matrix,Conveyor Belt Mk.I,Tesla Tower,Wind Turbine,Sorter Mk.I,Assembling Machine Mk.I,Mining Machine,Arc Smelter,Storage Mk.I,Matrix Lab,Wireless Power Tower,Thermal Power Plant,Solar Panel,Splitter,Oil Extractor,Oil Refinery,Water Pump,Storage Tank,Sorter Mk.II,Traffic Monitor,Chemical Plant,Spray Coater,Foundation,Accumulator,Storage Mk.II,Conveyor Belt Mk.II,Assembling Machine Mk.II,Conveyor Belt Mk.III,Sorter Mk.III,Fractionator,EM-Rail Ejector,Ray Receiver,Planetary Logistics Station,Logistics Drone,Satellite Substation,Mini Fusion Power Plant,Energy Exchanger,Full Accumulator,Miniature Particle Collider,Interstellar Logistics Station,Orbital Collector,Automatic Piler,Logistics Vessel,Assembling Machine Mk.III,Plane Smelter,Vertical Launching Silo,Small Carrier Rocket,Artificial Star,Advanced Mining Machine,", sb.ToString());
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