using AutoMapper;
using HolidaySlug.API.DomainModels;
using HolidaySlug.Data.Entities;
using HolidaySlug.Services.DTO;

namespace HolidaySlug.API.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //dto to domain
            CreateMap<HolidayDTO, HolidayModel>();
            CreateMap<UserDTO, UserModel>();
            CreateMap<UserTeamDTO, UserTeamModel>();
            CreateMap<HolidayHistoryDto, HolidayHistoryModel>();
            CreateMap<TeamsDTO, TeamsModel>();
            CreateMap<UserTeamDTO, UserTeamModel>();
            
            // entity to dto
            CreateMap<Holiday, HolidayDTO>();
            CreateMap<User, UserDTO>();
            CreateMap<UserTeam, UserTeamDTO>();
            CreateMap<HolidayHistory, HolidayHistoryDto>();
            CreateMap<Teams, TeamsDTO>();
            CreateMap<UserTeam, UserTeamDTO>();
           
        }
    }
}