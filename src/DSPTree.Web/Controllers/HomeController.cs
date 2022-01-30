using DSPTree.Models;
using DSPTree.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DSPTree.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Item> Items = new();

            //Level 1 items (all mined ore)
            Items.Add(new Item()
            {
                Name = "Iron Ore",
                Image = "Icon_Iron_Ore.png",
                ManufactoringMethod = "Arc Smelter",
                Level = 1
            });

            Items.Add(new Item()
            {
                Name = "Copper Ore",
                Image = "Icon_Copper_Ore.png",
                ManufactoringMethod = "Arc Smelter",
                Level = 1
            });

            //Level 2 items
            Items.Add(new Item()
            {
                Name = "Iron Ingot",
                Image = "Icon_Iron_Ingot.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Iron Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            Items.Add(new Item()
            {
                Name = "Magnet",
                Image = "Icon_Magnet.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Iron Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });
            Items.Add(new Item()
            {
                Name = "Copper Ingot",
                Image = "Icon_Copper_Ingot.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Copper Ore", 1 }
                },
                ManufactoringMethod = "Arc Smelter",
                Level = 2
            });

            //Level 3 items
            Items.Add(new Item()
            {
                Name = "Magnetic Coil",
                Image = "Icon_Magnetic_Coil.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Copper Ingot", 1 },
                    { "Magnet", 2 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 3
            });
            Items.Add(new Item()
            {
                Name = "Circuit Board",
                Image = "Icon_Circuit_Board.png",
                Recipe = new Dictionary<string, int>()
                {
                    { "Copper Ingot", 1 },
                    { "Iron Ingot", 2 }
                },
                ManufactoringMethod = "Assembling Machine",
                Level = 3
            });

            //Build the graph object
            Graph graph = CreateGraph(Items);

            //Convert to Json and return the result
            string result = JsonConvert.SerializeObject(graph);
            return View(model: result);


        }

        public IActionResult Privacy()
        {
            return View();
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