using EmpresaAdministrador.Core.Application.Dtos.Account;
using EmpresaAdministrador.Core.Application.ViewModels.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Interfaces.Services
{
    public interface IAccountService
    {
        Task<List<UserViewModel>> GetAllUsers();
        Task<SaveUserViewModel> GetByIdSaveUserViewModel(string id);
        Task<LoginResponse> LoginAsync(LoginRequest request);
        Task<RegisterResponse> RegisterAdminUserAsync(RegisterRequest request);
        Task<SetUserResponse> SetUserStatusAsync(string userId, bool status);
        Task<RegisterResponse> UpdateUserAsync(RegisterRequest request);
        Task DeleteUser(string id);
        Task SignOutAsync();
    }
}