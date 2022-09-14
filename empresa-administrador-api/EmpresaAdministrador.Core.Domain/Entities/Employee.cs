using EmpresaAdministrador.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Domain.Entities
{
    public class Employee : AuditableBaseEntity
    {

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        
        public string City { get; set; }

       
        public string Province { get; set; }

     
        public string Country { get; set; }

        public string Gender { get; set; }

        public long Telephone { get; set; }

        public string Email { get; set; }

        // Relations and Navigation Properties

        // Nationality
        public int NationalityId { get; set; }

        public Nationality Nationality { get; set; }

        // JobTitle
        public int JobTitleId { get; set; }

        public JobTitle JobTitle { get; set; }

        // JobCategory

        public int JobCategoryId { get; set; }  

        public JobCategory JobCategory { get; set; }


        // Employment Status

        public int EmploymentStatusId { get; set; }

        public EmploymentStatus EmploymentStatus { get; set; }

    }
}
