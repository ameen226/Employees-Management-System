using AutoMapper;
using DAL.Models;
using PL.ViewModels;

namespace PL.MappingProfiles
{
    public class UserProfile : Profile
    {

        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>();
        }

    }
}
