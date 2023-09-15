using System.ComponentModel.DataAnnotations;
using Cms.Shared.Entities;

namespace Cms.Shared.Models;

public class RegisterModel
{
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
    public UserProfile UserProfile { get; set; }
}