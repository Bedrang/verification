using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hackingion.Models
{
    public class Register
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Заполните поле Имя пользователя", AllowEmptyStrings = false)]
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Заполните поле пароль", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Минимальная длинна пароля 8 знаков")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Display(Name = "Подтвердите пароль")]
        public string ConfirmPassword { get; set; }

        
        public string SecurityStamp { get; set; }




        [Required(ErrorMessage = "Укажите имя и фамилию питомца", AllowEmptyStrings = false)]
        [RegularExpression(@"^[A-ЯЁ][а-яё]+\s[A-ЯЁ][а-яё]+$")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Некорректная длина имени")]
        [Display(Name = "Имя питомца")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Укажите породу", AllowEmptyStrings = false)]
        [DataType(DataType.Url)]
        [Display(Name = "Порода")]
        public string Breed { get; set; }

        [Required(ErrorMessage = "Укажите дату рождения формат 'гггг-ММ-дд'", AllowEmptyStrings = false)]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Имя пользователя")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Укажите цвет питомца", AllowEmptyStrings = false)]
        [RegularExpression(@"[а-я]+$")]
        [DataType(DataType.Text)]
        [Display(Name = "Цвет питомца")]
        //[DisplayFormat=""]
        public string Color { get; set; }

        [Required(ErrorMessage = "Укажите описание", AllowEmptyStrings = false)]
        [StringLength(4000, MinimumLength = 40, ErrorMessage = "Недостаточно информации")]
        [DataType(DataType.Text)]
        [Display(Name = "Описание питомца")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Укажите пол", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Укажите телефон формат Х-ХХХ-ХХХ-ХХХХ", AllowEmptyStrings = false)]
        //[RegularExpression(@"^[0-9]{1}-[0-9]{3}-[0-9]{3}[0-9]{4}$")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Телефонный номер")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Укажите E-mail", AllowEmptyStrings = false)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public byte[] File { get; set; }

    }
}
