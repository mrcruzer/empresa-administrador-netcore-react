using AutoMapper;
using EmpresaAdministrador.Core.Application.Dtos.API.Nationality;
using EmpresaAdministrador.Core.Application.Interfaces.Repositories;
using EmpresaAdministrador.Core.Domain.Entities;
using MediatR;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Features.Nationalities.Commands.UpdateNationality
{
    public class UpdateNationalityCommand: IRequest<NationalityResponse>
    {
        [SwaggerParameter(Description = "Id de la nacionalidad")]
        public int Id { get; set; }

        [SwaggerParameter(Description = "Nombre de la nacionalidad")]
        public string Name { get; set; }
    }

    public class UpdateNationalityCommandHandler : IRequestHandler<UpdateNationalityCommand, NationalityResponse>
    {
        private readonly INationalityRepository _nationalityRepository;
        private readonly IMapper _mapper;

        public UpdateNationalityCommandHandler(INationalityRepository nationalityRepository, IMapper mapper)
        {
            _nationalityRepository = nationalityRepository;
            _mapper = mapper;
        }

        public async Task<NationalityResponse>Handle(UpdateNationalityCommand request, CancellationToken cancellationToken)
        {
            var nationality = _mapper.Map<Nationality>(request);

            if(nationality == null)
                return null;

            await _nationalityRepository.UpdateAsync(nationality, request.Id);

            return _mapper.Map<NationalityResponse>(request);
            
        }
    }
}
