namespace DSPTree.Models
{
    public class Item
    {
        public Item(int level, string name, string image, ItemType itemType = ItemType.Item)
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
        public List<Recipe> Recipes { get; set; }
    }

    public enum ItemType
    {
        All = 0,
        Item = 1,
        Building = 2
    }
}
