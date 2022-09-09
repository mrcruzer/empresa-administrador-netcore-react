using AutoMapper;
using empresa_administrador_api.Dtos.API.Nationality;
using empresa_administrador_api.Interfaces.Repositories;
using MediatR;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmpresaAdministradorApi.Core.Application.Features.Nationality.Queries.GetNationalityById
{
    public class GetNationalityByIdQuery:IRequest<NationalityResponse>
    {
        [SwaggerParameter(Description = "Id de la nacionalidad")]
        public int Id { get; set; }
    }

    public class GetNationalityByIdQueryHandler : IRequestHandler<GetNationalityByIdQuery, NationalityResponse>
    {
        private readonly INationalityRepository _nationalityRepo;
        private readonly IMapper _mapper;

        public GetNationalityByIdQueryHandler(INationalityRepository nationalityRepo, IMapper mapper)
        {
            _nationalityRepo = nationalityRepo;
            _mapper = mapper;
        }

        public async Task<NationalityResponse> Handle(GetNationalityByIdQuery request, CancellationToken cancellationToken)
        {
            var nationality = await _nationalityRepo.GetByIdAsync(request.Id);
            return _mapper.Map<NationalityResponse>(nationality);
        }
    }
}
