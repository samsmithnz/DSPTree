namespace DSPTree.Models
{
    public class Item2
    {
        public Item2(int level, string name, string image, ItemType itemType = ItemType.Item)
        {
            Level = level;
            Name = name;
            Image = image;
            Recipes = new();
            ItemType = itemType;
        }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public ItemType ItemType { get; set; }
        public List<Recipe2> Recipes { get; set; }
    }

    public enum ItemType
    {
        Item = 0,
        Building = 1
    }
}
