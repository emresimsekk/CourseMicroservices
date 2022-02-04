using AutoMapper;
using Course.Services.Catalog.Dtos;
using Course.Services.Catalog.Model;

namespace Course.Services.Catalog.Mapping
{
    public class CategoryServicesMapping : Profile
    {
        public CategoryServicesMapping()
        {
            CreateMap<Model.Course, CourseDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();

            CreateMap<Model.Course, CourseCreateDto>().ReverseMap();
            CreateMap<Model.Course, CourseUpdateDto>().ReverseMap();

            CreateMap<Category, CategoryCreateDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
        }
    }
}
