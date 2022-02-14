using AutoMapper;
using HH.bll.DTOs.AboutUsDTO;
using HH.bll.DTOs.BannerDTO;
using HH.bll.DTOs.ClientDTO;
using HH.bll.DTOs.CompanyDTO;
using HH.bll.DTOs.ContactDTO;
using HH.bll.DTOs.MissionDTO;
using HH.bll.DTOs.ProductDTO;
using HH.bll.DTOs.ProjectDTO;
using HH.bll.DTOs.ServicesDTO;
using HH.dal.Models.AboutUs;
using HH.dal.Models.Banner;
using HH.dal.Models.Client;
using HH.dal.Models.Company;
using HH.dal.Models.Contact;
using HH.dal.Models.Mission;
using HH.dal.Models.Product;
using HH.dal.Models.Project;
using HH.dal.Models.Service;
using System.Linq;

namespace HH.web.Extensions
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateNewsDTO, News>().ReverseMap();
            CreateMap<EditNewsDTO, News>().ReverseMap();
            CreateMap<NewsDTO, News>();
            CreateMap<NewsDTO, NewsTranslate>().ReverseMap();            
            CreateMap<NewsTranslateDTO, NewsTranslate>().ReverseMap();

            CreateMap<News, NewsDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.ShortDesc).FirstOrDefault()));
            CreateMap<News, NewsDetailDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.ShortDesc).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<News, NewsDetailDTO>().ReverseMap();
            CreateMap<NewsTranslate, NewsDetailDTO>().ReverseMap();

           
            CreateMap<CreateServiceDTO, Service>();
            CreateMap<ServiceTranslateDTO, ServiceTranslate>();
            CreateMap<EditServiceDTO, Service>();
            CreateMap<Service, ServiceDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.Name).FirstOrDefault()));
            CreateMap<Service, ServiceDetailDTO>();
            CreateMap<ServiceTranslate, ServiceDetailDTO>();

            CreateMap<ProductTranslateDTO, ProductTranslate>();
            CreateMap<CreateProductDTO, Product>();
            CreateMap<CreateOptionDTO, Option>();
            CreateMap<CreateOptionContentDTO, OptionContent>();
            CreateMap<CreateOptionContentTranslateDTO, OptionContentTranslate>();
            CreateMap<Product, ProductDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.ShortDesc).FirstOrDefault()));

            CreateMap<Option, OptionDTO>();
            //CreateMap<OptionContent, OptionContentDTO>()
            //    .ForMember(p => p.Title, p => p.MapFrom(p => p.OptionContentTranslates.Select(p => p.Title).FirstOrDefault()))
            //    .ForMember(p => p.Description, p => p.MapFrom(p => p.OptionContentTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<Product, ProductDetailDTO>()
                .ForMember(p => p.OptionDTO, p => p.MapFrom(p => p.Option))
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<OptionContentTranslate, OptionDetailDTO>();
            CreateMap<OptionContent, OptionDetailDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.OptionContentTranslates.Select(p => p.Title).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.OptionContentTranslates.Select(p => p.Description).FirstOrDefault()));

            CreateMap<CreateAboutUsDTO, AboutUs>();
            CreateMap<EditAboutUsDTO, AboutUs>();
            CreateMap<AboutUsTranslateDTO, AboutUsTranslate>();
            CreateMap<AboutUsTranslate, AboutUsDTO>();
            CreateMap<AboutUs, AboutUsDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.Title).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.Description).FirstOrDefault()))
                .ForMember(p => p.Phone, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.Phone).FirstOrDefault()))
                .ForMember(p => p.LocationAdress, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.LocationAdress).FirstOrDefault()));

            CreateMap<CreateMissionDTO, Mission>();
            CreateMap<EditMissionDTO, Mission>();
            CreateMap<MissionTranslateDTO, MissionTranslate>();
            CreateMap<Mission, MissionDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.MissionTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.MissionTranslates.Select(p => p.Description).FirstOrDefault()));

            CreateMap<CreateClientDTO, Client>();
            CreateMap<EditClientDTO, Client>();
            CreateMap<Client, ClientDTO>();

            CreateMap<CreateBannerDTO, Banner>();
            CreateMap<BannerTranslateDTO, BannerTranslate>();
            CreateMap<Banner, BannerDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.BannerTranslates.Select(p => p.Title).FirstOrDefault()));

            CreateMap<CreateStatusDTO, Status>();
            CreateMap<StatusTranslateDTO, StatusTranslate>();
            CreateMap<CreateLocationDTO, Location>();
            CreateMap<LocationTranslateDTO, LocationTranslate>();
            CreateMap<CreateProjectDTO, Project>();
            CreateMap<ProjectTranslateDTO, ProjectTranslate>();
            CreateMap<Project, ProjectDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.ProjectTranslates.Select(p => p.Title).FirstOrDefault()));

            CreateMap<CreateUserDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
