namespace DSPTree.Models
{
    //Recipe

    //Has inputs and outputs
    //Has processing time

    //Made in?
    //Gathered from?

    //Item's have multiple recipes.
    //These recipes have types (Gathered/mined, manufactured) 
    //Specify a Default recipe, and alternative recipes, and a rare resource recipe

    public class Item
    {
        public Item()
        {
            Recipe = new();
            Recipes = new();
        }

        public string Name { get; set; }
        public string Image { get; set; }
        public List<Recipe> Recipes { get; set; }
        public Dictionary<string, decimal> Recipe { get; set; }
        public string ManufactoringMethod { get; set; }
        public int Level { get; set; }
        public bool HasAlternativeRareSource { get; set; }

        public decimal ProcessingTimeInSeconds { get; set; }
    }
}
