using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HH.web.Utilities
{
    public class API
    {
        public static string GetAllAboutUs { get; } = "/api/AboutUsAPI/GetAllAboutUs";
        public static string GetMainAboutUs { get; } = "/api/AboutUsAPI/GetMainAboutUs";
        public static string GetAboutUsPage { get; } = "/api/AboutUsAPI/GetAboutUsDetail";
        public static string GetAllBanner { get; } = "/api/BannerAPI/GetAllBanner";
        public static string GetBanner { get; } = "/api/BannerAPI";
        public static string GetAllMission { get; } = "/api/MissionAPI/GetAllMission";
        public static string GetMission { get; } = "/api/MissionAPI";
        public static string GetAllProduct { get; } = "/api/ProductAPI/GetAllPublishProduct";
        public static string GetProductPage { get; } = "/api/ProductAPI/GetProductPage/{id}";
        public static string GetAllOptionContent { get; } = "/api/ProductAPI/GetAllOptionDetailByOptionId/{id}";
        public static string GetService { get; } = "/api/ServiceAPI/GetAllPublishService";
        public static string GetServicePage { get; } = "/api/ServiceAPI/GetServiceDetailById{id}";
        public static string GetAllService { get; } = "/api/ServiceAPI/GetAllServiceForProduct";
        public static string GetAllClient { get; } = "/api/ClientAPI";
        public static string GetFooter { get; } = "/api/AboutUsAPI/GetFooter";
        public static string GetNews { get; } = "/api/CompanyAPI/GetAllPublishNews";
        public static string GetNewsPage { get; } = "api/CompanyAPI/GetNewsPage/{id}";
        public static string GetAllNews { get; } = "api/CompanyAPI/GetAllNews";
        
    }
}
