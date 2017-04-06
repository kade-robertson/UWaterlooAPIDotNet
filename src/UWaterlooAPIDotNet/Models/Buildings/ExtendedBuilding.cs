using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class ExtendedBuilding : Building
    {
        /// <summary>
        /// A list of coordinates which describe the outline of the building.
        /// </summary>
        [JsonProperty(PropertyName = "building_outline")]
        public List<Tuple<decimal, decimal>> BuildingOutline { get; set; }
    }
}
