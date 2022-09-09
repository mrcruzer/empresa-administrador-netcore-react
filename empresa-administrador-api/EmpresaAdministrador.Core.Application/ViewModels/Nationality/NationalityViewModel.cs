using EmpresaAdministrador.Core.Application.ViewModels.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.ViewModels.Nationality
{
    public class NationalityViewModel : BaseViewModel
    {
        public string Name { get; set; }

        #region Navigation Properties

        public ICollection<EmployeeViewModel> Employees { get; set; }
        #endregion
    }
}
