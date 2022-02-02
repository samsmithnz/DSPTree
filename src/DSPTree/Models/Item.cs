namespace DSPTree.Models
{
    public class Item
    {
        public Item()
        {
            Recipe = new();
        }

        public string Name { get; set; }
        public string Image { get; set; }
        public Dictionary<string,decimal> Recipe { get; set; }
        public string ManufactoringMethod { get; set; }
        public int Level { get; set; }
        public bool HasAlternativeRareSource { get; set; }

    }
}
