namespace DSPTree.Models
{
    public class Item
    {
        public Item(int level,
            string name,
            string image,
            ItemType itemType = ItemType.Item,
            ResearchType researchType = ResearchType.WhiteScience)
        {
            Level = level;
            Name = name;
            Image = image;
            Recipes = new();
            ItemType = itemType;
            ResearchType = researchType;
        }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public ItemType ItemType { get; set; }
        public ResearchType ResearchType { get; set; }
        public List<Recipe> Recipes { get; set; }
    }

    public enum ItemType
    {
        All = 0,
        Item = 1,
        Building = 2
    }

    public enum ResearchType
    {
        NoScience = 0,
        PreBlueScience = 1,
        BlueScience = 2,
        RedScience = 3,
        YellowScience = 4,
        PurpleScience = 5,
        GreenScience = 6,
        WhiteScience = 7
    }
}
