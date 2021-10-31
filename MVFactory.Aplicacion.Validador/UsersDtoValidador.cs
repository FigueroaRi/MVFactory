using System;
using FluentValidation;
using MVFactory.Aplicacion.DTO;

namespace MVFactory.Aplicacion.Validador
{
    public class UsersDtoValidador:AbstractValidator<UsersDto>
    {

        public UsersDtoValidador()
        {
            RuleFor(u => u.UserName).NotNull().NotEmpty();
            RuleFor(u => u.Password).NotNull().NotEmpty();
        }
    }
}
