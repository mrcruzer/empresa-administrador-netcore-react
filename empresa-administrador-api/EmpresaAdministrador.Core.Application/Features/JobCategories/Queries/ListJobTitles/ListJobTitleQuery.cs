using AutoMapper;
using EmpresaAdministrador.Core.Application.Dtos.API.JobTitle;
using EmpresaAdministrador.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Features.JobCategories.Queries.ListJobTitles
{
    public class ListJobTitleQuery : IRequest<IList<JobTitleResponse>>
    {
        public class ListJobTitleQueryHandler : IRequestHandler<ListJobTitleQuery, IList<JobTitleResponse>>
        {
            private readonly IJobTitleRepository _jobTitleRepo;
            private readonly IMapper _mapper;

            public ListJobTitleQueryHandler(IJobTitleRepository jobTitleRepo, IMapper mapper)
            {
                _jobTitleRepo = jobTitleRepo;
                _mapper = mapper;
            }

            public async Task<IList<JobTitleResponse>> Handle(ListJobTitleQuery request, CancellationToken cancellationToken)
            {
                var jobTitle = await _jobTitleRepo.GetAllAsync();
                return _mapper.Map<List<JobTitleResponse>>(jobTitle);
            }
        }
    }
}
