namespace DSPTree.Models
{
    public class Item2
    {
        public Item2(int level, string name, string image)
        {
            Level = level;
            Name = name;
            Image = image;
            Recipes = new();
        }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Recipe2> Recipes { get; set; }
    }
}
