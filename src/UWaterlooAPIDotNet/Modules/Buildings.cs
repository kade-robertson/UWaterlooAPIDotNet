using System;
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

        /// <summary>
        /// Obtain a list of all of the university's buildings.
        /// </summary>
        /// <returns>A list of Building objects.</returns>
        public RunResult<List<Building>> GetBuildingList() {
            return Get<List<Building>>("BLDNG_LIST", m_baseparam);
        }

        /// <summary>
        /// Obtain a list of all of the university's buildings.
        /// </summary>
        /// <returns>An awaitable task of a list of Building objects.</returns>
        public Task<RunResult<List<Building>>> GetBuildingListAsync() {
            return GetAsync<List<Building>>("BLDNG_LIST", m_baseparam);
        }

        /// <summary>
        /// Get more detailed building information, based on a building code.
        /// </summary>
        /// <param name="buildingCode">The code of the building for which more information is required.</param>
        /// <returns>An ExtendedBuilding object.</returns>
        public RunResult<ExtendedBuilding> GetBuildingData(string buildingCode) {
            return Get<ExtendedBuilding>("BLDNG_BYCODE", m_baseparam, buildingCode);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetBuildingDataProper for correct implementation.")]
        public RunResult<ExtendedBuilding> GetBuildingData(Building building) {
            return GetBuildingData(building.ID);
        }

        /// <summary>
        /// Get more detailed building information, based on a Building object.
        /// </summary>
        /// <param name="building">The Building object for which more information is required.</param>
        /// <returns>An ExtendedBuilding object.</returns>
        public RunResult<ExtendedBuilding> GetBuildingDataProper(Building building) {
            return GetBuildingData(building.Code);
        }

        /// <summary>
        /// Get more detailed building information, based on a building code.
        /// </summary>
        /// <param name="buildingCode">The code of the building for which more information is required.</param>
        /// <returns>An awaitable task of an ExtendedBuilding object.</returns>
        public Task<RunResult<ExtendedBuilding>> GetBuildingDataAsync(string buildingCode) {
            return GetAsync<ExtendedBuilding>("BLDNG_BYCODE", m_baseparam, buildingCode);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetBuildingDataAsyncProper for correct implementation.")]
        public Task<RunResult<ExtendedBuilding>> GetBuildingDataAsync(Building building) {
            return GetBuildingDataAsync(building.ID);
        }

        /// <summary>
        /// Get more detailed building information, based on a Building object.
        /// </summary>
        /// <param name="building">The Building object for which more information is required.</param>
        /// <returns>An awaitable task of an ExtendedBuilding object.</returns>
        public Task<RunResult<ExtendedBuilding>> GetBuildingDataAsyncProper(Building building) {
            return GetBuildingDataAsync(building.Code);
        }

        /// <summary>
        /// Obtain detailed information on the class(es) using a particular room in a building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <param name="roomNumber">The room number.</param>
        /// <returns>A list of BuildingRoom objects.</returns>
        public RunResult<List<BuildingRoom>> GetBuildingRoomData(string buildingCode, string roomNumber) {
            return Get<List<BuildingRoom>>("BLDNG_COURSES_BYSPEC", m_baseparam, buildingCode, roomNumber);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetBuildingRoomDataProper for correct implementation.")]
        public RunResult<List<BuildingRoom>> GetBuildingRoomData(Building building, string roomNumber) {
            return GetBuildingRoomData(building.ID, roomNumber);
        }

        /// <summary>
        /// Obtain detailed information on the class(es) using a particular room in a building.
        /// </summary>
        /// <param name="building">The Building object corresponding to the desired building.</param>
        /// <param name="roomNumber">The room number.</param>
        /// <returns>A list of BuildingRoom objects.</returns>
        public RunResult<List<BuildingRoom>> GetBuildingRoomDataProper(Building building, string roomNumber) {
            return GetBuildingRoomData(building.Code, roomNumber);
        }

        /// <summary>
        /// Obtain detailed information on the class(es) using a particular room in a building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <param name="roomNumber">The room number.</param>
        /// <returns>An awaitable task of a list of BuildingRoom objects.</returns>
        public Task<RunResult<List<BuildingRoom>>> GetBuildingRoomDataAsync(string buildingCode, string roomNumber) {
            return GetAsync<List<BuildingRoom>>("BLDNG_COURSES_BYSPEC", m_baseparam, buildingCode, roomNumber);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetBuildingRoomDataAsyncProper for correct implementation.")]
        public Task<RunResult<List<BuildingRoom>>> GetBuildingRoomDataAsync(Building building, string roomNumber) {
            return GetBuildingRoomDataAsync(building.ID, roomNumber);
        }

        /// <summary>
        /// Obtain detailed information on the class(es) using a particular room in a building.
        /// </summary>
        /// <param name="building">The Building object corresponding to the desired building.</param>
        /// <param name="roomNumber">The room number.</param>
        /// <returns>An awaitable task of a list of BuildingRoom objects.</returns>
        public Task<RunResult<List<BuildingRoom>>> GetBuildingRoomDataAsyncProper(Building building, string roomNumber) {
            return GetBuildingRoomDataAsync(building.Code, roomNumber);
        }

        /// <summary>
        /// Get a list of wireless access points in a particular building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <returns>A list of AccessPoint objects.</returns>
        public RunResult<List<AccessPoint>> GetAccessPoints(string buildingCode) {
            return Get<List<AccessPoint>>("BLDNG_ACCESSPT_BYCODE", m_baseparam, buildingCode);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetAccessPointsProper for correct implementation.")]
        public RunResult<List<AccessPoint>> GetAccessPoints(Building building) {
            return GetAccessPoints(building.ID);
        }

        /// <summary>
        /// Get a list of wireless access points in a particular building.
        /// </summary>
        /// <param name="building">The Building object corresponding to the desired building.</param>
        /// <returns>A list of AccessPoint objects.</returns>
        public RunResult<List<AccessPoint>> GetAccessPointsProper(Building building) {
            return GetAccessPoints(building.Code);
        }

        /// <summary>
        /// Get a list of wireless access points in a particular building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <returns>An awaitable task of a list of AccessPoint objects.</returns>
        public Task<RunResult<List<AccessPoint>>> GetAccessPointsAsync(string buildingCode) {
            return GetAsync<List<AccessPoint>>("BLDNG_ACCESSPT_BYCODE", m_baseparam, buildingCode);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetAccessPointsAsyncProper for correct implementation.")]
        public Task<RunResult<List<AccessPoint>>> GetAccessPointsAsync(Building building) {
            return GetAccessPointsAsync(building.ID);
        }

        /// <summary>
        /// Get a list of wireless access points in a particular building.
        /// </summary>
        /// <param name="building">The Building object corresponding to the desired building.</param>
        /// <returns>An awaitable task of a list of AccessPoint objects.</returns>
        public Task<RunResult<List<AccessPoint>>> GetAccessPointsAsyncProper(Building building) {
            return GetAccessPointsAsync(building.Code);
        }

        /// <summary>
        /// Get building vending machine information for a particular building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <returns>A BuildingVending object.</returns>
        public RunResult<BuildingVending> GetVendingMachines(string buildingCode) {
            return Get<BuildingVending>("BLDNG_VENDING_BYCODE", m_baseparam, buildingCode);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetVendingMachinesProper for correct implementation.")]
        public RunResult<BuildingVending> GetVendingMachines(Building building) {
            return GetVendingMachines(building.ID);
        }

        /// <summary>
        /// Get building vending machine information for a particular building.
        /// </summary>
        /// <param name="building">The Building object corresponding to the desired building.</param>
        /// <returns>A BuildingVending object.</returns>
        public RunResult<BuildingVending> GetVendingMachinesProper(Building building) {
            return GetVendingMachines(building.Code);
        }

        /// <summary>
        /// Get building vending machine information for a particular building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <returns>An awaitable task of a BuildingVending object.</returns>
        public Task<RunResult<BuildingVending>> GetVendingMachinesAsync(string buildingCode) {
            return GetAsync<BuildingVending>("BLDNG_VENDING_BYCODE", m_baseparam, buildingCode);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetVendingMachinesAsyncProper for correct implementation.")]
        public Task<RunResult<BuildingVending>> GetVendingMachinesAsync(Building building) {
            return GetVendingMachinesAsync(building.ID);
        }

        /// <summary>
        /// Get building vending machine information for a particular building.
        /// </summary>
        /// <param name="building">The Building object corresponding to the desired building.</param>
        /// <returns>An awaitable task of a BuildingVending object.</returns>
        public Task<RunResult<BuildingVending>> GetVendingMachinesAsyncProper(Building building) {
            return GetVendingMachinesAsync(building.Code);
        }
    }
}
