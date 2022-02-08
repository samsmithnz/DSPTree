﻿using DSPTree.Models;
using DSPTree.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DSPTree.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        public IActionResult Index2()
        {
            //Build the DSP graph
            DSPGraph dSPGraph = new();

            //Convert the DSP graph to a D3 graph object
            Graph2 graph = CreateGraph2(dSPGraph.Items2);

            //Convert to Json and return the result
            string result = JsonConvert.SerializeObject(graph);
            return View(model: result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //A generic function that creates a new graph object
        private static Graph2 CreateGraph2(List<Item2> data)
        {
            Graph2 newGraph = new();

            //Build the graph
            foreach (Item2 item in data)
            {
                //Create first item
                Node newNode = new()
                {
                    name = item.Name.Replace(" ", "_"),
                    group = item.Level,
                    image = item.Image
                };
                //Add the node if it has an ID and the graph doesn't already contain an Id of that name
                if (newNode.name != null && !newGraph.nodes.Any(n => n.name == newNode.name))
                {
                    newGraph.nodes.Add(newNode);
                }

                //Create a link between this item and any pre-reqs
                if (item.Recipes.Count > 0)
                {
                    foreach (Recipe2 recipe2 in item.Recipes)
                    {
                        //recipe2.PrimaryMethodOfManufacture == true &&

                        if (recipe2.ManufactoringMethod != ManufactoringMethodType.Gathered)
                        {
                            foreach (KeyValuePair<string, int> itemInput in recipe2.Inputs)
                            {
                                Link2 newLink = new()
                                {
                                    source = FindIndex(data, item.Name), //item.Name.Replace(" ", "_"),
                                    target = FindIndex(data, itemInput.Key), // itemInput.Key.Replace(" ", "_"),
                                    value = itemInput.Value //The width of the connection
                                };
                                if (newLink.source >= 0 && newLink.target >= 0 && !newGraph.links.Any(n => n.source == newLink.source && n.target == newLink.target))
                                {
                                    newGraph.links.Add(newLink);
                                }
                            }
                        }
                    }
                }
            }

            return newGraph;
        }

        private static int FindIndex(List<Item2> data, string name)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Name == name)
                {
                    return i;
                }
            }
            return 0;
        }

    }
}