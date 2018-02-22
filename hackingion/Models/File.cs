using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hackingion.Models
{
    public class FileModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите имя", AllowEmptyStrings = false)]
        [StringLength(16, MinimumLength = 2, ErrorMessage = "Некорректная длина имени")]
        [Display(Name = "Имя пользователя")]
        public string Name { get; set; }

        public string Path { get; set; }

        [Required(ErrorMessage = "Укажите породу", AllowEmptyStrings = false)]
        [DataType(DataType.Url)]
        [Display(Name = "Имя пользователя")]
        public string Breed { get; set; }

        [Required(ErrorMessage = "Укажите породу", AllowEmptyStrings = false)]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Имя пользователя")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Укажите цвет", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [Display(Name = "Имя пользователя")]
        //[DisplayFormat=""]
        public string Color { get; set; }

        [Required(ErrorMessage = "Укажите описание", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Укажите пол", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [Display(Name = "Имя пользователя")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Укажите телефон", AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Укажите E-mail", AllowEmptyStrings = false)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Имя пользователя")]
        public string Email { get; set; }

        public byte[] File { get; set; }

    }
    public class FileViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Укажите имя", AllowEmptyStrings = false)]
        [StringLength(16, MinimumLength = 2, ErrorMessage = "Некорректная длина имени")]
        [Display(Name = "Имя питомца")]
        public string Name { get; set; }

        public string Path { get; set; }

        [Required(ErrorMessage = "Укажите породу", AllowEmptyStrings = false)]
        [DataType(DataType.Url)]
        [Display(Name = "Порода")]
        public string Breed { get; set; }

        [Required(ErrorMessage = "Укажите возраст", AllowEmptyStrings = false)]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата рождения")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Укажите цвет", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [Display(Name = "Цвет питомца")]
        //[DisplayFormat=""]
        public string Color { get; set; }

        [Required(ErrorMessage = "Укажите описание", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [Display(Name = "Описание питомца")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Укажите пол", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Укажите телефон", AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Номер телефона владельца")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Email владельца", AllowEmptyStrings = false)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Имя пользователя")]
        public string Email { get; set; }

        public IFormFile File { get; set; }
        

    }
}
