using Newtonsoft.Json;
using System.Collections.Generic;

namespace UWaterlooAPIDotNet.Models.FoodServices
{
    public class Outlet : GenericOutlet
    {
        [JsonProperty(PropertyName = "menu")]
        public List<Menu> Menus { get; private set; }
    }
}
