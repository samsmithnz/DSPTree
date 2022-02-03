namespace DSPTree.Models
{
    //Recipe

    //Has inputs and outputs
    //Has processing time

    //Made in?
    //Gathered from?

    //Item's have multiple recipes.
    //These recipes have types (Gathered/mined, manufactured) 

    public class Item
    {
        public Item()
        {
            Recipe = new();
            Inputs = new();
            Outputs = new();
        }

        public string Name { get; set; }
        public string Image { get; set; }
        public Dictionary<string, decimal> Recipe { get; set; }
        public string ManufactoringMethod { get; set; }
        public int Level { get; set; }
        public bool HasAlternativeRareSource { get; set; }
        public Dictionary<string, int> Inputs { get; set; }
        public Dictionary<string, int> Outputs { get; set; }
        public decimal ProcessingTimeInSeconds { get; set; }
    }
}
