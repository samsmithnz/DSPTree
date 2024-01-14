using DSPTree.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace DSPTree.Tests
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class AllItemsTests
    {
        [TestMethod]
        public void AllItemsNoScienceTest()
        {
            //Arrange
            DSPGraph graph = new(researchType: ResearchType.NoScience, onlyShowCurrentResearchLevel: true);

            //Act

            //Assert
            Assert.IsNotNull(graph);
            Assert.AreEqual(34, graph.Items.Count);
            //OutputList(graph.Items);
        }

        [TestMethod]
        public void AllItemsPreBlueScienceTest()
        {
            //Arrange
            DSPGraph graph = new(researchType: ResearchType.PreBlueScience, onlyShowCurrentResearchLevel: true);

            //Act

            //Assert
            Assert.IsNotNull(graph);
            Assert.AreEqual(2, graph.Items.Count);
            OutputList(graph.Items);
        }

        [TestMethod]
        public void AllItemsBlueScienceTest()
        {
            //Arrange
            DSPGraph graph = new(researchType: ResearchType.BlueScience, onlyShowCurrentResearchLevel: true);

            //Act

            //Assert
            Assert.IsNotNull(graph);
            Assert.AreEqual(2, graph.Items.Count);
            OutputList(graph.Items);
        }

        [TestMethod]
        public void AllItemsRedScienceTest()
        {
            //Arrange
            DSPGraph graph = new(researchType: ResearchType.RedScience, onlyShowCurrentResearchLevel: true);

            //Act

            //Assert
            Assert.IsNotNull(graph);
            Assert.AreEqual(2, graph.Items.Count);
            OutputList(graph.Items);
        }

        [TestMethod]
        public void AllItemsYellowScienceTest()
        {
            //Arrange
            DSPGraph graph = new(researchType: ResearchType.YellowScience, onlyShowCurrentResearchLevel: true);

            //Act

            //Assert
            Assert.IsNotNull(graph);
            Assert.AreEqual(2, graph.Items.Count);
            OutputList(graph.Items);
        }

        [TestMethod]
        public void AllItemsPurpleScienceTest()
        {
            //Arrange
            DSPGraph graph = new(researchType: ResearchType.PurpleScience, onlyShowCurrentResearchLevel: true);

            //Act

            //Assert
            Assert.IsNotNull(graph);
            Assert.AreEqual(2, graph.Items.Count);
            OutputList(graph.Items);
        }

        [TestMethod]
        public void AllItemsGreenScienceTest()
        {
            //Arrange
            DSPGraph graph = new(researchType: ResearchType.GreenScience, onlyShowCurrentResearchLevel: true);

            //Act

            //Assert
            Assert.IsNotNull(graph);
            Assert.AreEqual(2, graph.Items.Count);
            OutputList(graph.Items);
        }

        private static void OutputList(List<Item> items)
        {
            foreach (Item item in items)
            {
                foreach (Recipe recipe in item.Recipes)
                {
                    if (recipe.ManufactoringMethod == ManufactoringMethodType.Manufactured)
                    {
                        Debug.WriteLine(item.Name);
                    }
                }
            }
        }
    }
}
