using EmpresaAdministrador.Core.Application.Interfaces.Repositories;
using MediatR;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.Features.Nationalities.Commands.DeleteNationality
{
    public class DeleteNationalityCommand : IRequest<bool>
    {
        [SwaggerParameter(Description = "Id de la nacionalidad")]
        public int Id { get; set; }

        public class DeleteNationalityCommandHandler : IRequestHandler<DeleteNationalityCommand, bool>
        {
            private readonly INationalityRepository _nationalityRepository;

            public DeleteNationalityCommandHandler(INationalityRepository nationalityRepository)
            {
                _nationalityRepository = nationalityRepository;
            }

            public async Task<bool> Handle(DeleteNationalityCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    var nationality = await _nationalityRepository.GetByIdAsync(request.Id);

                    if (nationality == null)
                        return false;

                    await _nationalityRepository.DeleteAsync(nationality);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }
    }
}
