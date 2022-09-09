using AutoMapper;
using empresa_administrador_api.Dtos.API.Nationality;
using empresa_administrador_api.Features.Nationality.Commands.CreateNationality;
using empresa_administrador_api.Features.Nationality.Commands.UpdateNationality;
using empresa_administrador_api.Models;

namespace empresa_administrador_api.Mappings
{
    public class GeneralProfile : Profile
    {

        public GeneralProfile()
        {

            // ///////////////////////////////////////////////////////////////////////////////////////////////////////
            // ///////////////////////////////////////////////////////////////////////////////////////////////////////
            // ///////////////////////////////////////////////////////////////////////////////////////////////////////
            // CQRS DTOs - Entities

            ///<Entity>
            /// Nationality
            /// </Entity>
            CreateMap<Nationality, NationalityResponse>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.Employees, opt => opt.Ignore());

            CreateMap<Nationality, CreateNationalityCommand>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.Employees, opt => opt.Ignore());

            CreateMap<Nationality, UpdateNationalityCommand>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.Employees, opt => opt.Ignore());
     
        }
       
    }
}
