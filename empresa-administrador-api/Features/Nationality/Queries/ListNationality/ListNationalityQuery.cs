using AutoMapper;
using empresa_administrador_api.Data;
using empresa_administrador_api.Dtos.API.Nationality;
using empresa_administrador_api.Interfaces.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace empresa_administrador_api.Features.Nationality.Queries.ListNationality
{

    

    public class ListNationalityQuery:IRequest<IList<NationalityResponse>>
    {
        private readonly EmpresaDbContext _context;
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
