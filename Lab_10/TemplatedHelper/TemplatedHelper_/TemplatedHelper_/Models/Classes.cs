using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TemplatedHelper_.Models
{
    // public class User
    // {
    //     // [HiddenInput(DisplayValue=false)]
    //     [ScaffoldColumn(false)]
    //     public int UserId { get; set; }
    //     public string FirstName { get; set; }
    //     public string LastName { get; set; }
    //     public DateTime BirthDate { get; set; }
    //     public Address HomeAddress { get; set; }
    //     public bool IsApproved { get; set; }
    //     public Role Role { get; set; }
    // }
    
    // [DisplayName("новый юзер")]
    // public class User
    // {
    //     [HiddenInput(DisplayValue=false)]
    //     public int UserId { get; set; }
    //
    //     [DisplayName("Имя")]
    //     public string FirstName { get; set; }
    //
    //     [DisplayName("Фамилия")]
    //     public string LastName { get; set; }
    //
    //     [DisplayName("Дата рождения")]
    //     [DataType(DataType.Date)]
    //     public DateTime BirthDate { get; set; }
    //
    //     [DisplayName("Адрес")]
    //     public Address HomeAddress { get; set; }
    //
    //     [DisplayName("Подтвердил регистрацию?")]
    //     public bool IsApproved { get; set; }
    //
    //     [DisplayName("Роль")]
    //     public Role Role { get; set; }
    // }

    [DisplayName("новый юзер")]
    public partial class User
    {
        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }

        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [DisplayName("Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DisplayName("Адрес")]
        public Address HomeAddress { get; set; }

        [DisplayName("Подтвердил регистрацию?")]
        public bool IsApproved { get; set; }

        [UIHint("Enum")]
        [DisplayName("Роль")]
        public Role Role { get; set; }
    }
    
    public class Address
    {
        [DisplayName("Адрес 1")]
        public string Line1 { get; set; }

        [DisplayName("Адрес 2")]
        public string Line2 { get; set; }

        [DisplayName("Город")]
        public string City { get; set; }

        [DisplayName("Почтовый индекс")]
        public string PostalCode { get; set; }

        [DisplayName("Страна")]
        public string Country { get; set; }
    }

    public enum Role
    {
        Admin,
        User,
        Guest
    }
}