using System.ComponentModel.DataAnnotations;

namespace Entities.Enums
{
    public enum WorkingHours
    {
        [Display(Name = "Вільний графік роботи")]
        FreeHours,

        [Display(Name = "Одна година на добу")]
        OneHour,

        [Display(Name = "Дві години на добу")]
        TwoHours,

        [Display(Name = "Три години на добу")]
        ThreeHours,

        [Display(Name = "Чотири години на добу")]
        FourHours,

        [Display(Name = "П'ять годин на добу")]
        FiveHours,

        [Display(Name = "Шість годин на добу")]
        SixHours,

        [Display(Name = "Сім годин на добу")]
        SevenHours,

        [Display(Name = "Вісім годин на добу")]
        EightHours,

        [Display(Name = "Дев'ять годин на добу")]
        NineHours,

        [Display(Name = "Десять годин на добу")]
        TenHours,

        [Display(Name = "Одинадцять годин на добу")]
        ElevenHours,

        [Display(Name = "Дванадцять годин на добу")]
        TwelveHours,
    }
}
