using AutoMapper;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Customer, CustomersViewModel>();
            CreateMap<CustomersViewModel, Customer>();
        }
    }
}
