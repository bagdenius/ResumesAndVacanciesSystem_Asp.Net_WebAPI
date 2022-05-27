using System.ComponentModel.DataAnnotations;

namespace Entities.Enums
{
    public enum WorkingDays
    {
        [Display(Name ="Вільний графік роботи")]
        FreeDays,

        [Display(Name = "Один день на тиждень")]
        SingleDay,

        [Display(Name = "Два дні на тиждень")]
        TwoDay,

        [Display(Name = "Три дні на тиждень")]
        ThreeDay,

        [Display(Name = "Чотири дні на тиждень")]
        FourDay,

        [Display(Name = "П'ять днів на тиждень")]
        FiveDay,

        [Display(Name = "Шість днів на тиждень")]
        SixDay,

        [Display(Name = "Сім днів на тиждень")]
        EveryDay
    }
}
