
namespace LoginFormMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        public int Id { get; set; }
        [DisplayName("Username:")]
        [Required(ErrorMessage ="Username is required")]

        public string username { get; set; }

        [DisplayName("Password:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }
    }
}
