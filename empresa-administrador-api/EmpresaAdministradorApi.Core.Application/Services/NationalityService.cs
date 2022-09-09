using AutoMapper;
using Microsoft.AspNetCore.Http; 
//using EmpresaAdministradorApi.Core.Application.Dtos.Account;
using EmpresaAdministradorApi.Core.Application.Interfaces.Repositories;
using EmpresaAdministradorApi.Core.Application.Interfaces.Services;
using EmpresaAdministradorApi.Core.Application.ViewModels.Nationality;
using EmpresaAdministradorApi.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Core.Application.Services
{
    public class SellTypeService : GenericService<SellType, SellTypeViewModel, SaveSellTypeViewModel>, ISellTypeService
    {
        private readonly ISellTypeRepository _sellRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly LoginResponse _user;
        private readonly IMapper _mapper;

        public SellTypeService(ISellTypeRepository repo, IHttpContextAccessor httpContextAccessor, IMapper mapper) : base(repo, mapper)
        {
            _sellRepository = repo;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _user = _httpContextAccessor.HttpContext.Session.Get<LoginResponse>("user");
        }

        public async Task<List<SellTypeViewModel>> GetAllViewModelWithInclude()
        {
            List<SellType> sellTypes = await _sellRepository.GetAllWithIncludes(new List<string> { "Properties" });
            List<SellTypeViewModel> viewModelList = _mapper.Map<List<SellTypeViewModel>>(sellTypes);
            return viewModelList;
        }
    }
}