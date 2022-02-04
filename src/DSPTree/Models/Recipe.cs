namespace DSPTree.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Inputs = new();
            Outputs = new();
        }
        public decimal ProcessingTimeInSeconds { get; set; }
        public Dictionary<string, int> Inputs { get; set; }
        public Dictionary<string, int> Outputs { get; set; }
        public ManufactoringMethodType ManufactoringMethod { get; set; }
        public ManufactoringBuildingType ManufactoringBuilding { get; set; }
        public bool PrimaryMethodOfManufacture { get; set; }
    }

}
