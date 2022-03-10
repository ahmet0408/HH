using AutoMapper;
using HH.bll.DTOs.AboutUsDTO;
using HH.bll.DTOs.BannerDTO;
using HH.bll.DTOs.ClientDTO;
using HH.bll.DTOs.CompanyDTO;
using HH.bll.DTOs.ContactDTO;
using HH.bll.DTOs.LanguageDTO;
using HH.bll.DTOs.MissionDTO;
using HH.bll.DTOs.ProductDTO;
using HH.bll.DTOs.ProjectDTO;
using HH.bll.DTOs.ServicesDTO;
using HH.dal.Models.AboutUs;
using HH.dal.Models.Banner;
using HH.dal.Models.Client;
using HH.dal.Models.Company;
using HH.dal.Models.Contact;
using HH.dal.Models.Language;
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
            CreateMap<dal.Models.Company.News, bll.DTOs.CompanyDTO.News>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.Title, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.Title).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.ShortDesc).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<CreateNewsDTO, dal.Models.Company.News>();
            CreateMap<EditNewsDTO, dal.Models.Company.News>().ReverseMap();           
            CreateMap<NewsTranslateDTO, NewsTranslate>().ReverseMap();
            CreateMap<dal.Models.Company.News, NewsDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.ShortDesc).FirstOrDefault()));
            CreateMap<dal.Models.Company.News, NewsDetailDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.Title).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.ShortDesc).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.NewsTranslates.Select(p => p.Description).FirstOrDefault()));

            CreateMap<dal.Models.Service.Service, ProductServiceDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.ShortDesc).FirstOrDefault()))
                .ForMember(p => p.ServiceId, p => p.MapFrom(p => p.Id));
            CreateMap<dal.Models.Service.Service, bll.DTOs.ServicesDTO.Service>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.ShortDesc).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<CreateServiceDTO, dal.Models.Service.Service>();
            CreateMap<ServiceTranslateDTO, ServiceTranslate>().ReverseMap();
            CreateMap<EditServiceDTO, dal.Models.Service.Service>().ReverseMap();
            CreateMap<dal.Models.Service.Service, ServiceDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<dal.Models.Service.Service, ServiceDetailDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<dal.Models.Service.Service, ProductDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.ServiceTranslates.Select(p => p.ShortDesc).FirstOrDefault()));


            CreateMap<dal.Models.Product.OptionContent, bll.DTOs.ProductDTO.OptionContent>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.OptionContentTranslates.Select(p => p.Title).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.OptionContentTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<dal.Models.Product.Product, ProductServiceDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.ShortDesc).FirstOrDefault()));
            CreateMap<dal.Models.Product.Product, bll.DTOs.ProductDTO.Product>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.ShortDesc).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<ProductTranslateDTO, ProductTranslate>().ReverseMap();
            CreateMap<ProductOptionDTO, ProductOption>();
            CreateMap<CreateProductDTO, dal.Models.Product.Product>();
            CreateMap<dal.Models.Product.Product, EditProductDTO>()
                .ForMember(p => p.OptionIds, p => p.MapFrom(p => p.ProductOption.Select(p => p.OptionId)));
            CreateMap<EditProductDTO, dal.Models.Product.Product>();
            CreateMap<EditOptionDTO, Option>().ReverseMap();
            CreateMap<EditOptionContentDTO, dal.Models.Product.OptionContent>().ReverseMap();
            CreateMap<OptionContentTranslate, OptionContentTranslateDTO>().ReverseMap();
            CreateMap<CreateOptionDTO, Option>();
            CreateMap<CreateOptionContentDTO, dal.Models.Product.OptionContent>();
            CreateMap<dal.Models.Product.Product, ProductDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.ShortDesc).FirstOrDefault()));
            CreateMap<dal.Models.Product.Product, ProductDetailDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.ShortDesc).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.ProductTranslates.Select(p => p.Description).FirstOrDefault()))
                .ForMember(p => p.OptionDTO, p => p.MapFrom(p => p.ProductOption));
            CreateMap<ProductOption, OptionDTO>()
                .ForMember(p => p.Id,p => p.MapFrom(p => p.OptionId))
                .ForMember(p => p.OptionCode, p => p.MapFrom(p => p.Option.OptionCode))
                .ForMember(p => p.optionDetailDTOs, p => p.MapFrom(p => p.Option.OptionContent));
            CreateMap<dal.Models.Product.OptionContent, OptionDetailDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.OptionContentTranslates.Select(p => p.Title).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.OptionContentTranslates.Select(p => p.Description).FirstOrDefault()));
                     

            CreateMap<AboutUs, About>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.Title).FirstOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.ShortDesc).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.Description).FirstOrDefault()))
                .ForMember(p => p.LocationAdress, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.LocationAdress).FirstOrDefault()));
            CreateMap<CreateAboutUsDTO, AboutUs>();
            CreateMap<AboutUs, EditAboutUsDTO>().ReverseMap();
            CreateMap<AboutUsTranslate, AboutUsTranslateDTO>().ReverseMap();
            CreateMap<AboutUs, AboutUsDTO>()
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.ShortDesc).SingleOrDefault()));
            CreateMap<AboutUs, AboutUsDetailDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.Title).SingleOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.Description).SingleOrDefault()))
                .ForMember(p => p.ShortDesc, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.ShortDesc).SingleOrDefault()));
            CreateMap<AboutUs, FooterDTO>()
                .ForMember(p => p.LocationAdress, p => p.MapFrom(p => p.AboutUsTranslates.Select(p => p.LocationAdress).SingleOrDefault()));

            CreateMap<dal.Models.Mission.Mission, bll.DTOs.MissionDTO.Mission>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.MissionTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.MissionTranslates.Select(p => p.Description).FirstOrDefault()));
            CreateMap<CreateMissionDTO, dal.Models.Mission.Mission>();
            CreateMap<EditMissionDTO, dal.Models.Mission.Mission>().ReverseMap();
            CreateMap<MissionTranslateDTO, MissionTranslate>().ReverseMap();
            CreateMap<dal.Models.Mission.Mission, MissionDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.MissionTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.MissionTranslates.Select(p => p.Description).FirstOrDefault()));

            CreateMap<CreateClientDTO, Client>();
            CreateMap<EditClientDTO, Client>().ReverseMap();
            CreateMap<Client, ClientDTO>();

            CreateMap<dal.Models.Banner.Banner, bll.DTOs.BannerDTO.Banner>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.BannerTranslates.Select(p => p.Title).FirstOrDefault()));
            CreateMap<CreateBannerDTO, dal.Models.Banner.Banner>();
            CreateMap<EditBannerDTO, dal.Models.Banner.Banner>().ReverseMap();
            CreateMap<BannerTranslateDTO, BannerTranslate>().ReverseMap();
            CreateMap<dal.Models.Banner.Banner, BannerDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.BannerTranslates.Select(p => p.Title).FirstOrDefault()));

            CreateMap<dal.Models.Project.Project, bll.DTOs.ProjectDTO.Project>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.ProjectTranslates.Select(p => p.Title).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.ProjectTranslates.Select(p => p.Description).FirstOrDefault()))
                .ForMember(p => p.Client, p => p.MapFrom(p => p.Client.Name))
                .ForMember(p => p.Location, p => p.MapFrom(p => p.Location.LocationTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.Status, p => p.MapFrom(p => p.Status.StatusTranslates.Select(p => p.Name).FirstOrDefault()));
            CreateMap<Status, StatusDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.StatusTranslates.Select(p => p.Name).FirstOrDefault()));
            CreateMap<Location, LocationDTO>()
                .ForMember(p => p.Name, p => p.MapFrom(p => p.LocationTranslates.Select(p => p.Name).FirstOrDefault()));
            CreateMap<CreateStatusDTO, Status>();
            CreateMap<StatusTranslateDTO, StatusTranslate>().ReverseMap();
            CreateMap<EditStatusDTO, Status>().ReverseMap();
            CreateMap<CreateLocationDTO, Location>();
            CreateMap<LocationTranslateDTO, LocationTranslate>().ReverseMap();
            CreateMap<EditLocationDTO, Location>().ReverseMap();
            CreateMap<CreateProjectDTO, dal.Models.Project.Project>();
            CreateMap<EditProjectDTO, dal.Models.Project.Project>().ReverseMap();
            CreateMap<ProjectTranslateDTO, ProjectTranslate>().ReverseMap();
            CreateMap<dal.Models.Project.Project, ProjectDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.ProjectTranslates.Select(p => p.Title).FirstOrDefault()));
            CreateMap<dal.Models.Project.Project, ProjectDetailDTO>()
                .ForMember(p => p.Title, p => p.MapFrom(p => p.ProjectTranslates.Select(p => p.Title).FirstOrDefault()))
                .ForMember(p => p.Description, p => p.MapFrom(p => p.ProjectTranslates.Select(p => p.Description).FirstOrDefault()))
                .ForMember(p => p.Location, p => p.MapFrom(p => p.Location.LocationTranslates.Select(p => p.Name).FirstOrDefault()))
                .ForMember(p => p.Client, p => p.MapFrom(p => p.Client.Name))
                .ForMember(p => p.Status, p => p.MapFrom(p => p.Status.StatusTranslates.Select(p => p.Name).FirstOrDefault()));

            CreateMap<CreateUserDTO, User>();
            CreateMap<User, UserDTO>();

            CreateMap<Language, LanguageDTO>();
            CreateMap<LanguageDTO, Language>();
        }
    }
}
