using System.Text.Json.Serialization;

namespace FishWatch.Models;

public class ImageGallery
{
    [JsonPropertyName("src")] public string Src { get; set; }

    [JsonPropertyName("alt")] public string Alt { get; set; }

    [JsonPropertyName("title")] public string Title { get; set; }
}

public class Fish
{
    [JsonIgnore] public string Id => Path.Replace("/profiles/", "");

    [JsonPropertyName("Fishery Management")]
    public string FisheryManagement { get; set; }

    [JsonPropertyName("Habitat")] public object Habitat { get; set; }

    [JsonPropertyName("Habitat Impacts")] public string HabitatImpacts { get; set; }

    //[JsonPropertyName("Image Gallery")] public List<ImageGallery> ImageGallery { get; set; }

    [JsonPropertyName("Location")] public string Location { get; set; }

    [JsonPropertyName("Management")] public object Management { get; set; }

    [JsonPropertyName("NOAA Fisheries Region")]
    public string NOAAFisheriesRegion { get; set; }

    [JsonPropertyName("Population")] public string Population { get; set; }

    [JsonPropertyName("Population Status")]
    public string PopulationStatus { get; set; }

    [JsonPropertyName("Scientific Name")] public string ScientificName { get; set; }

    [JsonPropertyName("Species Aliases")] public string SpeciesAliases { get; set; }

    [JsonPropertyName("Species Illustration Photo")]
    public SpeciesIllustrationPhoto SpeciesIllustrationPhoto { get; set; }

    [JsonPropertyName("Species Name")] public string SpeciesName { get; set; }

    [JsonPropertyName("Animal Health")] public object AnimalHealth { get; set; }

    [JsonPropertyName("Availability")] public string Availability { get; set; }

    [JsonPropertyName("Biology")] public string Biology { get; set; }

    [JsonPropertyName("Bycatch")] public string Bycatch { get; set; }

    [JsonPropertyName("Calories")] public string Calories { get; set; }

    [JsonPropertyName("Carbohydrate")] public string Carbohydrate { get; set; }

    [JsonPropertyName("Cholesterol")] public string Cholesterol { get; set; }

    [JsonPropertyName("Color")] public string Color { get; set; }

    [JsonPropertyName("Disease Treatment and Prevention")]
    public object DiseaseTreatmentAndPrevention { get; set; }

    [JsonPropertyName("Diseases in Salmon")]
    public object DiseasesInSalmon { get; set; }

    [JsonPropertyName("Displayed Seafood Profile Illustration")]
    public object DisplayedSeafoodProfileIllustration { get; set; }

    [JsonPropertyName("Ecosystem Services")]
    public object EcosystemServices { get; set; }

    [JsonPropertyName("Environmental Considerations")]
    public object EnvironmentalConsiderations { get; set; }

    [JsonPropertyName("Environmental Effects")]
    public object EnvironmentalEffects { get; set; }

    [JsonPropertyName("Farming Methods")] public object FarmingMethods { get; set; }

    [JsonPropertyName("Fat, Total")] public string FatTotal { get; set; }

    [JsonPropertyName("Feeds")] public object Feeds { get; set; }

    [JsonPropertyName("Fiber, Total Dietary")]
    public string FiberTotalDietary { get; set; }

    [JsonPropertyName("Fishing Rate")] public string FishingRate { get; set; }

    [JsonPropertyName("Harvest")] public string Harvest { get; set; }

    [JsonPropertyName("Harvest Type")] public string HarvestType { get; set; }

    [JsonPropertyName("Health Benefits")] public string HealthBenefits { get; set; }

    [JsonPropertyName("Human Health")] public object HumanHealth { get; set; }

    [JsonPropertyName("Physical Description")]
    public string PhysicalDescription { get; set; }

    [JsonPropertyName("Production")] public object Production { get; set; }

    [JsonPropertyName("Protein")] public string Protein { get; set; }

    [JsonPropertyName("Quote")] public string Quote { get; set; }

    [JsonPropertyName("Quote Background Color")]
    public string QuoteBackgroundColor { get; set; }

    [JsonPropertyName("Research")] public object Research { get; set; }

    [JsonPropertyName("Saturated Fatty Acids, Total")]
    public string SaturatedFattyAcidsTotal { get; set; }

    [JsonPropertyName("Selenium")] public string Selenium { get; set; }

    [JsonPropertyName("Serving Weight")] public string ServingWeight { get; set; }

    [JsonPropertyName("Servings")] public string Servings { get; set; }

    [JsonPropertyName("Sodium")] public string Sodium { get; set; }

    [JsonPropertyName("Source")] public string Source { get; set; }

    [JsonPropertyName("Sugars, Total")] public string SugarsTotal { get; set; }

    [JsonPropertyName("Taste")] public string Taste { get; set; }

    [JsonPropertyName("Texture")] public string Texture { get; set; }

    [JsonPropertyName("Path")] public string Path { get; set; }

    [JsonPropertyName("last_update")] public string LastUpdate { get; set; }
}

public class SpeciesIllustrationPhoto
{
    [JsonPropertyName("src")] public string Src { get; set; }

    [JsonPropertyName("alt")] public string Alt { get; set; }

    [JsonPropertyName("title")] public string Title { get; set; }
}