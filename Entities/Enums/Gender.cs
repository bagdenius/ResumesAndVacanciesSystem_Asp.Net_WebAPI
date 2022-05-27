
using System.ComponentModel.DataAnnotations;

namespace Entities.Enums
{
    public enum Gender
    {
        [Display(Name = "Чоловіча")]
        Male,

        [Display(Name = "Жіноча")]
        Female
    }
}
