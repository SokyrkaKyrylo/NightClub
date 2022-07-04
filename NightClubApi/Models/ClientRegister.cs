using System.ComponentModel.DataAnnotations;
using NightClubApi.Attributes;

namespace NightClubApi.Models;

public class ClientRegister
{
    [Required]
    public string Name { get; set; }

    [Required]
    [PhoneValidation("^[+]?[(]?[0-9]{1,3}[)]?\\-[0-9]{2}(\\-([0-9]{3}))(\\-([0-9]{4}))$")]
    public string PhoneNumber { get; set; }

    [Required]
    [AgeValidation(18, 30)]
    public int Age { get; set; }
}