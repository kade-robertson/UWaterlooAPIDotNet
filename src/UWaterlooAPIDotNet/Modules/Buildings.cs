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
        /// Obtain a list of all of the university's <see cref="Building"/>s.
        /// </summary>
        /// <returns>A list of <see cref="List{T}"/> of <see cref="Building"/>, if available.</returns>
        public RunResult<List<Building>> GetBuildingList() {
            return Get<List<Building>>("BLDNG_LIST", m_baseparam);
        }

        /// <summary>
        /// Obtain a list of all of the university's <see cref="Building"/>s.
        /// </summary>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="Building"/>, if available.</returns>
        public Task<RunResult<List<Building>>> GetBuildingListAsync() {
            return GetAsync<List<Building>>("BLDNG_LIST", m_baseparam);
        }

        /// <summary>
        /// Get more detailed building information, based on a building code.
        /// </summary>
        /// <param name="buildingCode">The code of the building for which more information is required.</param>
        /// <returns>An <see cref="ExtendedBuilding"/>, if available.</returns>
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
        /// <param name="building">The <see cref="Building"/> for which more information is required.</param>
        /// <returns>An <see cref="ExtendedBuilding"/>, if available.</returns>
        public RunResult<ExtendedBuilding> GetBuildingDataProper(Building building) {
            return GetBuildingData(building.Code);
        }

        /// <summary>
        /// Get more detailed building information, based on a building code.
        /// </summary>
        /// <param name="buildingCode">The code of the building for which more information is required.</param>
        /// <returns>An awaitable task of an <see cref="ExtendedBuilding"/>, if available.</returns>
        public Task<RunResult<ExtendedBuilding>> GetBuildingDataAsync(string buildingCode) {
            return GetAsync<ExtendedBuilding>("BLDNG_BYCODE", m_baseparam, buildingCode);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetBuildingDataAsyncProper for correct implementation.")]
        public Task<RunResult<ExtendedBuilding>> GetBuildingDataAsync(Building building) {
            return GetBuildingDataAsync(building.ID);
        }

        /// <summary>
        /// Get more detailed building information, based on a <see cref="Building"/>.
        /// </summary>
        /// <param name="building">The <see cref="Building"/> for which more information is required.</param>
        /// <returns>An awaitable task of an <see cref="ExtendedBuilding"/>, if available.</returns>
        public Task<RunResult<ExtendedBuilding>> GetBuildingDataAsyncProper(Building building) {
            return GetBuildingDataAsync(building.Code);
        }

        /// <summary>
        /// Obtain detailed information on the class(es) using a particular room in a building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <param name="roomNumber">The room number.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="BuildingRoom"/>, if available.</returns>
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
        /// <param name="building">The <see cref="Building"/> corresponding to the desired building.</param>
        /// <param name="roomNumber">The room number.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="BuildingRoom"/>, if available.</returns>
        public RunResult<List<BuildingRoom>> GetBuildingRoomDataProper(Building building, string roomNumber) {
            return GetBuildingRoomData(building.Code, roomNumber);
        }

        /// <summary>
        /// Obtain detailed information on the class(es) using a particular room in a building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <param name="roomNumber">The room number.</param>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="BuildingRoom"/>, if available.</returns>
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
        /// <param name="building">The <see cref="Building"/> corresponding to the desired building.</param>
        /// <param name="roomNumber">The room number.</param>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="BuildingRoom"/>, if available.</returns>
        public Task<RunResult<List<BuildingRoom>>> GetBuildingRoomDataAsyncProper(Building building, string roomNumber) {
            return GetBuildingRoomDataAsync(building.Code, roomNumber);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="AccessPoint"/> in a particular building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="AccessPoint"/> if available.</returns>
        public RunResult<List<AccessPoint>> GetAccessPoints(string buildingCode) {
            return Get<List<AccessPoint>>("BLDNG_ACCESSPT_BYCODE", m_baseparam, buildingCode);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetAccessPointsProper for correct implementation.")]
        public RunResult<List<AccessPoint>> GetAccessPoints(Building building) {
            return GetAccessPoints(building.ID);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of <see cref="AccessPoint"/> in a particular building.
        /// </summary>
        /// <param name="building">The <see cref="Building"/> corresponding to the desired building.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="AccessPoint"/> if available.</returns>
        public RunResult<List<AccessPoint>> GetAccessPointsProper(Building building) {
            return GetAccessPoints(building.Code);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of wireless access points in a particular building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="AccessPoint"/>, if available.</returns>
        public Task<RunResult<List<AccessPoint>>> GetAccessPointsAsync(string buildingCode) {
            return GetAsync<List<AccessPoint>>("BLDNG_ACCESSPT_BYCODE", m_baseparam, buildingCode);
        }

        [Obsolete("This does not work as intended, uses the ID rather than the code. Use GetAccessPointsAsyncProper for correct implementation.")]
        public Task<RunResult<List<AccessPoint>>> GetAccessPointsAsync(Building building) {
            return GetAccessPointsAsync(building.ID);
        }

        /// <summary>
        /// Get a <see cref="List{T}"/> of wireless access points in a particular building.
        /// </summary>
        /// <param name="building">The <see cref="Building"/> corresponding to the desired building.</param>
        /// <returns>An awaitable task of a <see cref="List{T}"/> of <see cref="AccessPoint"/>, if available.</returns>
        public Task<RunResult<List<AccessPoint>>> GetAccessPointsAsyncProper(Building building) {
            return GetAccessPointsAsync(building.Code);
        }

        /// <summary>
        /// Get building vending machine information for a particular building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <returns>A <see cref="BuildingVending"/>, if available.</returns>
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
        /// <param name="building">The <see cref="Building"/> corresponding to the desired building.</param>
        /// <returns>A <see cref="BuildingVending"/>, if available.</returns>
        public RunResult<BuildingVending> GetVendingMachinesProper(Building building) {
            return GetVendingMachines(building.Code);
        }

        /// <summary>
        /// Get building vending machine information for a particular building.
        /// </summary>
        /// <param name="buildingCode">The code for the building.</param>
        /// <returns>An awaitable task of a <see cref="BuildingVending"/>, if available.</returns>
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
        /// <param name="building">The <see cref="Building"/> corresponding to the desired building.</param>
        /// <returns>An awaitable task of a <see cref="BuildingVending"/>, if available.</returns>
        public Task<RunResult<BuildingVending>> GetVendingMachinesAsyncProper(Building building) {
            return GetVendingMachinesAsync(building.Code);
        }
    }
}
