using AutoMapper;
using EmpresaAdministrador.Core.Application.Interfaces.Repositories;
using EmpresaAdministrador.Core.Application.Dtos.API.Nationality;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Features.Nationalities.Queries.ListNationality
{

    public class ListNationalityQuery:IRequest<IList<NationalityResponse>>
    {
      
    }

    public class ListNationalityQueryHandler : IRequestHandler<ListNationalityQuery, IList<NationalityResponse>>
    {
        private readonly INationalityRepository _nationalityRepo;
        private readonly IMapper _mapper; 
        //private readonly EmpresaDbContext _context;

        public ListNationalityQueryHandler(INationalityRepository nationalityRepo, IMapper mapper)
        {
            _nationalityRepo = nationalityRepo;
            _mapper = mapper;
        }

        public async Task<IList<NationalityResponse>> Handle(ListNationalityQuery request, CancellationToken cancellationToken)
        {
            
        //var nationality = await _nationalityRepo.GetAllAsync();
            var nationality = await _nationalityRepo.GetAllAsync();
            //return (IList<NationalityResponse>)nationality;

            return _mapper.Map<List<NationalityResponse>>(nationality);
        }
    }
}
