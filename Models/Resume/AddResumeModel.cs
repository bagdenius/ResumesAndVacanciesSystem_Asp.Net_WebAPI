using Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace UI.Models.Resume
{
    public class AddResumeModel
    {
        [Required(ErrorMessage = "Введіть ідентифікаційний номер")]
        public Guid UserId { get; set; }


        [Required(ErrorMessage = "Введіть заголовок резюме")]
        [MinLength(12, ErrorMessage = "Заголовок не може бути менше 12 символів")]
        [MaxLength(90, ErrorMessage = "Заголовок не може перевищувати 90 символів")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Введіть бажану/і посаду/и або сферу роботи")]
        [MinLength(3, ErrorMessage = "Посада не може бути менше трьох символів")]
        [MaxLength(100, ErrorMessage = "Посада не може перевищувати 1000 символів")]
        public string Position { get; set; }


        [Required(ErrorMessage = "Введіть очікувану заробітню плату", AllowEmptyStrings = true)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Заробітня плата може мати лише цифри")]
        public string Salary { get; set; }


        [Required(ErrorMessage = "Оберіть рівень зайнятості")]
        [EnumDataType(typeof(Employement), ErrorMessage = "Рівень зайнятості вказаний некоректно")]
        public Employement Employement { get; set; }


        [Required(ErrorMessage = "Введіть вміст резюме")]
        [MinLength(100, ErrorMessage = "Вміст резюме не може бути менше 100 символів")]
        public string Content { get; set; }
    }
}
