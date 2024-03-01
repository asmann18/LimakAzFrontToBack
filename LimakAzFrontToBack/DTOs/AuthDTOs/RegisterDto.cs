using System;
using System.ComponentModel.DataAnnotations;

namespace LimakAzFrontToBack.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Seria Number is required")]
        public string SeriaNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "FinCode is required")]
        public string FinCode { get; set; }

        [Required(ErrorMessage = "Birtday is required")]
        [DataType(DataType.Date)]
        public DateTime Birtday { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public int GenderId { get; set; }

        [Required(ErrorMessage = "Citizenship is required")]
        public int CitizenshipId { get; set; }

        [Required(ErrorMessage = "User Position is required")]
        public int UserPositionId { get; set; }

        [Required(ErrorMessage = "Warehouse is required")]
        public int WarehouseId { get; set; }
    }
}
