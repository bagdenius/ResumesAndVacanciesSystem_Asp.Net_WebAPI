using Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace UI.Models.User
{
    public class AddUserModel
    {
        // Account
        [Required(ErrorMessage = "Введіть логін")]
        [MinLength(3, ErrorMessage = "Логін не може бути менше трьох символів")]
        [MaxLength(25, ErrorMessage = "Логін не може перевищувати 25 символів")]
        public string Login { get; set; }


        [Required(ErrorMessage = "Введіть пароль")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Пароль не може бути менше п'яти символів")]
        [MaxLength(35, ErrorMessage = "Пароль не може перевищувати 35 символів")]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Паролі повинні співпадати")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Оберіть варіант")]
        [EnumDataType(typeof(Role), ErrorMessage = "Роль вказана некоректно")]
        public Role Role { get; set; }


        // Profile
        [Required(ErrorMessage = "Введіть ім'я")]
        [MinLength(2, ErrorMessage = "Ім'я не може бути менше двох символів")]
        [MaxLength(25, ErrorMessage = "Ім'яне може перевищувати 25 символів")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Введіть прізвище")]
        [MinLength(2, ErrorMessage = "Прізвище не може бути менше двох символів")]
        [MaxLength(25, ErrorMessage = "Прізвище не може перевищувати 25 символів")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Введіть ім'я по батькові")]
        [MinLength(5, ErrorMessage = "Ім'я по батькові не може бути менше п'яти символів")]
        [MaxLength(25, ErrorMessage = "Ім'я по батькові не може перевищувати 25 символів")]
        public string Patronymic { get; set; }


        [Required(ErrorMessage ="Оберіть рівень освіти")]
        [EnumDataType(typeof(Education), ErrorMessage = "Рівень освіти вказаний некоректно")]
        public Education Education { get; set; }


        [Required(ErrorMessage = "Оберіть стать")]
        [EnumDataType(typeof(Gender), ErrorMessage = "Стать вказана некоректно")]
        public Gender Gender { get; set; }


        [Required(ErrorMessage ="Введіть дату народження")]
        [DataType(DataType.Date, ErrorMessage = "Дата народження вказана некоректно")]
        public DateTime BirthDate { get; set; }


        [Required(ErrorMessage = "Оберіть місто чи область")]
        [EnumDataType(typeof(City), ErrorMessage = "Місто вказано некоректно")]
        public City City { get; set; }


        [Required(ErrorMessage ="Введіть номер телефону")]
        [Phone(ErrorMessage = "Номер телефону вказаний некоректно")]
        public string Phone { get; set; }


        [Required(ErrorMessage ="Введіть електронну адресу")]
        [EmailAddress(ErrorMessage = "Електронна адреса вказана некоректно")]
        public string Email { get; set; }
    }
}
