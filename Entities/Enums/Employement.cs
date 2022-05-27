using System.ComponentModel.DataAnnotations;

namespace Entities.Enums
{
    public enum Employement
    {
        [Display(Name = "Повна")]
        Full,

        [Display(Name = "Неповна")]
        Incomplete,

        [Display(Name = "Часткова")]
        Partial,

        [Display(Name = "Тимчасова")]
        Temporary,

        [Display(Name = "Сезонна")]
        Seasonal
    }
}
