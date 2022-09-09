using AutoMapper;
using Microsoft.AspNetCore.Http; 
//using EmpresaAdministradorApi.Core.Application.Dtos.Account;
using EmpresaAdministrador.Core.Application.Interfaces.Repositories;
using EmpresaAdministrador.Core.Application.Interfaces.Services;
using EmpresaAdministrador.Core.Application.ViewModels.Nationality;
using EmpresaAdministrador.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Services
{
    public class NationalityService : GenericService<Nationality, NationalityViewModel, SaveNationalityViewModel>, INationalityService
    {
        private readonly INationalityRepository _nationalityRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly LoginResponse _user;
        private readonly IMapper _mapper;

        public NationalityService(INationalityRepository repo, IHttpContextAccessor httpContextAccessor, IMapper mapper) : base(repo, mapper)
        {
            _nationalityRepository = repo;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
           // _user = _httpContextAccessor.HttpContext.Session.Get<LoginResponse>("user");
        }

        public async Task<List<NationalityViewModel>> GetAllViewModelWithInclude()
        {
            List<Nationality> nationalities = await _nationalityRepository.GetAllAsync();
            List<NationalityViewModel> viewModelList = _mapper.Map<List<NationalityViewModel>>(nationalities);
            return viewModelList;
        }
    }
}