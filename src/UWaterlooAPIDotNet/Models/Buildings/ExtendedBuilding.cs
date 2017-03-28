﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.Buildings
{
    public class ExtendedBuilding : Building
    {
        [JsonProperty(PropertyName = "building_outline")]
        public List<Tuple<decimal, decimal>> BuildingOutline { get; set; }
    }
}
