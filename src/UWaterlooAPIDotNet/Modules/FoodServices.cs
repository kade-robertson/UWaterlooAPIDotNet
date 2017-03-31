using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UWaterlooAPIDotNet.Models;
using UWaterlooAPIDotNet.Models.FoodServices;

namespace UWaterlooAPIDotNet.Modules
{
    public class FoodServices : GenericModule
    {
        public FoodServices(string apikey, HttpClient client) : base(apikey, client) { }

        public RunResult<OutletCollection> GetMenus() {
            return Get<OutletCollection>("FS_MENU", m_baseparam);
        }

        public Task<RunResult<OutletCollection>> GetMenusAsync() {
            return GetAsync<OutletCollection>("FS_MENU", m_baseparam);
        }

        public RunResult<List<ExtraOutletNotes>> GetExtraNotes() {
            return Get<List<ExtraOutletNotes>>("FS_NOTES", m_baseparam);
        }

        public Task<RunResult<List<ExtraOutletNotes>>> GetExtraNotesAsync() {
            return GetAsync<List<ExtraOutletNotes>>("FS_NOTES", m_baseparam);
        }

        public RunResult<List<DietInfo>> GetDiets() {
            return Get<List<DietInfo>>("FS_DIETS", m_baseparam);
        }

        public Task<RunResult<List<DietInfo>>> GetDietsAsync() {
            return GetAsync<List<DietInfo>>("FS_DIETS", m_baseparam);
        }

        public RunResult<List<BasicOutlet>> GetOutlets() {
            return Get<List<BasicOutlet>>("FS_OUTLETS", m_baseparam);
        }

        public Task<RunResult<List<BasicOutlet>>> GetOutletsAsync() {
            return GetAsync<List<BasicOutlet>>("FS_OUTLETS", m_baseparam);
        }
        
        public RunResult<List<ExtendedOutlet>> GetLocationsAndHours() {
            return Get<List<ExtendedOutlet>>("FS_LOCATIONS", m_baseparam);
        }

        public Task<RunResult<List<ExtendedOutlet>>> GetLocationsAndHoursAsync() {
            return GetAsync<List<ExtendedOutlet>>("FS_LOCATIONS", m_baseparam);
        }

        public RunResult<List<WatcardLocation>> GetWatcardLocations() {
            return Get<List<WatcardLocation>>("FS_WATCARD", m_baseparam);
        }

        public Task<RunResult<List<WatcardLocation>>> GetWatcardLocationsAsync() {
            return GetAsync<List<WatcardLocation>>("FS_WATCARD", m_baseparam);
        }

        public RunResult<List<MenuAnnouncement>> GetAnnouncements() {
            return Get<List<MenuAnnouncement>>("FS_ANNOUNCEMENTS", m_baseparam);
        }

        public Task<RunResult<List<MenuAnnouncement>>> GetAnnouncementsAsync() {
            return GetAsync<List<MenuAnnouncement>>("FS_ANNOUNCEMENTS", m_baseparam);
        }

        public RunResult<FoodItemNutrition> GetNutritionalInfo(int product_id) {
            return Get<FoodItemNutrition>("FS_PRODUCT_BYSPEC", m_baseparam, product_id.ToString());
        }

        public Task<RunResult<FoodItemNutrition>> GetNutritionalInfoAsync(int product_id) {
            return GetAsync<FoodItemNutrition>("FS_PRODUCT_BYSPEC", m_baseparam, product_id.ToString());
        }

        public RunResult<FoodItemNutrition> GetNutritionalInfo(FoodItem food) {
            return GetNutritionalInfo((int)food.ID);
        }

        public Task<RunResult<FoodItemNutrition>> GetNutritionalInfoAsync(FoodItem food) {
            return GetNutritionalInfoAsync((int)food.ID);
        }

        public RunResult<OutletCollection> GetWeeklyMenus(int year, int week) {
            return Get<OutletCollection>("FS_MENU_BYSPEC", m_baseparam, year.ToString(), week.ToString());
        }

        public Task<RunResult<OutletCollection>> GetWeeklyMenusAsync(int year, int week) {
            return GetAsync<OutletCollection>("FS_MENU_BYSPEC", m_baseparam, year.ToString(), week.ToString());
        }

        public RunResult<List<ExtraOutletNotes>> GetWeeklyExtraNotes(int year, int week) {
            return Get<List<ExtraOutletNotes>>("FS_NOTES_BYSPEC", m_baseparam, year.ToString(), week.ToString());
        }

        public Task<RunResult<List<ExtraOutletNotes>>> GetWeeklyExtraNotesAsync(int year, int week) {
            return GetAsync<List<ExtraOutletNotes>>("FS_NOTES_BYSPEC", m_baseparam, year.ToString(), week.ToString());
        }

        public RunResult<List<MenuAnnouncement>> GetWeeklyAnnouncements(int year, int week) {
            return Get<List<MenuAnnouncement>>("FS_ANNOUNCEMENT_BYSPEC", m_baseparam, year.ToString(), week.ToString());
        }

        public Task<RunResult<List<MenuAnnouncement>>> GetWeeklyAnnouncementsAsync(int year, int week) {
            return GetAsync<List<MenuAnnouncement>>("FS_ANNOUNCEMENT_BYSPEC", m_baseparam, year.ToString(), week.ToString());
        }
    }
}
