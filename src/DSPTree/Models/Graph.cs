namespace DSPTree.Models
{
    public class Graph
    {
        public List<Node> Nodes;
        public List<Link> Links;

        public Graph()
        {
            Nodes = new();
            Links = new();
        }
    }
}
