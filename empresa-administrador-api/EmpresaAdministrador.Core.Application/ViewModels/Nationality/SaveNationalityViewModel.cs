using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application.ViewModels.Nationality
{
    public class SaveNationalityViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Debes colocar la nacionalidad")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

    }
}
