namespace DSPTree.Models
{
    public class Graph
    {
        public List<Node> nodes;
        public List<Link> links;

        public Graph(List<Item> data)
        {
            nodes = new();
            links = new();
     
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
                if (newNode.name != null && !nodes.Any(n => n.name == newNode.name))
                {
                    nodes.Add(newNode);
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
                                    source = FindIndex(data, item.Name), //item.Name.Replace(" ", "_"),
                                    target = FindIndex(data, itemInput.Key), // itemInput.Key.Replace(" ", "_"),
                                    value = itemInput.Value //The width of the connection
                                };
                                if (newLink.source >= 0 && newLink.target >= 0 && !links.Any(n => n.source == newLink.source && n.target == newLink.target))
                                {
                                    links.Add(newLink);
                                }
                            }
                        }
                    }
                }
            }
        }

        private int FindIndex(List<Item> data, string name)
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
