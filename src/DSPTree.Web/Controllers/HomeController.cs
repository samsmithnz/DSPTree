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

        public IActionResult Index()
        {
            //Build the DSP graph. To filter, add the item name, e.g. "Copper Ingot", or "Gravity Matrix"
            string filter = "";
            DSPGraph dSPGraph = new(filter, 
                ResearchType.WhiteScience, 
                true,
                false);

            //Convert the DSP graph to a D3 graph object
            Graph graph = new(dSPGraph.Items);

            //Convert to Json and return the result
            string json = JsonConvert.SerializeObject(graph);
            return View(model: json);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}