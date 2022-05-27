using Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace UI.Models.Vacancy
{
    public class AddVacancyModel
    {
        [Required(ErrorMessage = "Введіть ідентифікаційний номер користувача")]
        public Guid UserId { get; set; }


        [Required(ErrorMessage = "Введіть заголовок вакансії")]
        [MinLength(12, ErrorMessage = "Заголовок вакансії не може бути менше 12 символів")]
        [MaxLength(100, ErrorMessage = "Заголовок вакансії не може перевищувати 100 символів")]
        public string Title { get; set; }



        [Required(ErrorMessage = "Введіть опис вакансії")]
        [MinLength(100, ErrorMessage = "Опис вакансії не може бути менше 100 символів")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Оберіть місто чи область")]
        [EnumDataType(typeof(City), ErrorMessage = "Місто вказано некоректно")]
        public City City { get; set; }


        [Required(ErrorMessage = "Введіть назву компанії")]
        [MinLength(3, ErrorMessage = "Назва компанії не може бути менше 3 символів")]
        [MaxLength(50, ErrorMessage = "Назва компанії не може перевищувати 50 символів")]
        public string Company { get; set; }


        [Required(ErrorMessage = "Введіть назву посади")]
        [MinLength(3, ErrorMessage = "Посада не може бути менше трьох символів")]
        [MaxLength(50, ErrorMessage = "Посада не може перевищувати 50 символів")]
        public string Position { get; set; }


        [Required(ErrorMessage = "Введіть очікувану заробітню плату", AllowEmptyStrings = true)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Заробітня плата може мати лише цифри")]
        public string Salary { get; set; }


        [Required(ErrorMessage = "Оберіть рівень зайнятості")]
        [EnumDataType(typeof(Employement), ErrorMessage = "Рівень зайнятості вказаний некоректно")]
        public Employement Employement { get; set; }


        [Required(ErrorMessage = "Оберіть робочі дні")]
        [EnumDataType(typeof(WorkingDays), ErrorMessage = "Робочі дні вказані некоректно")]
        public WorkingDays WorkingDays { get; set; }


        [Required(ErrorMessage = "Оберіть робочий графік")]
        [EnumDataType(typeof(WorkingHours), ErrorMessage = "Робочий графік вказано некоректно")]
        public WorkingHours WorkingHours { get; set; }


        [Required(ErrorMessage = "Введіть номер телефону")]
        [Phone(ErrorMessage = "Номер телефону вказаний некоректно")]
        public string Phone { get; set; }
    }
}
