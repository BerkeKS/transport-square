using System.ComponentModel.DataAnnotations;

namespace Transport_Square.Models;

public class UserViewModel{

    [Key]
    public string Username {get; set;}
    public string Name {get; set;}
    [Range(10, int.MaxValue, ErrorMessage = "Users below age 10 can not register.")]
    public int Age {get; set;}
    [Required]
    public string Password {get; set;}

}