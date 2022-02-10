namespace DSPTree.Models
{
    public class Recipe
    {
        public Recipe(
            decimal processingTimeInSeconds,
            Dictionary<string, int> inputs,
            Dictionary<string, int> outputs,
            ManufactoringBuildingType manufactoringBuilding,
            ManufactoringMethodType manufactoringMethod = ManufactoringMethodType.Manufactured,
            bool primaryMethodOfManufacture = true)
        {
            ProcessingTimeInSeconds = processingTimeInSeconds;
            Inputs = inputs;
            Outputs = outputs;
            ManufactoringBuilding = manufactoringBuilding;
            ManufactoringMethod = manufactoringMethod;
            PrimaryMethodOfManufacture = primaryMethodOfManufacture;
        }
        public decimal ProcessingTimeInSeconds { get; internal set; }
        public Dictionary<string, int> Inputs { get; set; }
        public Dictionary<string, int> Outputs { get; set; }
        public ManufactoringBuildingType ManufactoringBuilding { get; set; }
        public ManufactoringMethodType ManufactoringMethod { get; set; }
        public bool PrimaryMethodOfManufacture { get; set; }
    }

    public enum ManufactoringMethodType
    {
        Gathered = 0,
        Manufactured = 1
    }

    public enum ManufactoringBuildingType
    {
        MiningMachine = 0,
        Smelter = 1,
        AssemblingMachine = 2,
        WaterPump = 3,
        OilExtractor = 4,
        OilRefinery = 5,
        ChemicalPlant = 6,
        MatrixLab = 7,
        MiniatureParticleCollider = 8,
        EnergyExchanger = 9,
        Fractionator = 10,
        RayReceiver = 11,
        None = 12
    }
}
