namespace DSPTree.Models
{
    public class Graph
    {
        public List<Node> nodes;
        public List<Link> links;

        public Graph()
        {
            nodes = new();
            links = new();
        }
    }
}
