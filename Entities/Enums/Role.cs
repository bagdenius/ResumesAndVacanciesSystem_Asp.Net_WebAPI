using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    public enum Role
    {
        [Display(Name = "Адміністратор")]
        Admin,

        [Display(Name = "Роботодавець")]
        Recruiter,

        [Display(Name = "Працівник")]
        Employee
    }
}
