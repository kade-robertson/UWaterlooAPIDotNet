using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class ExtendedBuilding : Building
    {
        /// <summary>
        /// A <see cref="List{T}"/> of <see cref="Tuple{T1, T1}"/> coordinates, which describe the outline of the building.
        /// </summary>
        [JsonProperty(PropertyName = "building_outline")]
        public List<Tuple<decimal, decimal>> BuildingOutline { get; set; }
    }
}
