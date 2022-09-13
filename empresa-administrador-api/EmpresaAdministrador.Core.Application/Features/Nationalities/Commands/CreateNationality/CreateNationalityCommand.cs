using AutoMapper;
using EmpresaAdministrador.Core.Application.Interfaces.Repositories;
using MediatR;
using EmpresaAdministrador.Core.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Features.Nationalities.Commands.CreateNationality
{
    public class CreateNationalityCommand : IRequest<bool>
    {
        
        [SwaggerParameter(Description = "Nombre de la nacionalidad")]
        public string Name { get; set; }
    }

    public class CreateNationalityCommandHandler : IRequestHandler<CreateNationalityCommand, bool>  
        {
            private readonly INationalityRepository _nationalityRepo;
            private readonly IMapper _mapper;

            public CreateNationalityCommandHandler(INationalityRepository nationalityRepo, IMapper mapper)
        {
            _nationalityRepo = nationalityRepo;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateNationalityCommand request, CancellationToken cancellationToken)
        {
            var nationality = _mapper.Map<Nationality>(request);
            nationality = await _nationalityRepo.AddAsync(nationality);

            return nationality != null;
        }
    }
     
}