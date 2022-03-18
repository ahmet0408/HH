using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Utilities
{
    public class API
    {
        public static string GetAllAbout { get; } = "/api/AboutUsAPI/GetAllAbout";
        public static string GetAllBanner { get; } = "/api/BannerAPI/GetAllBanner";
        public static string GetAllClient { get; } = "/api/ClientAPI";
        public static string GetAllNews { get; } = "/api/CompanyAPI/GetAllNews";
        public static string GetAllLicense { get; } = "/api/CompanyAPI/GetAllLicense";
        public static string GetAllMission { get; } = "/api/MissionAPI/GetAllMission";
        public static string GetAllProduct { get; } = "/api/ProductAPI/GetAllProduct";
        public static string GetAllLocation { get; } = "/api/ProjectAPI/GetAllLocation";
        public static string GetAllStatus { get; } = "/api/ProjectAPI/GetAllStatus";
        public static string GetAllProject { get; } = "/api/ProjectAPI/GetAllProject"; 
        public static string GetAllService { get; } = "/api/ServiceAPI/GetAllService";
        public static string GetAllOptionContent { get; } = "/api/ProductAPI/GetAllOptionContentForOption/";
        public static string GetAllUser { get; } = "/api/ContactAPI/GetAllUser";

    }
}
