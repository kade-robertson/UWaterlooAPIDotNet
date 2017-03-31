using Newtonsoft.Json;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class FoodItemNutrition : GenericProduct
    {
        [JsonProperty(PropertyName = "ingredients")]
        public string Ingredients { get; private set; }

        [JsonProperty(PropertyName = "serving_size")]
        public string ServingSize { get; private set; }

        [JsonProperty(PropertyName = "serving_size_ml")]
        public int? ServingSizeMillilitres { get; private set; }

        [JsonProperty(PropertyName = "serving_size_g")]
        public int? ServingSizeGrams { get; private set; }

        [JsonProperty(PropertyName = "calories")]
        public int? Calories { get; private set; }

        [JsonProperty(PropertyName = "total_fat_g")]
        public int? TotalFat { get; private set; }

        [JsonProperty(PropertyName = "total_fat_percent")]
        public int? TotalFatPercentage { get; private set; }

        [JsonProperty(PropertyName = "fat_saturated_g")]
        public int? SaturatedFat { get; private set; }

        [JsonProperty(PropertyName = "fat_saturated_percent")]
        public int? SaturatedFatPercentage { get; private set; }

        [JsonProperty(PropertyName = "fat_trans_g")]
        public int? TransFat { get; private set; }

        [JsonProperty(PropertyName = "fat_trans_percent")]
        public int? TransFatPercentage { get; private set; }

        [JsonProperty(PropertyName = "cholesterol_mg")]
        public int? Cholesterol { get; private set; }

        [JsonProperty(PropertyName = "sodium_mg")]
        public int? Sodium { get; private set; }

        [JsonProperty(PropertyName = "sodium_percent")]
        public int? SodiumPercentage { get; private set; }

        [JsonProperty(PropertyName = "carbo_g")]
        public int? Carbohydrates { get; private set; }

        [JsonProperty(PropertyName = "carbo_percent")]
        public int? CarbohydratesPercentage { get; private set; }

        [JsonProperty(PropertyName = "carbo_fibre_g")]
        public int? Fibre { get; private set; }

        [JsonProperty(PropertyName = "carbo_fibre_percent")]
        public int? FibrePercentage { get; private set; }

        [JsonProperty(PropertyName = "carbo_sugars_g")]
        public int? Sugar { get; private set; }

        [JsonProperty(PropertyName = "vitamin_a_percent")]
        public int? VitaminAPercentage { get; private set; }

        [JsonProperty(PropertyName = "vitamin_c_percent")]
        public int? VitaminCPercentage { get; private set; }

        [JsonProperty(PropertyName = "calcium_percent")]
        public int? CalciumPercentage { get; private set; }

        [JsonProperty(PropertyName = "iron_percent")]
        public int? IronPercentage { get; private set; }

        [JsonProperty(PropertyName = "micro_nutrients")]
        public string MicroNutrients { get; private set; }

        [JsonProperty(PropertyName = "tips")]
        public string Tips { get; private set; }

        [JsonProperty(PropertyName = "diet_id")]
        public int? DietID { get; private set; }

        [JsonProperty(PropertyName = "diet_type")]
        public string DietName { get; private set; }
    }
}
