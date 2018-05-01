using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BasicAuthenticationII.ViewModels
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RegisterViewModel
    {
        //private readonly RequestDelegate _next;

        //public RegisterViewModel(RequestDelegate next)
        //{
        //    _next = next;
        //}

        //public Task Invoke(HttpContext httpContext)
        //{

        //    return _next(httpContext);
        //}

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }

    //// Extension method used to add the middleware to the HTTP request pipeline.
    //public static class RegisterViewModelExtensions
    //{
    //    public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<RegisterViewModel>();
    //    }
    //}
}
