﻿using System.ComponentModel.DataAnnotations;

namespace AlugaCars.Application.Model.Usuario
{
    public class CreateUsuarioDto
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string PasswordConfirm { get; set; }
    }
}
