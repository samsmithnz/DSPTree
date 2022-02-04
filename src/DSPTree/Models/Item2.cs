namespace DSPTree.Models
{
    public class Item2
    {
        public Item2(string name, string image, int level)
        {
            Name = name;
            Image = image;
            Recipes = new();
            Level = level;
        }

        public string Name { get; set; }
        public string Image { get; set; }
        public List<Recipe2> Recipes { get; set; }
        public int Level { get; set; }
    }
}
