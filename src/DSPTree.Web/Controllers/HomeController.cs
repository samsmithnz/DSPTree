using DSPTree.Models;
using DSPTree.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DSPTree.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        public IActionResult Index()
        {
            //Build the DSP graph
            DSPGraph dSPGraph = new();
            List<Item> Items = dSPGraph.Items;

            //Convert the DSP graph to a D3 graph object
            Graph graph = CreateGraph(Items);

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
        private Graph CreateGraph(List<Item> data)
        {
            Graph newGraph = new();
            data.OrderBy(b => b.Level);

            //Build the graph
            foreach (Item item in data)
            {
                //Create first item
                Node newNode = new()
                {
                    id = item.Name.Replace(" ", "_"),
                    group = item.Level
                };
                //Add the node if it has an ID and the graph doesn't already contain an Id of that name
                if (newNode.id != null && !newGraph.nodes.Any(n => n.id == newNode.id))
                {
                    newGraph.nodes.Add(newNode);
                }

                //Create a link between this item and any pre-reqs
                if (item.Recipe.Count > 0)
                {
                    foreach (KeyValuePair<string, int> prereqItem in item.Recipe)
                    {
                        Link newLink = new()
                        {
                            source = item.Name.Replace(" ", "_"),
                            target = prereqItem.Key.Replace(" ", "_"),
                            value = prereqItem.Value //The width of the connection
                        };
                        if (newLink.source != null && newLink.target != null && !newGraph.links.Any(n => n.source == newLink.source && n.target == newLink.target))
                        {
                            newGraph.links.Add(newLink);
                        }
                    }
                }
            }

            return newGraph;
        }
    }
}