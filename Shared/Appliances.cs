namespace ecohacksthing.Shared;

public class Appliance
{
    public int EnergyStarUniqueId { get; set; }
    public string BrandName { get; set; }
    public string ModelNumber { get; set; }
    public string Description { get; set; }
    public double EnergyUse { get; set; }
    public string Materials { get; set; }
    public double ObtainRawMaterialEmissions { get; set; }
    public double RefiningManufacturingEmissions { get; set; }
    public double EstimatedLifespanEmissions { get; set; }
    public double Price { get; set; }
}