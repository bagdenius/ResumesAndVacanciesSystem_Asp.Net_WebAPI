using System.ComponentModel.DataAnnotations;

namespace Entities.Enums
{
    public enum Education
    {
        [Display(Name = "Початкова загальна")]
        PrimaryGeneral,

        [Display(Name = "Базова загальна середня")]
        BasicGeneralSecondary,

        [Display(Name = "Повна загальна середня")]
        CompleteSecondary,

        [Display(Name = "Професійно-технічна")]
        VocationalAndTechnical,

        [Display(Name = "Базова вища")]
        BasicHigher,

        [Display(Name = "Повна вища")]
        Higher
    }
}
