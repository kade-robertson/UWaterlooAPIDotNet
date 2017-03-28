using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.Buildings;

namespace UWaterlooAPIDotNet.Modules
{
    public class Buildings : GenericModule
    {
        public Buildings(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<List<Building>> GetBuildingList() {
            return Get<List<Building>>("BLDNG_LIST", m_baseparam);
        }

        public Task<RunResult<List<Building>>> GetBuildingListAsync() {
            return GetAsync<List<Building>>("BLDNG_LIST", m_baseparam);
        }

        public RunResult<ExtendedBuilding> GetBuildingData(string buildingCode) {
            return Get<ExtendedBuilding>("BLDNG_BYCODE", m_baseparam, buildingCode);
        }

        public RunResult<ExtendedBuilding> GetBuildingData(Building building) {
            return GetBuildingData(building.ID);
        }

        public Task<RunResult<ExtendedBuilding>> GetBuildingDataAsync(string buildingCode) {
            return GetAsync<ExtendedBuilding>("BLDNG_BYCODE", m_baseparam, buildingCode);
        }

        public Task<RunResult<ExtendedBuilding>> GetBuildingDataAsync(Building building) {
            return GetBuildingDataAsync(building.ID);
        }

        public RunResult<List<BuildingRoom>> GetBuildingRoomData(string buildingCode, string roomNumber) {
            return Get<List<BuildingRoom>>("BLDNG_COURSES_BYSPEC", m_baseparam, buildingCode, roomNumber);
        }

        public RunResult<List<BuildingRoom>> GetBuildingRoomData(Building building, string roomNumber) {
            return GetBuildingRoomData(building.ID, roomNumber);
        }

        public Task<RunResult<List<BuildingRoom>>> GetBuildingRoomDataAsync(string buildingCode, string roomNumber) {
            return GetAsync<List<BuildingRoom>>("BLDNG_COURSES_BYSPEC", m_baseparam, buildingCode, roomNumber);
        }

        public Task<RunResult<List<BuildingRoom>>> GetBuildingRoomDataAsync(Building building, string roomNumber) {
            return GetBuildingRoomDataAsync(building.ID, roomNumber);
        }

        public RunResult<List<AccessPoint>> GetAccessPoints(string buildingCode) {
            return Get<List<AccessPoint>>("BLDNG_ACCESSPT_BYCODE", m_baseparam, buildingCode);
        }

        public RunResult<List<AccessPoint>> GetAccessPoints(Building building) {
            return GetAccessPoints(building.ID);
        }

        public Task<RunResult<List<AccessPoint>>> GetAccessPointsAsync(string buildingCode) {
            return GetAsync<List<AccessPoint>>("BLDNG_ACCESSPT_BYCODE", m_baseparam, buildingCode);
        }

        public Task<RunResult<List<AccessPoint>>> GetAccessPointsAsync(Building building) {
            return GetAccessPointsAsync(building.ID);
        }

        public RunResult<BuildingVending> GetVendingMachines(string buildingCode) {
            return Get<BuildingVending>("BLDNG_VENDING_BYCODE", m_baseparam, buildingCode);
        }

        public RunResult<BuildingVending> GetVendingMachines(Building building) {
            return GetVendingMachines(building.ID);
        }

        public Task<RunResult<BuildingVending>> GetVendingMachinesAsync(string buildingCode) {
            return GetAsync<BuildingVending>("BLDNG_VENDING_BYCODE", m_baseparam, buildingCode);
        }

        public Task<RunResult<BuildingVending>> GetVendingMachinesAsync(Building building) {
            return GetVendingMachinesAsync(building.ID);
        }
    }
}
