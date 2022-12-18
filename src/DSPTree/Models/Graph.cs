namespace DSPTree.Models
{
    public class Graph
    {
        public List<Node> Nodes { get; set; }
        public List<Link> Links { get; set; }

        public Graph(List<Item> data)
        {
            Nodes = new();
            Links = new();
     
            //Build the graph
            foreach (Item item in data)
            {
                //Create first item
                Node newNode = new()
                {
                    name = item.Name.Replace(" ", "_"),
                    group = item.Level,
                    image = item.Image
                };
                //Add the node if it has an ID and the graph doesn't already contain an Id of that name
                if (newNode.name != null && !Nodes.Any(n => n.name == newNode.name))
                {
                    Nodes.Add(newNode);
                }

                //Create a link between this item and any pre-reqs
                if (item.Recipes.Count > 0)
                {
                    foreach (Recipe recipe2 in item.Recipes)
                    {
                        //recipe2.PrimaryMethodOfManufacture == true &&

                        if (recipe2.ManufactoringMethod != ManufactoringMethodType.Gathered)
                        {
                            foreach (KeyValuePair<string, int> itemInput in recipe2.Inputs)
                            {
                                Link newLink = new()
                                {
                                    Source = FindIndex(data, item.Name), //item.Name.Replace(" ", "_"),
                                    Target = FindIndex(data, itemInput.Key), // itemInput.Key.Replace(" ", "_"),
                                    Value = itemInput.Value //The width of the connection
                                };
                                if (newLink.Source >= 0 && newLink.Target >= 0 && !Links.Any(n => n.Source == newLink.Source && n.Target == newLink.Target))
                                {
                                    Links.Add(newLink);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static int FindIndex(List<Item> data, string name)
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
