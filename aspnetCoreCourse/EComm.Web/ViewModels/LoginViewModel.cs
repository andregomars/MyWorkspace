using System.ComponentModel.DataAnnotations;

namespace EComm.Web.ViewModels
{
  public class LoginViewModel
  {
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }

    public string ReturnUrl { get; set; }
  }
}