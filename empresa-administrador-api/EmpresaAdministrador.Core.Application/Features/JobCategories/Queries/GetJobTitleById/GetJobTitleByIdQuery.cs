using AutoMapper;
using EmpresaAdministrador.Core.Application.Dtos.API.JobTitle;
using EmpresaAdministrador.Core.Application.Interfaces.Repositories;
using MediatR;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Features.JobCategories.Queries.GetJobTitleById
{
    public class GetJobTitleByIdQuery : IRequest<JobTitleResponse>
    {
        [SwaggerParameter(Description = "Id de la nacionalidad")]
        public int Id { get; set; }

        public class GetJobTitleByIdQueryHandler : IRequestHandler<GetJobTitleByIdQuery, JobTitleResponse>
        {
            public readonly IJobTitleRepository _jobTitleRepo;
            public readonly IMapper _mapper;
            public GetJobTitleByIdQueryHandler(IJobTitleRepository jobTitleRepo, IMapper mapper )
            {
                _jobTitleRepo = jobTitleRepo;
                _mapper = mapper;
            }

            public async Task<JobTitleResponse> Handle(GetJobTitleByIdQuery request, CancellationToken cancellationToken)
            {
                var jobTitle = await _jobTitleRepo.GetByIdAsync(request.Id);
                return _mapper.Map<JobTitleResponse>(jobTitle);
            }
        }
    }
}
