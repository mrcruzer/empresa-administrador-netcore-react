using AutoMapper;
using EmpresaAdministrador.Core.Application.Dtos.API.Nationality;
using EmpresaAdministrador.Core.Application.Features.Nationality.Commands.CreateNationality;
using EmpresaAdministrador.Core.Application.Features.Nationality.Commands.UpdateNationality;
using EmpresaAdministrador.Core.Application.ViewModels.Nationality;
using EmpresaAdministrador.Core.Domain.Entities;

namespace EmpresaAdministrador.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {

        public GeneralProfile()
        {


            // ViewModels and Entities

            /// <Entity>
            /// Nationality
            /// </Entity>
            CreateMap<Nationality, NationalityViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore());

            CreateMap<Nationality, NationalityViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.Employees, opt => opt.Ignore());


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
